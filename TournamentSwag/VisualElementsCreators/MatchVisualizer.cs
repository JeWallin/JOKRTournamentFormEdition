using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tournament.Team;
using Tournament.Nodes;
using System.Windows.Forms;
using System.Drawing;

namespace TournamentSwag.VisualElementsCreators
{
    
    public static class MatchVisualizer
    {
        private static Form1 Parent;

        public static void SetParent(Form1 parent)
        {
            Parent = parent;
        }
        public static Control CreateVisualElement(MatchNode toVisualize)
        {
            List<CompetitorData> competitors = toVisualize.GetBattleResult();
            List<FinalistData> notDone = toVisualize.GetNotConnectedFinialists();
            int height = 24;
            int padding = 1;
            int widht = 250;
            Panel matchBox = new Panel();
            matchBox.Size = new Size(widht, height*2+ padding);

            List<Panel> panels = new List<Panel>();
            foreach(CompetitorData cd in competitors)
            {
                Panel box = new Panel();
                box.Text = toVisualize.ToString();
                box.Size = new Size(widht, height);

                Label teamName = new Label();
                teamName.Text = cd.GetTeam().GetTeamName();
                teamName.Location = new Point(0, 0);
                teamName.Size = new Size(200, height);
                teamName.ForeColor = Color.LightGray;
                teamName.Font = new Font("Arial", 12, FontStyle.Bold);
               

                Button teamScore = new Button();
                teamScore.FlatStyle = FlatStyle.Flat;
                teamScore.ForeColor = Color.LightGray;
                teamScore.Text = "" + cd.GetScore();
                teamScore.Location = new Point(200, 0);
                teamScore.Size = new Size(32, height);
                teamScore.Font = teamName.Font;

                List<object> myShit = new List<object>();
                myShit.Add(toVisualize);
                myShit.Add(cd.GetTeam());
                teamScore.Click += new System.EventHandler(MatchVisualizer.ButtonGivePoints);
                teamScore.Tag = myShit;

                box.Controls.Add(teamName);
                box.Controls.Add(teamScore);

                panels.Add(box);
            }

            foreach (FinalistData fd in notDone)
            {
                Panel teamPanel = new Panel();
                teamPanel.Size = new Size(widht, height);
                
                Label teamName = new Label();
                teamName.Text = "[" + ToStringClass.ToString(fd.GetPosition()) + " of " + fd.GetNode().ToString() + "]";
                teamName.Location = new Point(0, 0);
                teamName.Size = new Size(widht, height);

                teamPanel.Controls.Add(teamName);

                panels.Add(teamPanel);
            }

            
            
            Point p = new Point(0, 0);
            for ( int i = 0; i < panels.Count; i++)
            {
                Control current = panels[i];
                if ( toVisualize.IsGameFinished() )
                {
                    var winner = toVisualize.GetCompeditor(MatchOutcome.OneVsOneWinner);
                    bool winnerIs = false;
                    foreach( Control c in current.Controls)
                    {
                        if (c.Text == winner.GetTeamName())
                        {
                            winnerIs = true;
                        }
                    }

                    if ( winnerIs )
                    {
                        current.BackColor = ColorTranslator.FromHtml("#658944");
                    }
                    else
                    {
 
                         current.BackColor = ColorTranslator.FromHtml("#c85252");

                        
                    }
                }
                else
                {
                    if ( (i & 1) == 1)
                    {
                        current.BackColor = ColorTranslator.FromHtml("#0a3936");

                    }
                    
                    else
                    {
                        current.BackColor = ColorTranslator.FromHtml("#196f61");
                    }
                }
                
                
                current.Location = p;
                matchBox.Controls.Add(current);
                p.Y += current.Size.Height + padding;
            }

            
                

            return matchBox;
        }




        private static void ButtonGivePoints(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            List<object> list = (List<object>)button.Tag;
            MatchNode mn = (MatchNode)list[0];
            ITeam team = (ITeam)list[1];
            mn.GiveTeamOnePoint(team);

            if ( Parent != null)
            {
                Parent.MegaUpdate();
            }

        }
    }
}
