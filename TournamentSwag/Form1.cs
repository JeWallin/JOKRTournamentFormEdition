using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tournament.Tournament;
using Tournament.Team;
using Tournament.Nodes;
using Tournament.Rule;
using TournamentSwag.VisualElementsCreators;
using TournamentSwag.ColorHelper;

namespace TournamentSwag
{
    public partial class Form1 : Form
    {
        SingleElimination tournament;
        ColorHandler colorFactory;
        ColorTheme colors;


        public Form1()
        {
            tournament = new SingleElimination();
            
            IRule bestof1 = new BestOf(1);
            IRule bestof3 = new BestOf(3);
            IRule BestOf5 = new BestOf(5);

            InitializeComponent();
            

            RulesBox.Items.Add(bestof1);
            RulesBox.Items.Add(bestof3);
            RulesBox.Items.Add(BestOf5);
            MatchVisualizer.SetParent(this);


            //Set current colors for application
            colorFactory = ColorHandler.Instance;
            colors = colorFactory.GetColorTheme();


        }

        private void UpdateTheme()
        {
            BackColor = colors.colorOne;
            AddTeam.BackColor = colors.colorTwo;
            deleteTeamBtn.BackColor = colors.colorTwo;
            RandomButton.BackColor = colors.colorTwo;
            GenerateTournament.BackColor = colors.colorTwo;
            button1.BackColor = colors.colorTwo;
            switchThemeBtn.BackColor = colors.colorTwo;

        }

        private void AddTeam_Click(object sender, EventArgs e)
        {
            var teamInput = AdminTools.Controls.Find("TeamInput", true).FirstOrDefault();

            if (ValidateTeamName(teamInput.Text))
            {

                Competitor competitor = new Competitor(teamInput.Text);
                LeafNode leafNode = new LeafNode(competitor);


                tournament.AddLeafNode(leafNode);
                MegaUpdate();
                teamInput.Text = "";
            }  else
            {
                MessageBox.Show("Invalid teamname. Teamname either blank, too long or already exists.", "Invalid teamname",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          
        }

        private bool ValidateTeamName( string name )
        {
            bool output = true;

            if (name == "" || name == null )
            {
                output = false;
            }
            if ( SameEntryTeamExits(name) )
            {
                output = false; 
            }
            if ( name.Length > 10 )
            {
                output = false; 
            }

            return output;
        }

        private bool SameEntryTeamExits( string teamName)
        {
            bool output = false;

            List<LeafNode> listofNodes = tournament.GetTournamentLeafNodes();

            foreach (LeafNode node in listofNodes)
            {
                if (node.GetCompeditor(0).GetTeamName() == teamName)
                {
                    output = true;
                    break;
                }
            }

            return output; 
        }

        private void UpDateTeamList()
        {
            var  leafNodes = tournament.GetTournamentLeafNodes();
            listOfTeams.Items.Clear();


            foreach(LeafNode lnd in leafNodes)
            {
                listOfTeams.Items.Add(lnd.GetCompeditor(0));
            }
        }

        private void GenerateTournament_Click(object sender, EventArgs e)
        {
            if ( RulesBox.SelectedIndex != -1)
            {
                tournament.SetRulesForGames((IRule)RulesBox.SelectedItem);
            }

            tournament.GenerateTournamentTree();
            List<EndNode> rootNodes = tournament.GetTournamentEndNodes();

            MegaUpdate();



        }

        private void Print( MatchNode node, Label PrintLabel)
        {
            if (node != null)
            {


                List<ITeam> fighters = node.GetTeams();
                var data = node.GetBattleResult();

                PrintLabel.Text += node.ToString() + "\n";

                foreach (var t in data)
                {
                    //PrintLabel.Text += t.GetTeamName() + " " ;
                    PrintLabel.Text += t.GetTeam().GetTeamName() + ": " + t.GetScore() + "\n";
                }

                foreach (var t in node.GetNotConnectedFinialists())
                {
                    PrintLabel.Text += "[";
                    PrintLabel.Text += ToStringClass.ToString(t.GetPosition()) + " of " + t.GetNode().ToString();
                    PrintLabel.Text += "]\n";
                }

                PrintLabel.Text += "\n";
            }
        }

        private void UpdateTournamentVisuals()
        {
            TournamentBox.Controls.Clear();
            Size maxSize = this.Size;

            Size newSize = new Size(maxSize.Width - TournamentBox.Location.X - 32, maxSize.Height - TournamentBox.Location.Y - 48);
            TournamentBox.Size = newSize;
            Size box = TournamentBox.Size;
            tournament.ForceUpdate();
            List<List<MatchNode>> rounds = tournament.GetRoundData();

            int numberofRounds = rounds.Count - 1;

            Size roundBox = new Size();
            roundBox.Height = box.Height;

            //fix division by 0
            numberofRounds = Math.Max(1, numberofRounds);
            roundBox.Width = box.Width / numberofRounds;

            for(int i = 0; i < numberofRounds; i++ )
            {

                GroupBox roundVis = new GroupBox();
                roundVis.Location = new Point(roundBox.Width * i, 16);
                roundVis.Size = roundBox;
                roundVis.Text = "Round: " + (i + 1);
                int hegithMove = 16;
                int widthMove = 3;
                Label label = new Label();
                if (rounds.Count > i + 1)
                {
                    Point p = new Point(16,32);
                    foreach (MatchNode match in rounds[i + 1])
                    {
                        Control c = MatchVisualizer.CreateVisualElement(match);
                        GroupBox renderBox = new GroupBox();
                        Size e = c.Size;
                        e.Width += widthMove*2;
                        renderBox.Size = e;
                        renderBox.Text = match.ToString();
                        if ( match.IsGameActive())
                        {
                            //renderBox.BackColor = ColorTranslator.FromHtml("#658944");
                            renderBox.BackColor = colors.colorTwo;
                        }
                        else
                        {
                            //renderBox.BackColor = Color.DimGray;
                        }
                        Size s = renderBox.Size;
                        s.Height += 4*hegithMove/3;
                        renderBox.Size = s;
                        c.Location = new Point(widthMove, hegithMove);
                        renderBox.Location = p;
                        renderBox.Controls.Add(c);
                        roundVis.Controls.Add(renderBox);
                        p.Y += renderBox.Size.Height + 12;
                    }
                    
                    TournamentBox.Controls.Add(roundVis);
                }

            }
            
        }


        private void Restart_Click(object sender, EventArgs e)
        {
            tournament = new SingleElimination();
            MegaUpdate();
        }

        private void deleteTeamBtn_Click(object sender, EventArgs e)
        {
            if (listOfTeams.SelectedIndex != -1)
            {

                var toRemove = (ITeam)listOfTeams.SelectedItem;

                tournament.DeleteTeam(toRemove);

                MegaUpdate();
                listOfTeams.SelectedIndex = -1; 
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MegaUpdate();
        }


        public void MegaUpdate()
        {
            UpDateTeamList();
            UpdateTournamentVisuals();
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {

            tournament.ShuffleTeams();
            tournament.GenerateTournamentTree();
            MegaUpdate();


        }

        private void RulesBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void switchThemeBtn_Click(object sender, EventArgs e)
        {
            int theme;
            ColorHandler.ColorType currentTheme = colorFactory.GetCurrentThemeType();
            Random rnd = new Random();


            while (true)
            {
                theme = rnd.Next(0, 4);
                if (currentTheme != (ColorHandler.ColorType)theme)
                {
                    break;
                }
            }
            

            colorFactory.SetColorScheme((ColorHandler.ColorType)theme);

            MegaUpdate();
            UpdateTheme();
        }
    }
}
