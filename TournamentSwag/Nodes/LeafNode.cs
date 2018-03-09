using System;
using System.Collections.Generic;
using Tournament.Team;

namespace Tournament.Nodes
{
    public class LeafNode : INode
    {
        ITeam LeafNodeTeam;

        public LeafNode()
        {
            LeafNodeTeam = DummyTeamCreator.DummyTeamInstance;
        }

        public LeafNode(ITeam team)
        {
            LeafNodeTeam = team;
        }

        public void AddFinalist(INode node, MatchOutcome pos)
        {
            
        }

        public List<INode> GetChilds()
        {
            List<INode> nodes = new List<INode>();
            return nodes;
        }

        public ITeam GetCompeditor(MatchOutcome position)
        {
            return LeafNodeTeam;
        }

        public int GetNodeDepth()
        {
            return 0;
        }

        public int GetNumberOfCompeditors()
        {
            return 1;
        }

        public List<ITeam> GetTeams()
        {
            List<ITeam> teams = new List<ITeam>();
            teams.Add(LeafNodeTeam);
            return teams;
        }

        public bool IsGameActive()
        {
            return false;
        }

        public bool IsGameFinished()
        {
            return true;
        }

        public void Update()
        {
            
        }
        public void SetName(string name)
        {

        }
    }
}
