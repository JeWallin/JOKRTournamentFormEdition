﻿using System;
using System.Collections.Generic;
using Tournament.Rule;
using Tournament.Team;

namespace Tournament.Nodes
{

    public class MatchNode : INode
    {
        List<CompetitorData> MatchNodeBattleResult;
        List<FinalistData> MatchNodeFinalists;
        List<FinalistData> MatchNodeConnectedFinalists;
        IRule MatchNodeRule;
        String MatchName;
        public MatchNode()
        {
            MatchNodeBattleResult = new List<CompetitorData>();
            MatchNodeFinalists = new List<FinalistData>();
            MatchNodeConnectedFinalists = new List<FinalistData>();
            MatchNodeRule = DummyRuleCreator.DummyRuleInstance; 
        }
        public MatchNode(IRule rule)
        {
            MatchNodeBattleResult = new List<CompetitorData>();
            MatchNodeFinalists = new List<FinalistData>();
            MatchNodeConnectedFinalists = new List<FinalistData>();
            SetRule(rule);
        }

        public int NumberOfFinalists()
        {
            return MatchNodeFinalists.Count;
        }



        public void GiveTeamOnePoint(ITeam team)
        {
            if (MatchNodeRule.CanGameRun(this))
            {

                foreach (var battleData in MatchNodeBattleResult)
                {
                    if (battleData.GetTeam().Equals(team))
                    {
                        battleData.IncrementScore();
                        break;
                    }
                }
            }
        }

        public List<CompetitorData> GetBattleResult()
        {
            return MatchNodeBattleResult;

        }

        public void SetRule(IRule rule)
        {
            MatchNodeRule = rule;
        }

        public ITeam GetCompeditor(MatchOutcome position)
        {
            return MatchNodeRule.GetCompetitorPosition(this, (int)position);
        }

        public List<ITeam> GetCompeditors()
        {
            //TODO AUTMAP
            List<ITeam> teams = new List<ITeam>();
            foreach (var battleData in MatchNodeBattleResult)
            {
                teams.Add(battleData.GetTeam()); 
            }

            return teams;
        }



        public int GetNumberOfCompeditors()
        {
            return MatchNodeBattleResult.Count;
        }

        public bool IsGameFinished()
        {
            return MatchNodeRule.IsGameOver(this);
        }

        public void Update()
        {
            MakeFinalistsToCompetitors();
        }

        public void AddFinalist(FinalistData finalist)
        {
            MatchNodeFinalists.Add(finalist);
        }

        public void AddFinalist(INode node, MatchOutcome pos)
        {
            MatchNodeFinalists.Add(new FinalistData(node, pos)); 
        }

        public List<FinalistData> GetFinalists()
        {
            return MatchNodeFinalists;
        }

        public void RemoveFinalist(FinalistData finalist)
        {
            MatchNodeFinalists.Remove(finalist);
        }

        private bool IsTeamACompetitor(ITeam team)
        {
            bool output = false;
            foreach (var competitor in MatchNodeBattleResult)
            {

                if ( competitor.GetTeam().Equals(team) )
                {
                    output = true;
                    break;
                }
             
            }


            return output;
        }


        private void MakeFinalistsToCompetitors()
        {
            for (int i = 0; i < MatchNodeFinalists.Count; i++)
            {
                if( MatchNodeRule.IsGameFull(this))
                {
                    break;
                }


                FinalistData finalist = MatchNodeFinalists[i];

                ITeam compeditor = finalist.GetCompeditor();


                if (!compeditor.Equals(DummyTeamCreator.DummyTeamInstance))
                {
                    if (!IsTeamACompetitor(compeditor))
                    {
                        CompetitorData toAdd = new CompetitorData(compeditor);
                        MatchNodeBattleResult.Add(toAdd);
                        MatchNodeConnectedFinalists.Add(finalist);
                    }
                }
            }
        }

        public bool IsGameActive()
        {
            return MatchNodeRule.CanGameRun(this);
        }


        public int GetNodeDepth()
        {
            int depth = 0;
            if (MatchNodeFinalists.Count > 0)
            {
                foreach (FinalistData finalist in MatchNodeFinalists)
                {
                    INode node = finalist.GetNode(); 
                    depth = Math.Max(node.GetNodeDepth() + 1, depth);
                }

            }
            return depth;
        }

        public List<ITeam> GetTeams()
        {
            return GetCompeditors();
        }

        public List<INode> GetChilds()
        {
            List<INode> nodes = new List<INode>();

            foreach( var finalist in MatchNodeFinalists)
            {
                nodes.Add(finalist.GetNode());
            }
            return nodes;
        }

        public override string ToString()
        {

            return MatchName;
        }

        public void SetName(string name)
        {
            MatchName = name;
        }

        public List<FinalistData> GetNotConnectedFinialists()
        {
            List<FinalistData> toConnect = new List<FinalistData>();
            toConnect.AddRange(MatchNodeFinalists);

            foreach( FinalistData finalist in MatchNodeConnectedFinalists)
            {
                if ( toConnect.Contains(finalist))
                {
                    toConnect.Remove(finalist);
                }
            }

            return toConnect;
        }
    }
}
