using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperCrossBlades
{
    public static class Prompt
    {   
        public static string InitialPrompt()
        {
            return "Choose either: Rock, Paper, Crossblades";
        }
        public static string PlayAgain()
        {
            return "Play Again? Y / N";
        }
        public static string WinLossTie(Actions.Choice player, Actions.Choice cpu)
        {
            if (player == Actions.Choice.Answer)
            {
                return "You win! There was no contest! The answer to life the universe and everything else, always prevails!";
            }

            if (player == Actions.Choice.Indecisive)
            {
                return "There was no contest due to indecision... You lose.";
            }

            if (player == Actions.Choice.Rock && cpu == Actions.Choice.Crossblades ||
                player == Actions.Choice.Paper && cpu == Actions.Choice.Rock || 
                player == Actions.Choice.Crossblades && cpu == Actions.Choice.Paper)
            {
                return $"You win! {player} beats {cpu}";
            }

            else if (player == cpu)
            {
                return $"Game was a tie. {player} is the same as {cpu}";
            }

            else
            {
                return $"You lost the game. {cpu} beats {player}";
            }
        }
        public static string Error()
        {
            return "That is not a valid input.";
        }
    }
}
