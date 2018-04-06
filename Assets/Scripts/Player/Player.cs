using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player  {
    public float health;
    public float actionPoint;
    public Vector3 position;

    public Player(float _health, float _AP, Vector3 _pos)
    {
        health = _health;
        actionPoint = _AP;
        position = _pos;
    }


	
}
