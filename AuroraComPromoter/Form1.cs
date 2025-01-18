using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace AuroraComPromoter
{
    public partial class Form1 : Form
    {
        readonly List<LogMessage> logMessages;
        string dbFilename;
        SQLiteConnection dbConnection;
        List<Game> games;
        List<Race> races;
        List<Rank> ranks;

        public Form1()
        {
            InitializeComponent();
            logMessages = new List<LogMessage>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenDB($"{Environment.CurrentDirectory}{Path.DirectorySeparatorChar}AuroraDB.db");
        }

        private void SelectDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                InitialDirectory = Environment.CurrentDirectory,
                Filter = "DB files (*.db)|*.db|All files (*.*)|*.*"
            };

            ofd.ShowDialog();

            if (ofd.FileName != null && ofd.FileName != String.Empty)
                OpenDB(ofd.FileName);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseDB();
        }

        private void OpenDB(string fileName)
        {
            CloseDB();

            dbFilename = null;
            promoteButton.Enabled = false;
            ClearLog();
            gameNameComboBox.Items.Clear();
            Log($"Opening DB file: {fileName}", true);

            if (!File.Exists(fileName))
            {
                Log("Can't find DB file!", true);
                Log("Select DB file manually.", true);
            }
            else
            {
                dbConnection = new SQLiteConnection($"Data Source = {fileName}; Version = 3; New = False; Compress = True; ");
                dbConnection.Open();

                games = Game.Read(dbConnection);
                foreach (var game in games)
                {
                    gameNameComboBox.Items.Add(game.GameName);

#if DEBUG
                    Log(game.ToString(), true);
#endif

                    if (game.LastViewed != 0)
                        gameNameComboBox.SelectedIndex = gameNameComboBox.Items.Count - 1;
                }

                dbFilename = fileName;
            }
        }

        private void CloseDB()
        {
            if (dbConnection != null && dbConnection.State != ConnectionState.Closed)
                dbConnection.Close();
        }

        private void GameNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            racesCheckedListBox.Items.Clear();
            races = Race.Read(dbConnection, games[gameNameComboBox.SelectedIndex].GameID);
            foreach (var race in races)
            {
                racesCheckedListBox.Items.Add(race.RaceName);

#if DEBUG
                Log(race.ToString(), true);
#endif
            }

            ranks = Rank.Read(dbConnection, games[gameNameComboBox.SelectedIndex].GameID, races);

#if DEBUG
            foreach (var rank in ranks)
            {
                Log(rank.ToString(), true);
            }
#endif

            racesCheckedListBox.SetItemChecked(racesCheckedListBox.Items.Count - 1, true);
            racesCheckedListBox.SelectedIndex = racesCheckedListBox.Items.Count - 1;
        }

        private void RacesCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            navalRanksComboBox.Items.Clear();
            groundRanksComboBox.Items.Clear();

            foreach (var rank in ranks)
            {
                if (rank.RaceID == races[racesCheckedListBox.SelectedIndex].RaceID)
                {
                    if (rank.RankType == 0)
                    {
                        navalRanksComboBox.Items.Add(rank.RankName);
                        if (rank == races[racesCheckedListBox.SelectedIndex].SelectedNavalRank)
                            navalRanksComboBox.SelectedIndex = navalRanksComboBox.Items.Count - 1;
                    }
                    if (rank.RankType == 1)
                    {
                        groundRanksComboBox.Items.Add(rank.RankName);
                        if (rank == races[racesCheckedListBox.SelectedIndex].SelectedGroundRank)
                            groundRanksComboBox.SelectedIndex = groundRanksComboBox.Items.Count - 1;
                    }
                }
            }

            navalCheckBox.Checked = races[racesCheckedListBox.SelectedIndex].SelectedNavalRank != null;
            groundCheckBox.Checked = races[racesCheckedListBox.SelectedIndex].SelectedGroundRank != null;
        }

        private void RacesCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (racesCheckedListBox.CheckedIndices.Count == 1 && e.NewValue == CheckState.Unchecked)
                promoteButton.Enabled = false;

            if (racesCheckedListBox.CheckedIndices.Count <= 0 && e.NewValue == CheckState.Checked &&
                (races[e.Index].SelectedNavalRank != null || races[e.Index].SelectedGroundRank != null))
            {
                promoteButton.Enabled = true;
            }
        }

        private void NavalCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!navalCheckBox.Checked)
                races[racesCheckedListBox.SelectedIndex].SelectedNavalRank = null;
            else
                SetSelectedRanks();
            navalRanksComboBox.Enabled = navalCheckBox.Checked;
            SetPromoteButtonState();
        }

        private void GroundCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!groundCheckBox.Checked)
                races[racesCheckedListBox.SelectedIndex].SelectedGroundRank = null;
            else
                SetSelectedRanks();
            groundRanksComboBox.Enabled = groundCheckBox.Checked;
            SetPromoteButtonState();
        }

        private void SetPromoteButtonState()
        {
            promoteButton.Enabled = false;
            if (racesCheckedListBox.CheckedIndices.Count > 0)
            {
                foreach (int i in racesCheckedListBox.CheckedIndices)
                {
                    if (races[i].SelectedNavalRank != null || races[i].SelectedGroundRank != null)
                        promoteButton.Enabled = true;
                }
            }
        }

        private void SetSelectedRanks()
        {
            int i = 0;
            int j = 0;
            foreach (var rank in ranks)
            {
                if (rank.RaceID == races[racesCheckedListBox.SelectedIndex].RaceID)
                {
                    if (navalCheckBox.Checked && rank.RankType == 0)
                    {
                        if (navalRanksComboBox.SelectedIndex == i)
                        {
                            races[racesCheckedListBox.SelectedIndex].SelectedNavalRank = rank;
                        }
                        i++;
                    }
                    else if (groundCheckBox.Checked && rank.RankType == 1)
                    {
                        if (groundRanksComboBox.SelectedIndex == j)
                        {
                            races[racesCheckedListBox.SelectedIndex].SelectedGroundRank = rank;
                        }
                        j++;
                    }
                }
            }
            SetPromoteButtonState();
        }

        private void NavalRanksComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSelectedRanks();
        }

        private void GroundRanksComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSelectedRanks();
        }

        private void PromoteButton_Click(object sender, EventArgs e)
        {
            settingsGroupBox.Enabled = false;
            selectDBToolStripMenuItem.Enabled = false;

            if (backupCheckBox.Checked)
                BackupDB();

            List<Commander> commanders;
            var game = games[gameNameComboBox.SelectedIndex];

            using (var sqlTransaction = dbConnection.BeginTransaction())
            {
                foreach (int i in racesCheckedListBox.CheckedIndices)
                {
                    var race = races[i];

                    if (race.SelectedNavalRank != null)
                    {
                        commanders = Commander.Read(dbConnection, game.GameID,
                            race, 0, ranks);
                        Log($@"Promoting {commanders.Count} unassigned naval commanders of {
                            race.RaceName} race to {race.SelectedNavalRank.RankName} rank.");

                        var reversedRanks = ranks.Where(rank => rank.RaceID == race.RaceID && rank.RankType == 0).Reverse();

                        foreach (var commander in commanders)
                        {
                            commander.Promote(dbConnection, game, race.SelectedNavalRank, reversedRanks);
                            Log($"{commander.Name} promoted to {race.SelectedNavalRank.RankName}");
                        }
                    }
                    if (race.SelectedGroundRank != null)
                    {
                        commanders = Commander.Read(dbConnection, game.GameID,
                            race, 1, ranks);
                        Log($@"Promoting {commanders.Count} unassigned ground force commanders of {
                            race.RaceName} race to {race.SelectedGroundRank.RankName} rank.");

                        var reversedRanks = ranks.Where(rank => rank.RaceID == race.RaceID && rank.RankType == 1).Reverse();

                        foreach (var commander in commanders)
                        {
                            commander.Promote(dbConnection, game, race.SelectedGroundRank, reversedRanks);
                            Log($"{commander.Name} promoted to {race.SelectedGroundRank.RankName}");
                        }
                    }
                }
                sqlTransaction.Commit();
            }

            settingsGroupBox.Enabled = true;
            selectDBToolStripMenuItem.Enabled = true;
        }

        private void BackupDB()
        {
            string bkpFilename;

            Log("Creating DB backup.", true);
            for (var i = backupsNumberNumericUpDown.Maximum; i >= backupsNumberNumericUpDown.Minimum; i--)
            {
                bkpFilename = $"{dbFilename}.{i}.bkp";

                if (i >= backupsNumberNumericUpDown.Value && File.Exists(bkpFilename))
                {
                    Log($"Removing old backup file: {bkpFilename}", true);
                    File.Delete(bkpFilename);
                }
                if (i < backupsNumberNumericUpDown.Value && File.Exists(bkpFilename))
                {
#if DEBUG
                    Log($"Renaming backup file: {bkpFilename}", true);
#endif
                    File.Move(bkpFilename, $"{dbFilename}.{i + 1}.bkp");
                }
            }

            bkpFilename = $"{dbFilename}.{backupsNumberNumericUpDown.Minimum}.bkp";
            File.Copy(dbFilename, bkpFilename);
            Log($"DB backup created: {bkpFilename}", true);
        }

        private void SystemMessagesOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            logListBox.Items.Clear();

            foreach (var msg in logMessages)
            {
                ShowLogMessage(msg);
            }
        }

        private void ClearLog()
        {
            logMessages.Clear();
            logListBox.Items.Clear();
        }

        private void Log(string message, bool isSystem = false)
        {
            var msg = new LogMessage(message, isSystem);

            logMessages.Add(msg);
            ShowLogMessage(msg);
        }

        private void ShowLogMessage(LogMessage msg)
        {
            if (systemMessagesOnlyCheckBox.Checked && !msg.IsSystem)
                return;

            logListBox.Items.Add(msg.IsSystem ? "* " + msg.Message : msg.Message);
            logListBox.SelectedIndex = logListBox.Items.Count - 1;
            logListBox.SelectedIndex = -1;
        }

        internal struct LogMessage
        {
            private string message;
            private bool isSystem;

            public LogMessage(string message, bool isSystem = false) : this()
            {
                Message = message;
                IsSystem = isSystem;
            }

            public string Message { get => message; set => message = value; }
            public bool IsSystem { get => isSystem; set => isSystem = value; }
        }
    }
}
