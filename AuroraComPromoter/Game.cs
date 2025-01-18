using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace AuroraComPromoter
{
    internal class Game
    {
        public Game(int gameID, string gameName, decimal gameTime, int lastViewed)
        {
            GameID = gameID;
            GameName = gameName;
            GameTime = gameTime;
            LastViewed = lastViewed;
        }

        public int GameID { get; }
        public string GameName { get; }
        public decimal GameTime { get; }
        public int LastViewed { get; }

        public override string ToString()
        {
            return $"GameID: {GameID}; GameName: {GameName}; GameTime: {GameTime}; LastViewed: {LastViewed}";
        }

        internal static List<Game> Read(SQLiteConnection dbConnection)
        {
            var games = new List<Game>();

            var dataAdapter = new SQLiteDataAdapter("select * from FCT_Game", dbConnection);
            dataAdapter.SelectCommand.CommandTimeout = 360;
            var data = new DataTable();
            dataAdapter.Fill(data);

            foreach (DataRow row in data.Rows)
                games.Add(new Game(Convert.ToInt32(row["GameID"]), row["GameName"].ToString(),
                    Convert.ToDecimal(row["GameTime"]), Convert.ToInt32(row["LastViewed"])));

            return games;
        }
    }
}