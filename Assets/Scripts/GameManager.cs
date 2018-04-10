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

    private float turnCount = 1;
    private float playerWhoPlay = 1;
    private bool isGameEnded = false;
    private transform player1, player2;

    public void Init(Transform _player1, Transform _player2)
    {
        player1 = _player1;
        player2 = _player2;

        player1.GetComponent<>().Init();
        player2.GetComponent<>().Init();
    }

    public float GetTurnCount()
    {
        return turnCount;
    }

    public float GetCurrentPlayer()
    {
        return playerWhoPlay;
    }

    public void NextTurn()
    {
        

        if (playerWhoPlay >= GV.NUMBER_OF_PLAYER)
        {
            playerPlaying = 1;
            turnCount += 1;
        }
        else
            playerPlaying += 1;

        //InputManager.Instance.NextTurn();
        PlayerManager.Instance.NextTurn(turnCount);
      
        UIManager.Instance.NextTurn(turnCount, playerWhoPlay);
    }
}
