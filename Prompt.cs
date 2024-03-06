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
        public static string WinLossTie(Actions.Choice player, Actions.Choice computer)
        {
            if (player == Actions.Choice.Answer)
            {
                return "You win! There was no contest! The answer to life the universe and everything else, always prevails!";
            }

            if (player == Actions.Choice.Indecisive)
            {
                return "There was no contest due to indecision... You lose.";
            }

            if (player == Actions.Choice.Rock && computer == Actions.Choice.Crossblades ||
                player == Actions.Choice.Paper && computer == Actions.Choice.Rock || 
                player == Actions.Choice.Crossblades && computer == Actions.Choice.Paper)
            {
                return $"You win! {player} beats {computer}";
            }

            else if (player == computer)
            {
                return $"Game was a tie. {player} is the same as {computer}";
            }

            else
            {
                return $"You lost the game. {computer} beats {player}";
            }
        }
        public static string Error()
        {
            return "That is not a valid input.";
        }
    }
}
