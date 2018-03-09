using System;
namespace Tournament.Team
{
    public class DummyTeam : ITeam
    {
        public DummyTeam()
        {
        }

        public string GetTeamName()
        {
            return "TBA";
        }
    }


    public static class DummyTeamCreator
    {
        public static DummyTeam DummyTeamInstance = new DummyTeam();
    }
}
