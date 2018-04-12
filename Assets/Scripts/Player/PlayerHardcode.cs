using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHardcode : MonoBehaviour {

    public int PlayerNumber;
    [HideInInspector]
    public float maxHealth, maxAp, health, ap;

	// Use this for initialization
	void Start () {
        health = 20;
        maxHealth = GV.PLAYERS_MAX_LIFE;
        maxAp = GV.PLAYERS_MAX_ACTION_POINTS;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           
            health -= TakesDamage(5);

            Debug.Log("damage apply" + health);
        }
	}

    public float TakesDamage(float amount)
    {
        return amount;
    }
}
