using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public List<Player> Players;

    int maxPlayers;
    int currentPlayer = 0;

    public Player GetCurrentPlayer()
    {
        return Players[currentPlayer];
    }

    public void Start()
    {
        foreach (Player player in Players)
        {
            player.Disable();
        }
        Players[currentPlayer].Enable();
    }

    public void EndTurn()
    {
        Players[currentPlayer].Disable();

        maxPlayers = Players.Count - 1;
        if (maxPlayers > currentPlayer)
        {
            currentPlayer++;
        }
        else
        {
            currentPlayer = 0;
        }

        Players[currentPlayer].Enable();
    }
}
