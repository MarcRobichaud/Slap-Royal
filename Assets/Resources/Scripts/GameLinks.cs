using UnityEngine;

public class GameLinks : MonoBehaviour
{
    public Player player1;
    public Player player2;

    public Player GetOpponents(Player player)
    {
        if (player == player1)
            return player2;
        return player1;
    }
}