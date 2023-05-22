using System;
using System.Collections.Generic;
using System.Text;

namespace ModelMeThis_Football
{
    public class Team
    {
        private Coach coach;
        private List<Player> players;
        private int minPlayers = 11;
        private int maxPlayers = 22;

        public Team(Coach coach, List<Player> players)
        {
            this.coach = coach;
            this.players = players;
        }

        public object Coach { get; internal set; }
        public object Players { get; internal set; }

        public double AverageAge()
        {
            int totalAge = 0;
            foreach (Player player in players)
            {
                totalAge += player.Age;
            }
            return (double)totalAge / players.Count;
        }
    }
}
