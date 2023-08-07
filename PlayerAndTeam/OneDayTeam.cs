using System;
using System.Collections.Generic;

namespace PlayerAndTeam
{
    public class OneDayTeam : ITeam
    {
        public static List<Player> oneDayTeam = new List<Player>();

        //Capacity limit of the Player List
        public OneDayTeam()
        {
            oneDayTeam.Capacity = 11;
        }

        //Adding player to the list 
        public void Add(Player player)
        {
            if (oneDayTeam.Count < oneDayTeam.Capacity)
            {
                oneDayTeam.Add(player);
                Console.WriteLine("Player is added successfully");
            }
            else
            {
                Console.WriteLine("Team is full. Cannot add more players.");
            }
        }

        //Removing player from the list
        public void Remove(int playerId)
        {
            Player playerToRemove = oneDayTeam.Find(player => player.PlayerId == playerId);
            if (playerToRemove != null)
            {
                oneDayTeam.Remove(playerToRemove);
                Console.WriteLine("Player is removed successfully");
            }
            else
            {
                Console.WriteLine("Player not found in the team.");
            }
        }

        //Searching the player by the ID
        public Player GetPlayerById(int playerId)
        {
            return oneDayTeam.Find(player => player.PlayerId == playerId);
        }

        //Searching the player by the Name
        public Player GetPlayerByName(string playerName)
        {
            return oneDayTeam.Find(player => player.PlayerName == playerName);
        }

        //Displaying all Player details
        public List<Player> GetAllPlayers()
        {
            return oneDayTeam;
        }
    }
}
