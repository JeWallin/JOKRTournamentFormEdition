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

namespace TournamentSwag
{
    public partial class Form1 : Form
    {
        SingleElimination tournament;
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
        }

        private void AddTeam_Click(object sender, EventArgs e)
        {
            var teamInput = AdminTools.Controls.Find("TeamInput", true).FirstOrDefault();

            Competitor competitor = new Competitor(teamInput.Text);
            LeafNode leafNode = new LeafNode(competitor);

  
            tournament.AddLeafNode(leafNode);
            MegaUpdate();

            teamInput.Text = "";
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
                            renderBox.BackColor = ColorTranslator.FromHtml("#658944");
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
    }
}
