using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace AuroraComPromoter
{
    internal class Race
    {
        public Race(int raceID, string raceName)
        {
            RaceID = raceID;
            RaceName = raceName;
        }

        public int RaceID { get; }
        public string RaceName { get; }
        public Rank SelectedNavalRank { get; set; }
        public Rank SelectedGroundRank { get; set; }

        public override string ToString()
        {
            return $"RaceID: {RaceID}; RaceName: {RaceName}";
        }

        internal static List<Race> Read(SQLiteConnection dbConnection, int gameID)
        {
            var races = new List<Race>();

            var dataAdapter = new SQLiteDataAdapter($"select * from FCT_Race where GameID = {gameID} and NPR = 0", dbConnection);
            dataAdapter.SelectCommand.CommandTimeout = 360;
            var data = new DataTable();
            dataAdapter.Fill(data);

            foreach (DataRow row in data.Rows)
                races.Add(new Race(Convert.ToInt32(row["RaceID"]), row["RaceName"].ToString()));

            return races;
        }
    }
}