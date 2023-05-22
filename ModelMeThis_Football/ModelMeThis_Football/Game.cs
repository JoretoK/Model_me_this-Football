using System;
using System.Collections.Generic;
using System.Linq;

namespace ModelMeThis_Football
{
    public class Game
    {
        private Team team1;
        private Team team2;
        private Referee referee;
        private List<Goals> goals = new List<Goals>();
        private bool isOver = false;

        public Game(Team team1, Team team2, Referee referee)
        {
            this.team1 = team1;
            this.team2 = team2;
            this.referee = referee;
        }
        public void Score(int minute, Player player)
        {
            if (!isOver)
            {
                Goals goal = new Goals() { Minute = minute, Player = player };
                goals.Add(goal);
            }
        }
        public string EndOfTheGame()
        {
            isOver = true;
            int team1Goals = 0;
            int team2Goals = 0;

            foreach (Goals goal in goals)
            {
                // Gettin some troubles here 


                //if (team1.Players.Contains(goal.Player))
                //{
                //    team1Goals++;
                //}
                //else if (team2.Players.Contains(goal.Player))
                //{
                //    team2Goals++;
                //}
            }

            string result;
            if (team1Goals > team2Goals)
            {
                result = $"{team1}'s team wins!";
            }
            else if (team2Goals > team1Goals)
            {
                result = $"{team2}'s team wins!";
            }
            else
            {
                result = "The game is a draw.";
            }
            return result;
        }
    }
}
