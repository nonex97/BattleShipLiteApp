using BattleShipLiteLibrary;
using BattleShipLiteLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipLite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();

            PlayerInfoModel player1 = CreatePlayer("Player 1");
            PlayerInfoModel player2 = CreatePlayer("Player 2");

            Console.ReadLine();
        }

        private static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Battleship Lite");
            Console.WriteLine("Created by Neven Grguric");
            Console.WriteLine();
        }

        private static PlayerInfoModel CreatePlayer(string playerTitle)
        {
            PlayerInfoModel output = new PlayerInfoModel();

            Console.WriteLine($"Player information for: {playerTitle}");

            // Ask the player for their name
            output.PlayersName = AskForPlayersName();

            // Load up the shot grid
            GameLogic.InitializeGrid(output);

            // Ask the player for their 5 ship placements
            PlaceShips(output);

            // Clear
            Console.Clear();

            return output;
        }

        private static string AskForPlayersName()
        {
            Console.Write("What is your name: ");
            string output = Console.ReadLine();

            return output;
        }

        private static void PlaceShips(PlayerInfoModel model)
        {
            do
            {
                Console.Write($"Where do you want to place your ship number {model.ShipLocations.Count + 1}: ");
                string location = Console.ReadLine();

                bool isValidLocation = GameLogic.PlaceShip(model, location);

                if (isValidLocation == false)
                {
                    Console.WriteLine("That was not a valid location. Please try again.");
                }
            }
            while (model.ShipLocations.Count < 5);
        }
    }
}
