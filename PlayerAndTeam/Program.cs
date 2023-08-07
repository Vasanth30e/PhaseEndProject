using System;
using System.Collections.Generic;

namespace PlayerAndTeam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating instance of the OneDayTeam class
            OneDayTeam oneDayTeam = new OneDayTeam();
            string opContinue;

            try
            {
                do
                {
                    Console.WriteLine("Enter your choice:");
                    Console.WriteLine("1: To Add Player");
                    Console.WriteLine("2: To Remove Player by Id");
                    Console.WriteLine("3: Get Player By Id");
                    Console.WriteLine("4: Get Player by Name");
                    Console.WriteLine("5: Get All Players");

                    Console.Write("Enter your choice: ");
                    int choice = int.Parse(Console.ReadLine());

                    //Switch case for user to choose the choice 
                    switch (choice)
                    {
                        //Adding Players
                        case 1:
                            Player player = new Player();
                            Console.Write("Enter Player Id:");
                            player.PlayerId = int.Parse(Console.ReadLine());
                            Console.Write("Enter Player Name:");
                            player.PlayerName = Console.ReadLine();
                            Console.Write("Enter Player Age:");
                            player.PlayerAge = int.Parse(Console.ReadLine());

                            oneDayTeam.Add(player);
                            break;
                        
                        //Removing Player by ID
                        case 2:
                            Console.Write("Enter Player Id to remove:");
                            int playerId = int.Parse(Console.ReadLine());
                            oneDayTeam.Remove(playerId);
                            break;

                        //Getting the Player info by ID
                        case 3:
                            Console.Write("Enter Player Id to get:");
                            playerId = int.Parse(Console.ReadLine());
                            Player retrievedPlayer = oneDayTeam.GetPlayerById(playerId);
                            if (retrievedPlayer != null)
                            {
                                Console.WriteLine($"Player Id: {retrievedPlayer.PlayerId}, Name: {retrievedPlayer.PlayerName}, Age: {retrievedPlayer.PlayerAge}");
                            }
                            else
                            {
                                Console.WriteLine("Player not found.");
                            }
                            break;
                        
                        //Getting the Player info by Name
                        case 4:
                            Console.Write("Enter Player Name to get:");
                            string playerName = Console.ReadLine();
                            retrievedPlayer = oneDayTeam.GetPlayerByName(playerName);
                            if (retrievedPlayer != null)
                            {
                                Console.WriteLine($"Player Id: {retrievedPlayer.PlayerId}, Name: {retrievedPlayer.PlayerName}, Age: {retrievedPlayer.PlayerAge}");
                            }
                            else
                            {
                                Console.WriteLine("Player not found.");
                            }
                            break;
                        
                        //Getting all the Players info
                        case 5:
                            List<Player> players = oneDayTeam.GetAllPlayers();
                            foreach (Player p in players)
                            {
                                Console.WriteLine($"Player Id: {p.PlayerId}, Name: {p.PlayerName}, Age: {p.PlayerAge}");
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");                            
                            break;
                    }
                    Console.Write("Do you want to conitue (yes\\no)?:");
                    opContinue = Console.ReadLine().ToLower();

                    if (opContinue == "no")
                    {
                        return;
                    }

                } while (opContinue == "yes");
            }
            catch(Exception ex) 
            {

                Console.WriteLine("Error occurred! " + ex.Message);

            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
