using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager  {

    #region singleton
    private static GameManager instance;

    private GameManager() { }

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
                instance = new GameManager();

            return instance;
        }
    }
    #endregion singleton

    private float gameTurn = 1;
    private float playerWhoPlay = 1;
    private bool isGameEnded = false;
    private Transform player1, player2;

    public void Init(Transform _player1, Transform _player2)
    {
        player1 = _player1;
        player2 = _player2;

        player1.GetComponent<Player>();
        player2.GetComponent<Player>();
    }

    public float GetCurrentPlayer()
    {
        return playerWhoPlay;
    }

    public void NextTurn()
    {
        playerWhoPlay += 1;
        
        PlayerManager.Instance.EndTurn(gameTurn);
        GridManager.Instance.EndTurn();
        UIManager.Instance.EndTurn();
    }
}
