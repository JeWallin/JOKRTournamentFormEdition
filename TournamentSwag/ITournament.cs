using System;
using Tournament.Nodes;
using System.Collections.Generic;
using Tournament.Rule;
using Tournament.Team;

namespace Tournament.Tournament
{
    public interface ITournament
    {
        void AddLeafNode(LeafNode node);
        List<LeafNode> GetTournamentLeafNodes();
        void GenerateTournamentTree();
        List<MatchNode> GetActiveTournamnetNodes();
        void SetRulesForGames(IRule rule);
        void DeleteTeam(ITeam team);
    }
}