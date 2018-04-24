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
            this.RandomButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.RulesBox = new System.Windows.Forms.ComboBox();
            this.deleteTeamBtn = new System.Windows.Forms.Button();
            this.listOfTeams = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Restart = new System.Windows.Forms.Button();
            this.GenerateTournament = new System.Windows.Forms.Button();
            this.TeamInput = new System.Windows.Forms.TextBox();
            this.AddTeam = new System.Windows.Forms.Button();
            this.TournamentBox = new System.Windows.Forms.GroupBox();
            this.switchThemeBtn = new System.Windows.Forms.Button();
            this.AdminTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminTools
            // 
            this.AdminTools.AccessibleDescription = "AdminTools";
            this.AdminTools.AccessibleName = "AdminTools";
            this.AdminTools.Controls.Add(this.switchThemeBtn);
            this.AdminTools.Controls.Add(this.RandomButton);
            this.AdminTools.Controls.Add(this.button1);
            this.AdminTools.Controls.Add(this.label4);
            this.AdminTools.Controls.Add(this.RulesBox);
            this.AdminTools.Controls.Add(this.deleteTeamBtn);
            this.AdminTools.Controls.Add(this.listOfTeams);
            this.AdminTools.Controls.Add(this.label3);
            this.AdminTools.Controls.Add(this.Restart);
            this.AdminTools.Controls.Add(this.GenerateTournament);
            this.AdminTools.Controls.Add(this.TeamInput);
            this.AdminTools.Controls.Add(this.AddTeam);
            this.AdminTools.Location = new System.Drawing.Point(12, 10);
            this.AdminTools.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdminTools.Name = "AdminTools";
            this.AdminTools.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdminTools.Size = new System.Drawing.Size(172, 799);
            this.AdminTools.TabIndex = 0;
            this.AdminTools.TabStop = false;
            this.AdminTools.Text = "Interface";
            // 
            // RandomButton
            // 
            this.RandomButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(137)))), ((int)(((byte)(68)))));
            this.RandomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandomButton.Location = new System.Drawing.Point(5, 306);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(158, 35);
            this.RandomButton.TabIndex = 15;
            this.RandomButton.Text = "Randomize Teams";
            this.RandomButton.UseVisualStyleBackColor = false;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(137)))), ((int)(((byte)(68)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(5, 481);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 38);
            this.button1.TabIndex = 14;
            this.button1.Text = "Force Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Rules";
            // 
            // RulesBox
            // 
            this.RulesBox.AccessibleDescription = "RulesBox";
            this.RulesBox.AccessibleName = "RulesBox";
            this.RulesBox.FormattingEnabled = true;
            this.RulesBox.Location = new System.Drawing.Point(5, 396);
            this.RulesBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RulesBox.Name = "RulesBox";
            this.RulesBox.Size = new System.Drawing.Size(158, 24);
            this.RulesBox.TabIndex = 12;
            this.RulesBox.SelectedIndexChanged += new System.EventHandler(this.RulesBox_SelectedIndexChanged);
            // 
            // deleteTeamBtn
            // 
            this.deleteTeamBtn.AccessibleDescription = "deleteTeamBtn";
            this.deleteTeamBtn.AccessibleName = "deleteTeamBtn";
            this.deleteTeamBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(137)))), ((int)(((byte)(68)))));
            this.deleteTeamBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTeamBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteTeamBtn.Location = new System.Drawing.Point(5, 267);
            this.deleteTeamBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteTeamBtn.Name = "deleteTeamBtn";
            this.deleteTeamBtn.Size = new System.Drawing.Size(158, 34);
            this.deleteTeamBtn.TabIndex = 11;
            this.deleteTeamBtn.Text = "Remove Selected";
            this.deleteTeamBtn.UseVisualStyleBackColor = false;
            this.deleteTeamBtn.Click += new System.EventHandler(this.deleteTeamBtn_Click);
            // 
            // listOfTeams
            // 
            this.listOfTeams.AccessibleDescription = "listOfTeams";
            this.listOfTeams.AccessibleName = "listOfTeams";
            this.listOfTeams.FormattingEnabled = true;
            this.listOfTeams.ItemHeight = 16;
            this.listOfTeams.Location = new System.Drawing.Point(5, 99);
            this.listOfTeams.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listOfTeams.Name = "listOfTeams";
            this.listOfTeams.Size = new System.Drawing.Size(159, 164);
            this.listOfTeams.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Team Name";
            // 
            // Restart
            // 
            this.Restart.AccessibleDescription = "Clear";
            this.Restart.AccessibleName = "Clear";
            this.Restart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(167)))), ((int)(((byte)(99)))));
            this.Restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Restart.Location = new System.Drawing.Point(5, 718);
            this.Restart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(158, 77);
            this.Restart.TabIndex = 8;
            this.Restart.Text = "Clear Tournament";
            this.Restart.UseVisualStyleBackColor = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // GenerateTournament
            // 
            this.GenerateTournament.AccessibleDescription = "GenerateTournament";
            this.GenerateTournament.AccessibleName = "GenerateTournament";
            this.GenerateTournament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(137)))), ((int)(((byte)(68)))));
            this.GenerateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateTournament.Location = new System.Drawing.Point(5, 424);
            this.GenerateTournament.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenerateTournament.Name = "GenerateTournament";
            this.GenerateTournament.Size = new System.Drawing.Size(158, 51);
            this.GenerateTournament.TabIndex = 2;
            this.GenerateTournament.Text = "CreateTournament";
            this.GenerateTournament.UseVisualStyleBackColor = false;
            this.GenerateTournament.Click += new System.EventHandler(this.GenerateTournament_Click);
            // 
            // TeamInput
            // 
            this.TeamInput.AccessibleDescription = "TeamInput";
            this.TeamInput.AccessibleName = "TeamInput";
            this.TeamInput.Location = new System.Drawing.Point(5, 38);
            this.TeamInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TeamInput.Name = "TeamInput";
            this.TeamInput.Size = new System.Drawing.Size(159, 22);
            this.TeamInput.TabIndex = 1;
            // 
            // AddTeam
            // 
            this.AddTeam.AccessibleDescription = "AddTeam";
            this.AddTeam.AccessibleName = "AddTeam";
            this.AddTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(137)))), ((int)(((byte)(68)))));
            this.AddTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeam.Location = new System.Drawing.Point(5, 63);
            this.AddTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddTeam.Name = "AddTeam";
            this.AddTeam.Size = new System.Drawing.Size(158, 30);
            this.AddTeam.TabIndex = 0;
            this.AddTeam.Text = "Add Team";
            this.AddTeam.UseVisualStyleBackColor = false;
            this.AddTeam.Click += new System.EventHandler(this.AddTeam_Click);
            // 
            // TournamentBox
            // 
            this.TournamentBox.AccessibleDescription = "TournamentBox";
            this.TournamentBox.AccessibleName = "TournamentBox";
            this.TournamentBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TournamentBox.Location = new System.Drawing.Point(188, 10);
            this.TournamentBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TournamentBox.Name = "TournamentBox";
            this.TournamentBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TournamentBox.Size = new System.Drawing.Size(1488, 799);
            this.TournamentBox.TabIndex = 2;
            this.TournamentBox.TabStop = false;
            this.TournamentBox.Text = "Tournamnet";
            // 
            // switchThemeBtn
            // 
            this.switchThemeBtn.Location = new System.Drawing.Point(0, 659);
            this.switchThemeBtn.Name = "switchThemeBtn";
            this.switchThemeBtn.Size = new System.Drawing.Size(163, 35);
            this.switchThemeBtn.TabIndex = 16;
            this.switchThemeBtn.Text = "Change Theme";
            this.switchThemeBtn.UseVisualStyleBackColor = true;
            this.switchThemeBtn.Click += new System.EventHandler(this.switchThemeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(172)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(1687, 819);
            this.Controls.Add(this.TournamentBox);
            this.Controls.Add(this.AdminTools);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Tournament";
            this.AdminTools.ResumeLayout(false);
            this.AdminTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AdminTools;
        private System.Windows.Forms.TextBox TeamInput;
        private System.Windows.Forms.Button AddTeam;
        private System.Windows.Forms.Button GenerateTournament;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.GroupBox TournamentBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listOfTeams;
        private System.Windows.Forms.Button deleteTeamBtn;
        private System.Windows.Forms.ComboBox RulesBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RandomButton;
        private System.Windows.Forms.Button switchThemeBtn;
    }
}

