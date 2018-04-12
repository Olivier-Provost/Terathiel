using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHardcode : MonoBehaviour {

    string playerTag;
    [HideInInspector]
    public float maxHealth, maxAp, health, ap;

    Transform thePlayer;
    Vector3Int position;
    Vector3Int startP1, startP2;

	// Use this for initialization
	void Start () {

        health = 20;

        startP1 = new Vector3Int(3, 3, 0);
        startP2 = new Vector3Int(18, 18, 0);

        thePlayer = GetComponent<Transform>();
        playerTag = thePlayer.tag;

        maxHealth = GV.PLAYERS_MAX_LIFE;
        maxAp = GV.PLAYERS_MAX_ACTION_POINTS;

        switch (playerTag)
        {
            case "Player1":
                SetPlayerTile(startP1);
                position = startP1;
                break;
            case "Player2":
                SetPlayerTile(startP2);
                position = startP2;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(health > 0)
                health -= TakesDamage(5);
            if (health < 0)
                health = 0;

            Debug.Log("damage apply" + health);
        }

        if (playerTag == "Player1")
        {
            if (Input.GetKeyUp(KeyCode.W))
                position.y++;
            if (Input.GetKeyUp(KeyCode.S))
                position.y--;
            if (Input.GetKeyUp(KeyCode.A))
                position.x--;
            if (Input.GetKeyUp(KeyCode.D))
                position.x++;
            SetPlayerTile(position);
        }
        if (playerTag == "Player2")
        {
            if (Input.GetKeyUp(KeyCode.UpArrow))
                position.y++;
            if (Input.GetKeyUp(KeyCode.DownArrow))
                position.y--;
            if (Input.GetKeyUp(KeyCode.LeftArrow))
                position.x--;
            if (Input.GetKeyUp(KeyCode.RightArrow))
                position.x++;
            SetPlayerTile(position);
        }
    }

    public void SetPlayerTile(Vector3 newPos)
    {
        Vector3 playerPos = newPos;
        playerPos = GridTest.Instance.TileClicked(playerPos);
        playerPos.x += 75.5f;
        playerPos.y += 0.5f;

        thePlayer.transform.position = playerPos;
    }

    public void SetPlayerTile(Vector3Int tile)
    {
        Vector3 startPos = tile;
        startPos.x += 75.5f;
        startPos.y += 0.5f;

        thePlayer.transform.position = startPos;
    }


    public float TakesDamage(float amount)
    {
        return amount;
    }
}
