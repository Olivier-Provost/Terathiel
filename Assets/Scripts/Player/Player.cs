using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Player : MonoBehaviour {

    Tile player;

	// Use this for initialization
	void Start () {
        player = ScriptableObject.CreateInstance<PlayerTile>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
