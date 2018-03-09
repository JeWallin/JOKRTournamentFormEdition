namespace TournamentSwag
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
            this.AdminTools = new System.Windows.Forms.GroupBox();
            this.listOfTeams = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Restart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GivePoints = new System.Windows.Forms.Button();
            this.TeamsInGame = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GameSelector = new System.Windows.Forms.ComboBox();
            this.GenerateTournament = new System.Windows.Forms.Button();
            this.TeamInput = new System.Windows.Forms.TextBox();
            this.AddTeam = new System.Windows.Forms.Button();
            this.TournamentBox = new System.Windows.Forms.GroupBox();
            this.deleteTeamBtn = new System.Windows.Forms.Button();
            this.RulesBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.AdminTools.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminTools
            // 
            this.AdminTools.AccessibleDescription = "AdminTools";
            this.AdminTools.AccessibleName = "AdminTools";
            this.AdminTools.Controls.Add(this.button1);
            this.AdminTools.Controls.Add(this.label4);
            this.AdminTools.Controls.Add(this.RulesBox);
            this.AdminTools.Controls.Add(this.deleteTeamBtn);
            this.AdminTools.Controls.Add(this.listOfTeams);
            this.AdminTools.Controls.Add(this.label3);
            this.AdminTools.Controls.Add(this.Restart);
            this.AdminTools.Controls.Add(this.groupBox1);
            this.AdminTools.Controls.Add(this.GenerateTournament);
            this.AdminTools.Controls.Add(this.TeamInput);
            this.AdminTools.Controls.Add(this.AddTeam);
            this.AdminTools.Location = new System.Drawing.Point(13, 13);
            this.AdminTools.Name = "AdminTools";
            this.AdminTools.Size = new System.Drawing.Size(193, 999);
            this.AdminTools.TabIndex = 0;
            this.AdminTools.TabStop = false;
            this.AdminTools.Text = "Interface";
            // 
            // listOfTeams
            // 
            this.listOfTeams.AccessibleDescription = "listOfTeams";
            this.listOfTeams.AccessibleName = "listOfTeams";
            this.listOfTeams.FormattingEnabled = true;
            this.listOfTeams.ItemHeight = 20;
            this.listOfTeams.Location = new System.Drawing.Point(6, 124);
            this.listOfTeams.Name = "listOfTeams";
            this.listOfTeams.Size = new System.Drawing.Size(178, 204);
            this.listOfTeams.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Team Name";
            // 
            // Restart
            // 
            this.Restart.AccessibleDescription = "Clear";
            this.Restart.AccessibleName = "Clear";
            this.Restart.Location = new System.Drawing.Point(6, 947);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(178, 46);
            this.Restart.TabIndex = 8;
            this.Restart.Text = "Clear Tournament";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GivePoints);
            this.groupBox1.Controls.Add(this.TeamsInGame);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.GameSelector);
            this.groupBox1.Location = new System.Drawing.Point(6, 589);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 226);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UpdateGames";
            // 
            // GivePoints
            // 
            this.GivePoints.AccessibleDescription = "GivePoints";
            this.GivePoints.AccessibleName = "GivePoints";
            this.GivePoints.Location = new System.Drawing.Point(5, 179);
            this.GivePoints.Name = "GivePoints";
            this.GivePoints.Size = new System.Drawing.Size(167, 41);
            this.GivePoints.TabIndex = 10;
            this.GivePoints.Text = "Give Points";
            this.GivePoints.UseVisualStyleBackColor = true;
            this.GivePoints.Click += new System.EventHandler(this.GivePoints_Click);
            // 
            // TeamsInGame
            // 
            this.TeamsInGame.AccessibleDescription = "TeamsInGame";
            this.TeamsInGame.AccessibleName = "TeamsInGame";
            this.TeamsInGame.FormattingEnabled = true;
            this.TeamsInGame.Location = new System.Drawing.Point(4, 116);
            this.TeamsInGame.Name = "TeamsInGame";
            this.TeamsInGame.Size = new System.Drawing.Size(168, 28);
            this.TeamsInGame.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Team";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Game";
            // 
            // GameSelector
            // 
            this.GameSelector.AccessibleDescription = "GameSelector";
            this.GameSelector.AccessibleName = "GameSelector";
            this.GameSelector.FormattingEnabled = true;
            this.GameSelector.Location = new System.Drawing.Point(6, 45);
            this.GameSelector.Name = "GameSelector";
            this.GameSelector.Size = new System.Drawing.Size(166, 28);
            this.GameSelector.TabIndex = 6;
            this.GameSelector.SelectedIndexChanged += new System.EventHandler(this.GameSelector_SelectedIndexChanged);
            // 
            // GenerateTournament
            // 
            this.GenerateTournament.AccessibleDescription = "GenerateTournament";
            this.GenerateTournament.AccessibleName = "GenerateTournament";
            this.GenerateTournament.Location = new System.Drawing.Point(6, 436);
            this.GenerateTournament.Name = "GenerateTournament";
            this.GenerateTournament.Size = new System.Drawing.Size(178, 64);
            this.GenerateTournament.TabIndex = 2;
            this.GenerateTournament.Text = "CreateTournament";
            this.GenerateTournament.UseVisualStyleBackColor = true;
            this.GenerateTournament.Click += new System.EventHandler(this.GenerateTournament_Click);
            // 
            // TeamInput
            // 
            this.TeamInput.AccessibleDescription = "TeamInput";
            this.TeamInput.AccessibleName = "TeamInput";
            this.TeamInput.Location = new System.Drawing.Point(6, 47);
            this.TeamInput.Name = "TeamInput";
            this.TeamInput.Size = new System.Drawing.Size(178, 26);
            this.TeamInput.TabIndex = 1;
            // 
            // AddTeam
            // 
            this.AddTeam.AccessibleDescription = "AddTeam";
            this.AddTeam.AccessibleName = "AddTeam";
            this.AddTeam.Location = new System.Drawing.Point(6, 79);
            this.AddTeam.Name = "AddTeam";
            this.AddTeam.Size = new System.Drawing.Size(178, 38);
            this.AddTeam.TabIndex = 0;
            this.AddTeam.Text = "Add Team";
            this.AddTeam.UseVisualStyleBackColor = true;
            this.AddTeam.Click += new System.EventHandler(this.AddTeam_Click);
            // 
            // TournamentBox
            // 
            this.TournamentBox.AccessibleDescription = "TournamentBox";
            this.TournamentBox.AccessibleName = "TournamentBox";
            this.TournamentBox.Location = new System.Drawing.Point(212, 13);
            this.TournamentBox.Name = "TournamentBox";
            this.TournamentBox.Size = new System.Drawing.Size(1674, 999);
            this.TournamentBox.TabIndex = 2;
            this.TournamentBox.TabStop = false;
            this.TournamentBox.Text = "Tournamnet";
            // 
            // deleteTeamBtn
            // 
            this.deleteTeamBtn.AccessibleDescription = "deleteTeamBtn";
            this.deleteTeamBtn.AccessibleName = "deleteTeamBtn";
            this.deleteTeamBtn.Location = new System.Drawing.Point(6, 334);
            this.deleteTeamBtn.Name = "deleteTeamBtn";
            this.deleteTeamBtn.Size = new System.Drawing.Size(178, 42);
            this.deleteTeamBtn.TabIndex = 11;
            this.deleteTeamBtn.Text = "Remove Selected";
            this.deleteTeamBtn.UseVisualStyleBackColor = true;
            this.deleteTeamBtn.Click += new System.EventHandler(this.deleteTeamBtn_Click);
            // 
            // RulesBox
            // 
            this.RulesBox.AccessibleDescription = "RulesBox";
            this.RulesBox.AccessibleName = "RulesBox";
            this.RulesBox.FormattingEnabled = true;
            this.RulesBox.Location = new System.Drawing.Point(6, 402);
            this.RulesBox.Name = "RulesBox";
            this.RulesBox.Size = new System.Drawing.Size(172, 28);
            this.RulesBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Rules";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 48);
            this.button1.TabIndex = 14;
            this.button1.Text = "Force Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.TournamentBox);
            this.Controls.Add(this.AdminTools);
            this.Name = "Form1";
            this.Text = "Form1";
            this.AdminTools.ResumeLayout(false);
            this.AdminTools.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AdminTools;
        private System.Windows.Forms.TextBox TeamInput;
        private System.Windows.Forms.Button AddTeam;
        private System.Windows.Forms.Button GenerateTournament;
        private System.Windows.Forms.ComboBox GameSelector;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TeamsInGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GivePoints;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.GroupBox TournamentBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listOfTeams;
        private System.Windows.Forms.Button deleteTeamBtn;
        private System.Windows.Forms.ComboBox RulesBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

