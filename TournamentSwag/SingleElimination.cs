using System;
using System.Collections.Generic;
using Tournament.Nodes;
using Tournament.Rule;
using Tournament.Team;

namespace Tournament.Tournament
{
    
    public class SingleElimination : ITournament
    {
        List<LeafNode> SingleEliminationTeamEntryPoints;
        MatchNode SingleEliminationFinal;
        MatchNode SingleEliminationThirdPlaceFinal;
        List<MatchNode> SingleEliminationGames;
        List<EndNode> SingleEliminationPlacements;
        IRule SingleEliminationGameRule;

        public SingleElimination()
        {

            SingleEliminationGameRule = new BestOf(3);
            SingleEliminationTeamEntryPoints = new List<LeafNode>();
            SingleEliminationFinal = GenerateMatchNode();
            SingleEliminationPlacements = new List<EndNode>();
            SingleEliminationGames = new List<MatchNode>();

        }
        public void AddLeafNode(LeafNode node)
        {
            SingleEliminationTeamEntryPoints.Add(node);
        }
        public void SetRulesForGames(IRule rule)
        {
            SingleEliminationGameRule = rule;
        }
        public void GenerateTournamentTree()
        {
            SingleEliminationGames = new List<MatchNode>();

            SingleEliminationFinal = GenerateMatchNode();
            
            ConnectLeafNodesToMatch(SingleEliminationFinal);

            while (DoMerge()) { }

            if (SingleEliminationTeamEntryPoints.Count >= 2)
            {
                EndNode firstPlace = new EndNode();
                EndNode SecondPlace = new EndNode();


                firstPlace.AddFinalist(SingleEliminationFinal, MatchOutcome.OneVsOneWinner);
                SecondPlace.AddFinalist(SingleEliminationFinal, MatchOutcome.OneVsOneLooser);
                SingleEliminationPlacements.Add(firstPlace);
                SingleEliminationPlacements.Add(SecondPlace);
            }
            if (SingleEliminationTeamEntryPoints.Count >= 4)
            {
                EndNode ThirdPlace = new EndNode();
                EndNode FourthPlace = new EndNode();

                List<FinalistData> finalistData = SingleEliminationFinal.GetFinalists();

                if (finalistData.Count > 1)
                {
                    MatchNode thirdPlaceFianl = GenerateMatchNode();
                    thirdPlaceFianl.AddFinalist(
                        finalistData[0].GetNode(),
                        MatchOutcome.OneVsOneLooser);
                    thirdPlaceFianl.AddFinalist(
                        finalistData[1].GetNode(),
                        MatchOutcome.OneVsOneLooser);
                    thirdPlaceFianl.SetName("Third place final");
                    SingleEliminationThirdPlaceFinal = thirdPlaceFianl;

                    ThirdPlace.AddFinalist(thirdPlaceFianl, MatchOutcome.OneVsOneWinner);
                    FourthPlace.AddFinalist(thirdPlaceFianl, MatchOutcome.OneVsOneLooser);
                    SingleEliminationPlacements.Add(ThirdPlace);
                    SingleEliminationPlacements.Add(FourthPlace);
                    SingleEliminationGames.Add(thirdPlaceFianl);
                }
            }

            foreach ( var v in SingleEliminationGames)
            {
                v.SetName( "Third place Final");
            }

            SingleEliminationFinal.SetName("Final");
            SingleEliminationGames.Add(SingleEliminationFinal);

            RenameNodes();

        }

        public List<List<MatchNode>> GetRoundData()
        {
            List<List<MatchNode>> rounds = new List<List<MatchNode>>();

            int maxDepth = SingleEliminationFinal.GetNodeDepth();

            for( int i = 0; i < maxDepth; i++)
            {
                List<MatchNode> round = new List<MatchNode>();
                foreach( var match in GetAllMatches())
                {
                    if ( match.GetNodeDepth() == i)
                    {
                        match.Update();
                        round.Add(match);
                    }
                }
                rounds.Add(round);
            }


            if (SingleEliminationTeamEntryPoints.Count >= 4 && SingleEliminationThirdPlaceFinal != null)
            {
                List<MatchNode> thirdplace = new List<MatchNode>();
                thirdplace.Add(SingleEliminationThirdPlaceFinal);

                rounds.Add(thirdplace);
            }


            List<MatchNode> lastRound = new List<MatchNode>();
            lastRound.Add(SingleEliminationFinal);

            rounds.Add(lastRound);
            return rounds;
        }

        private void RenameNodes()
        {
            int maxDepth = SingleEliminationFinal.GetNodeDepth();

            int gameNr = 0;
            for ( int i = 0; i < maxDepth; i++)
            {
                gameNr = 0;
                foreach (var game in GetAllMatches())
                {
                    if ( game.GetNodeDepth() == i)
                    {
                        gameNr++;
                        game.SetName("RG-" + i + "" + gameNr);
                    }
                }
            }
        }
        public List<MatchNode> GetActiveTournamnetNodes()
        {
            List<MatchNode> activeNodes = new List<MatchNode>();

            foreach (MatchNode match in SingleEliminationGames)
            {
                match.Update();
                if (match.IsGameActive())
                {
                    activeNodes.Add(match);
                }
            }

            return activeNodes;
        }

        public List<MatchNode> GetAllMatches()
        {
            return SingleEliminationGames;
        }
        private bool CanMerge()
        {
            return SingleEliminationFinal.NumberOfFinalists() > 2;
        }
        private bool DoMerge()
        {
            bool canMerge = CanMerge();

            if (canMerge)
            {
                

                FinalistData first = GetShallowNode();
                SingleEliminationFinal.RemoveFinalist(first);

                FinalistData second = GetShallowNode();
                SingleEliminationFinal.RemoveFinalist(second);

                MatchNode newMatch = GenerateMatchNode();
                newMatch.AddFinalist(first);
                newMatch.AddFinalist(second);

                SingleEliminationFinal.AddFinalist(newMatch, MatchOutcome.OneVsOneWinner);
                SingleEliminationGames.Add(newMatch);

                canMerge = CanMerge();
            }

            return canMerge;
        }
        private MatchNode GenerateMatchNode()
        {
            return new MatchNode(SingleEliminationGameRule);
        }
        private FinalistData GetShallowNode()
        {
            FinalistData node = null;

            int shallowest = int.MaxValue;

            foreach ( FinalistData fn in SingleEliminationFinal.GetFinalists())
            {
                INode n = fn.GetNode();
                int depth = n.GetNodeDepth();
                if ( shallowest > depth)
                {
                    shallowest = depth;
                    node = fn;
                }
            }

            return node;
        }
        private void ConnectLeafNodesToMatch(INode game)
        {
            foreach (INode leaf in SingleEliminationTeamEntryPoints)
            {
                game.AddFinalist(leaf, MatchOutcome.OneVsOneWinner);
            }
        }

        public List<LeafNode> GetTournamentLeafNodes()
        {
            return SingleEliminationTeamEntryPoints;
        }

        public List<EndNode> GetTournamentEndNodes()
        {
            return SingleEliminationPlacements;
        }
        

        public void ForceUpdate()
        {
            foreach(MatchNode mn in SingleEliminationGames)
            {
                mn.Update();
            }
        }

        public void DeleteTeam(ITeam team)
        {
            foreach(LeafNode lfn in SingleEliminationTeamEntryPoints )
            {
                if(lfn.GetCompeditor(0) == team )
                {
                    SingleEliminationTeamEntryPoints.Remove(lfn);
                    break;
                }
            }
        }

        public void ShuffleTeams()
        {
            List<LeafNode> shuffle = new List<LeafNode>();

            Random ran = new Random();
            foreach (LeafNode node in SingleEliminationTeamEntryPoints)
            { 
                Byte[] array = new Byte[4];
                ran.NextBytes(array);

                if (BitConverter.IsLittleEndian)
                {
                    Array.Reverse(array);
                }

                uint index = (uint)BitConverter.ToInt32(array, 0);

                index = index % (uint)(shuffle.Count + 1);
                shuffle.Insert((int)index, node);
            }

            SingleEliminationTeamEntryPoints = shuffle;
        }
    }
}
