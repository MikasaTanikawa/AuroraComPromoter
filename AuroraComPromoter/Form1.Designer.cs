
namespace AuroraComPromoter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.selectDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameNameComboBox = new System.Windows.Forms.ComboBox();
            this.gameNameLabel = new System.Windows.Forms.Label();
            this.racesGroupBox = new System.Windows.Forms.GroupBox();
            this.racesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.backupsNumberLabel = new System.Windows.Forms.Label();
            this.backupsNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.backupCheckBox = new System.Windows.Forms.CheckBox();
            this.promoteButton = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.navalRanksGroupBox = new System.Windows.Forms.GroupBox();
            this.navalRanksComboBox = new System.Windows.Forms.ComboBox();
            this.navalCheckBox = new System.Windows.Forms.CheckBox();
            this.groundRanksGroupBox = new System.Windows.Forms.GroupBox();
            this.groundRanksComboBox = new System.Windows.Forms.ComboBox();
            this.groundCheckBox = new System.Windows.Forms.CheckBox();
            this.logGroupBox = new System.Windows.Forms.GroupBox();
            this.systemMessagesOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.logListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.racesGroupBox.SuspendLayout();
            this.settingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backupsNumberNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.navalRanksGroupBox.SuspendLayout();
            this.groundRanksGroupBox.SuspendLayout();
            this.logGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectDBToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // selectDBToolStripMenuItem
            // 
            this.selectDBToolStripMenuItem.Name = "selectDBToolStripMenuItem";
            this.selectDBToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.selectDBToolStripMenuItem.Text = "Select DB";
            this.selectDBToolStripMenuItem.Click += new System.EventHandler(this.SelectDBToolStripMenuItem_Click);
            // 
            // gameNameComboBox
            // 
            this.gameNameComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gameNameComboBox.FormattingEnabled = true;
            this.gameNameComboBox.Location = new System.Drawing.Point(76, 3);
            this.gameNameComboBox.Name = "gameNameComboBox";
            this.gameNameComboBox.Size = new System.Drawing.Size(281, 21);
            this.gameNameComboBox.TabIndex = 0;
            this.gameNameComboBox.SelectedIndexChanged += new System.EventHandler(this.GameNameComboBox_SelectedIndexChanged);
            // 
            // gameNameLabel
            // 
            this.gameNameLabel.AutoSize = true;
            this.gameNameLabel.Location = new System.Drawing.Point(3, 6);
            this.gameNameLabel.Name = "gameNameLabel";
            this.gameNameLabel.Size = new System.Drawing.Size(67, 13);
            this.gameNameLabel.TabIndex = 1;
            this.gameNameLabel.Text = "Game name:";
            // 
            // racesGroupBox
            // 
            this.racesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.racesGroupBox.Controls.Add(this.racesCheckedListBox);
            this.racesGroupBox.Location = new System.Drawing.Point(3, 30);
            this.racesGroupBox.Name = "racesGroupBox";
            this.racesGroupBox.Size = new System.Drawing.Size(354, 140);
            this.racesGroupBox.TabIndex = 2;
            this.racesGroupBox.TabStop = false;
            this.racesGroupBox.Text = "Races";
            // 
            // racesCheckedListBox
            // 
            this.racesCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.racesCheckedListBox.CheckOnClick = true;
            this.racesCheckedListBox.FormattingEnabled = true;
            this.racesCheckedListBox.Location = new System.Drawing.Point(6, 19);
            this.racesCheckedListBox.Name = "racesCheckedListBox";
            this.racesCheckedListBox.Size = new System.Drawing.Size(342, 109);
            this.racesCheckedListBox.TabIndex = 0;
            this.racesCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.RacesCheckedListBox_ItemCheck);
            this.racesCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.RacesCheckedListBox_SelectedIndexChanged);
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsGroupBox.Controls.Add(this.splitContainer1);
            this.settingsGroupBox.Location = new System.Drawing.Point(12, 27);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(810, 218);
            this.settingsGroupBox.TabIndex = 1;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Promotion Settings";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.backupsNumberLabel);
            this.splitContainer1.Panel1.Controls.Add(this.backupsNumberNumericUpDown);
            this.splitContainer1.Panel1.Controls.Add(this.backupCheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.gameNameComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.racesGroupBox);
            this.splitContainer1.Panel1.Controls.Add(this.gameNameLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.promoteButton);
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(804, 199);
            this.splitContainer1.SplitterDistance = 360;
            this.splitContainer1.TabIndex = 3;
            // 
            // backupsNumberLabel
            // 
            this.backupsNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backupsNumberLabel.AutoSize = true;
            this.backupsNumberLabel.Location = new System.Drawing.Point(185, 180);
            this.backupsNumberLabel.Margin = new System.Windows.Forms.Padding(3, 0, 1, 0);
            this.backupsNumberLabel.Name = "backupsNumberLabel";
            this.backupsNumberLabel.Size = new System.Drawing.Size(124, 13);
            this.backupsNumberLabel.TabIndex = 4;
            this.backupsNumberLabel.Text = "Max number of backups:";
            // 
            // backupsNumberNumericUpDown
            // 
            this.backupsNumberNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backupsNumberNumericUpDown.Location = new System.Drawing.Point(313, 176);
            this.backupsNumberNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.backupsNumberNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.backupsNumberNumericUpDown.Name = "backupsNumberNumericUpDown";
            this.backupsNumberNumericUpDown.Size = new System.Drawing.Size(44, 20);
            this.backupsNumberNumericUpDown.TabIndex = 0;
            this.backupsNumberNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.backupsNumberNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // backupCheckBox
            // 
            this.backupCheckBox.AutoSize = true;
            this.backupCheckBox.Checked = true;
            this.backupCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.backupCheckBox.Location = new System.Drawing.Point(6, 179);
            this.backupCheckBox.Name = "backupCheckBox";
            this.backupCheckBox.Size = new System.Drawing.Size(81, 17);
            this.backupCheckBox.TabIndex = 3;
            this.backupCheckBox.Text = "Backup DB";
            this.backupCheckBox.UseVisualStyleBackColor = true;
            // 
            // promoteButton
            // 
            this.promoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.promoteButton.Enabled = false;
            this.promoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.promoteButton.Location = new System.Drawing.Point(3, 156);
            this.promoteButton.Name = "promoteButton";
            this.promoteButton.Size = new System.Drawing.Size(434, 40);
            this.promoteButton.TabIndex = 1;
            this.promoteButton.Text = "Promote Unassigned Commanders";
            this.promoteButton.UseVisualStyleBackColor = true;
            this.promoteButton.Click += new System.EventHandler(this.PromoteButton_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.navalRanksGroupBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groundRanksGroupBox);
            this.splitContainer2.Size = new System.Drawing.Size(440, 150);
            this.splitContainer2.SplitterDistance = 220;
            this.splitContainer2.TabIndex = 0;
            // 
            // navalRanksGroupBox
            // 
            this.navalRanksGroupBox.Controls.Add(this.navalRanksComboBox);
            this.navalRanksGroupBox.Controls.Add(this.navalCheckBox);
            this.navalRanksGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navalRanksGroupBox.Location = new System.Drawing.Point(0, 0);
            this.navalRanksGroupBox.Name = "navalRanksGroupBox";
            this.navalRanksGroupBox.Size = new System.Drawing.Size(220, 150);
            this.navalRanksGroupBox.TabIndex = 1;
            this.navalRanksGroupBox.TabStop = false;
            this.navalRanksGroupBox.Text = "Naval Commanders";
            // 
            // navalRanksComboBox
            // 
            this.navalRanksComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navalRanksComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.navalRanksComboBox.FormattingEnabled = true;
            this.navalRanksComboBox.Location = new System.Drawing.Point(6, 42);
            this.navalRanksComboBox.Name = "navalRanksComboBox";
            this.navalRanksComboBox.Size = new System.Drawing.Size(208, 21);
            this.navalRanksComboBox.TabIndex = 0;
            this.navalRanksComboBox.SelectedIndexChanged += new System.EventHandler(this.NavalRanksComboBox_SelectedIndexChanged);
            // 
            // navalCheckBox
            // 
            this.navalCheckBox.AutoSize = true;
            this.navalCheckBox.Location = new System.Drawing.Point(6, 19);
            this.navalCheckBox.Name = "navalCheckBox";
            this.navalCheckBox.Size = new System.Drawing.Size(123, 17);
            this.navalCheckBox.TabIndex = 0;
            this.navalCheckBox.Text = "Promote to this rank:";
            this.navalCheckBox.UseVisualStyleBackColor = true;
            this.navalCheckBox.CheckedChanged += new System.EventHandler(this.NavalCheckBox_CheckedChanged);
            // 
            // groundRanksGroupBox
            // 
            this.groundRanksGroupBox.Controls.Add(this.groundRanksComboBox);
            this.groundRanksGroupBox.Controls.Add(this.groundCheckBox);
            this.groundRanksGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groundRanksGroupBox.Location = new System.Drawing.Point(0, 0);
            this.groundRanksGroupBox.Name = "groundRanksGroupBox";
            this.groundRanksGroupBox.Size = new System.Drawing.Size(216, 150);
            this.groundRanksGroupBox.TabIndex = 2;
            this.groundRanksGroupBox.TabStop = false;
            this.groundRanksGroupBox.Text = "Ground Force Commanders";
            // 
            // groundRanksComboBox
            // 
            this.groundRanksComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groundRanksComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groundRanksComboBox.FormattingEnabled = true;
            this.groundRanksComboBox.Location = new System.Drawing.Point(6, 42);
            this.groundRanksComboBox.Name = "groundRanksComboBox";
            this.groundRanksComboBox.Size = new System.Drawing.Size(204, 21);
            this.groundRanksComboBox.TabIndex = 0;
            this.groundRanksComboBox.SelectedIndexChanged += new System.EventHandler(this.GroundRanksComboBox_SelectedIndexChanged);
            // 
            // groundCheckBox
            // 
            this.groundCheckBox.AutoSize = true;
            this.groundCheckBox.Location = new System.Drawing.Point(6, 19);
            this.groundCheckBox.Name = "groundCheckBox";
            this.groundCheckBox.Size = new System.Drawing.Size(123, 17);
            this.groundCheckBox.TabIndex = 0;
            this.groundCheckBox.Text = "Promote to this rank:";
            this.groundCheckBox.UseVisualStyleBackColor = true;
            this.groundCheckBox.CheckedChanged += new System.EventHandler(this.GroundCheckBox_CheckedChanged);
            // 
            // logGroupBox
            // 
            this.logGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logGroupBox.Controls.Add(this.systemMessagesOnlyCheckBox);
            this.logGroupBox.Controls.Add(this.logListBox);
            this.logGroupBox.Location = new System.Drawing.Point(12, 251);
            this.logGroupBox.Name = "logGroupBox";
            this.logGroupBox.Size = new System.Drawing.Size(810, 179);
            this.logGroupBox.TabIndex = 2;
            this.logGroupBox.TabStop = false;
            this.logGroupBox.Text = "Log";
            // 
            // systemMessagesOnlyCheckBox
            // 
            this.systemMessagesOnlyCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.systemMessagesOnlyCheckBox.AutoSize = true;
            this.systemMessagesOnlyCheckBox.Location = new System.Drawing.Point(644, 156);
            this.systemMessagesOnlyCheckBox.Name = "systemMessagesOnlyCheckBox";
            this.systemMessagesOnlyCheckBox.Size = new System.Drawing.Size(160, 17);
            this.systemMessagesOnlyCheckBox.TabIndex = 1;
            this.systemMessagesOnlyCheckBox.Text = "Show only system messages";
            this.systemMessagesOnlyCheckBox.UseVisualStyleBackColor = true;
            this.systemMessagesOnlyCheckBox.CheckedChanged += new System.EventHandler(this.SystemMessagesOnlyCheckBox_CheckedChanged);
            // 
            // logListBox
            // 
            this.logListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logListBox.FormattingEnabled = true;
            this.logListBox.Location = new System.Drawing.Point(6, 19);
            this.logListBox.Name = "logListBox";
            this.logListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.logListBox.Size = new System.Drawing.Size(798, 121);
            this.logListBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 442);
            this.Controls.Add(this.logGroupBox);
            this.Controls.Add(this.settingsGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Aurora Commanders Promoter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.racesGroupBox.ResumeLayout(false);
            this.settingsGroupBox.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backupsNumberNumericUpDown)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.navalRanksGroupBox.ResumeLayout(false);
            this.navalRanksGroupBox.PerformLayout();
            this.groundRanksGroupBox.ResumeLayout(false);
            this.groundRanksGroupBox.PerformLayout();
            this.logGroupBox.ResumeLayout(false);
            this.logGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectDBToolStripMenuItem;
        private System.Windows.Forms.ComboBox gameNameComboBox;
        private System.Windows.Forms.Label gameNameLabel;
        private System.Windows.Forms.GroupBox racesGroupBox;
        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox logGroupBox;
        private System.Windows.Forms.CheckBox systemMessagesOnlyCheckBox;
        private System.Windows.Forms.ListBox logListBox;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.CheckBox navalCheckBox;
        private System.Windows.Forms.CheckBox groundCheckBox;
        private System.Windows.Forms.GroupBox navalRanksGroupBox;
        private System.Windows.Forms.ComboBox navalRanksComboBox;
        private System.Windows.Forms.GroupBox groundRanksGroupBox;
        private System.Windows.Forms.ComboBox groundRanksComboBox;
        private System.Windows.Forms.CheckedListBox racesCheckedListBox;
        private System.Windows.Forms.NumericUpDown backupsNumberNumericUpDown;
        private System.Windows.Forms.CheckBox backupCheckBox;
        private System.Windows.Forms.Label backupsNumberLabel;
        private System.Windows.Forms.Button promoteButton;
    }
}

