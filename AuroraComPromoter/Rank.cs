using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace AuroraComPromoter
{
    internal class Rank
    {
        public Rank(int rankID, int raceID, string rankName, int priority, int rankType)
        {
            RankID = rankID;
            RaceID = raceID;
            RankName = rankName;
            Priority = priority;
            RankType = rankType;
        }

        public int RankID { get; }
        public int RaceID { get; }
        public string RankName { get; }
        public int Priority { get; }
        public int RankType { get; }

        public override string ToString()
        {
            return $"RankID: {RankID}; RaceID: {RaceID}; RankName: {RankName}; Priority: {Priority}; RankType: {RankType}";
        }

        internal static List<Rank> Read(SQLiteConnection dbConnection, int gameID, List<Race> races)
        {
            var ranks = new List<Rank>();

            foreach (var race in races)
            {
                var dataAdapter = new SQLiteDataAdapter(
                    $@"select * from FCT_Ranks 
                    where GameID = {gameID} and RaceID = {race.RaceID} 
                    order by Priority asc", dbConnection);
                dataAdapter.SelectCommand.CommandTimeout = 360;
                var data = new DataTable();
                dataAdapter.Fill(data);

                foreach (DataRow row in data.Rows)
                {
                    var rank = new Rank(Convert.ToInt32(row["RankID"]), Convert.ToInt32(row["RaceID"]), row["RankName"].ToString(),
                        Convert.ToInt32(row["Priority"]), Convert.ToInt32(row["RankType"]));

                    ranks.Add(rank);

                    // remember second in priority ranks for this race
                    if (rank.Priority == 2)
                    {
                        if (rank.RankType == 0)
                            race.SelectedNavalRank = rank;

                        if (rank.RankType == 1)
                            race.SelectedGroundRank = rank;
                    }
                }
            }

            return ranks;
        }
    }
}