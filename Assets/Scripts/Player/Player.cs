using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player {

    int pid;
    public float ap;
    public float health;
    HealthBar healthBar;

    public Player(int _pid)
    {
        pid = _pid;
        healthBar = GameObject.Find("HealthBar" + pid).GetComponent<HealthBar>();
        ap = GV.PLAYERS_MAX_ACTION_POINTS;
        health = GV.PLAYERS_MAX_LIFE;
    }

    public void UpdateAP(float _nbAP)
    {
        ap += _nbAP;
    }

    public void ResetAP()
    {
        ap = GV.PLAYERS_MAX_ACTION_POINTS;
    }

    public float GetAP()
    {
        return ap;
    }
    
    public float getHealth()
    {
        return health;
    }

    public void dommage()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("dommage aply ");
            health -= 5;
        }
    }

}
