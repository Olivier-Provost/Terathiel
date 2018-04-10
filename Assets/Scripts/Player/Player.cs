using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player {

    private float ap;

    public Player()
    {
        ap = GV.PLAYERS_MAX_ACTION_POINTS;
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
}
