using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperCrossBlades
{
    public class GameLoop
    {
        public GameLoop() 
        {
            Random random = new Random();
            Player player = new Player();
            Player computer = new Player();
            
            int cpuNumber = random.Next(1,4);
            string? playerChoiceString;

            bool isValidInput = false;
            bool playAgain = true;

            switch (cpuNumber)
            {
                case 1:
                    computer.Choice = Actions.Choice.Rock;
                    break;
                case 2:
                    computer.Choice = Actions.Choice.Paper;
                    break;
                case 3:
                    computer.Choice = Actions.Choice.Crossblades;
                    break;
            }

            do
            {
                Console.WriteLine(Prompt.InitialPrompt());
                playerChoiceString = Console.ReadLine();

                switch (playerChoiceString?.ToLower())
                {
                    case "rock":
                        player.Choice = Actions.Choice.Rock;
                        isValidInput = true;
                        break;
                    case "paper":
                        player.Choice = Actions.Choice.Paper;
                        isValidInput = true;
                        break;
                    case "crossblades":
                        player.Choice = Actions.Choice.Crossblades;
                        isValidInput = true;
                        break;
                    case "answer to life":
                        player.Choice = Actions.Choice.Answer;
                        isValidInput = true;
                        break;
                    case "":
                        player.Choice = Actions.Choice.Indecisive;
                        isValidInput = true;
                        break;
                }

                if (!isValidInput)
                {
                    Console.WriteLine(Prompt.Error());
                }
            } while (!isValidInput);

            while (playAgain)
            {
                Console.WriteLine(Prompt.WinLossTie(player.Choice, computer.Choice));

                Console.WriteLine(Prompt.PlayAgain());
                string? replay = Console.ReadLine();
                switch (replay?.ToLower())
                {
                    case "y":
                        GameLoop newGame = new GameLoop();
                        break;
                    case "n":
                        Environment.Exit(0);
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
