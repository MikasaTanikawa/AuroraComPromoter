using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace AuroraComPromoter
{
    internal class Commander
    {

        public Commander(int commanderID, string name, int rankID, decimal gameTimePromoted)
        {
            CommanderID = commanderID;
            Name = name;
            RankID = rankID;
            GameTimePromoted = gameTimePromoted;
        }

        public int CommanderID { get; }
        public string Name { get; }
        public int RankID { get; }
        public decimal GameTimePromoted { get; }

        internal static List<Commander> Read(SQLiteConnection dbConnection, int gameID, Race race,
            int commanderType, List<Rank> ranks)
        {
            var commanders = new List<Commander>();

            var dataAdapter = new SQLiteDataAdapter(
                 $@"select * from FCT_Commander 
                    where GameID = {gameID} and RaceID = {race.RaceID} 
                    and CommanderType = {commanderType} and CommandType = 0
                    and RetireStatus = 0  and POWRaceID = 0 and Deceased = 0
                    and DoNotPromote = 0 and RetainRetired = 0", dbConnection);
            dataAdapter.SelectCommand.CommandTimeout = 360;
            var data = new DataTable();
            dataAdapter.Fill(data);

            foreach (DataRow row in data.Rows)
            {
                int rankID = Convert.ToInt32(row["RankID"]);
                int rankPriority = ranks.Find(rank => rank.RankID == rankID).Priority;

                if (rankPriority > (commanderType == race.SelectedNavalRank.RankType ?
                    race.SelectedNavalRank.Priority : race.SelectedGroundRank.Priority))
                {
                    var commander = new Commander(Convert.ToInt32(row["CommanderID"]), row["Name"].ToString(),
                        rankID, Convert.ToDecimal(row["GameTimePromoted"]));

                    commanders.Add(commander);
                }
            }

            return commanders;
        }

        internal void Promote(SQLiteConnection dbConnection, Game game, Rank promoteTo, IEnumerable<Rank> ranks)
        {
            using (var sqliteCommand = new SQLiteCommand(dbConnection))
            {
                bool promote = false;

                foreach (var rank in ranks)
                {
                    if (promote)
                    {
                        sqliteCommand.CommandText =
                            "INSERT INTO FCT_CommanderHistory " +
                            "( GameID, CommanderID, HistoryText, GameTime ) " +
                            "VALUES ( @GameID, @CommanderID, @HistoryText, @GameTime )";
                        sqliteCommand.Parameters.AddWithValue("@GameID", game.GameID);
                        sqliteCommand.Parameters.AddWithValue("@CommanderID", this.CommanderID);
                        sqliteCommand.Parameters.AddWithValue("@HistoryText", $"Promoted to {rank.RankName}");
                        sqliteCommand.Parameters.AddWithValue("@GameTime", game.GameTime);
                        sqliteCommand.ExecuteNonQuery();

                        if (rank.RankID == promoteTo.RankID)
                            break;
                    }
                    else if (rank.RankID == this.RankID)
                        promote = true;
                }

                sqliteCommand.CommandText =
                    "UPDATE FCT_Commander " +
                    "SET RankID = @RankID, GameTimePromoted = @GameTimePromoted, " +
                    "Seniority = (SELECT MAX(Seniority) FROM FCT_Commander " +
                        "WHERE GameID = @GameID AND RaceID = @RaceID " +
                        "AND CommanderType = @CommanderType AND RankID = @RankID) + 1 " +
                    "WHERE CommanderID = @CommanderID";
                sqliteCommand.Parameters.AddWithValue("@RankID", promoteTo.RankID);
                sqliteCommand.Parameters.AddWithValue("@GameTimePromoted", game.GameTime);
                sqliteCommand.Parameters.AddWithValue("@GameID", game.GameID);
                sqliteCommand.Parameters.AddWithValue("@RaceID", promoteTo.RaceID);
                sqliteCommand.Parameters.AddWithValue("@CommanderType", promoteTo.RankType);
                sqliteCommand.Parameters.AddWithValue("@CommanderID", this.CommanderID);
                sqliteCommand.ExecuteNonQuery();
            }
        }
    }
}