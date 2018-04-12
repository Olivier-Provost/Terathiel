using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHardcode : MonoBehaviour {

    public int PlayerNumber;
    [HideInInspector]
    public float maxHealth, maxAp, health, ap;

	// Use this for initialization
	void Start () {
        maxHealth = GV.PLAYERS_MAX_LIFE;
        maxAp = GV.PLAYERS_MAX_ACTION_POINTS;
	}
	
	// Update is called once per frame
	void Update () {
        health -= TakesDamage(5);
	}

    public float TakesDamage(float amount)
    {
        return amount;
    }
}
