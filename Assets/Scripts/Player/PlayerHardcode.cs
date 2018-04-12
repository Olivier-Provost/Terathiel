using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerHardcode : MonoBehaviour {

    string playerTag;
    [HideInInspector]
    public float maxHealth, maxAp, health, ap;

    Transform thePlayer;
    Vector3 position, newPos;

	// Use this for initialization
	void Start () {
        thePlayer = GetComponent<Transform>();

        playerTag = thePlayer.tag;

        maxHealth = GV.PLAYERS_MAX_LIFE;
        maxAp = GV.PLAYERS_MAX_ACTION_POINTS;

        switch (playerTag)
        {
            case "Player1":
                StartPlayerTile(new Vector3Int(3, 3, 0));
                break;
            case "Player2":
                StartPlayerTile(new Vector3Int(18, 18, 0));
                break;
        }
	}

    // Update is called once per frame
    void Update()
    {
        position = thePlayer.transform.position;

        if (Input.GetMouseButtonUp(0))
        {
            //if (Mathf.Approximately(Input.mousePosition.x, position.x) && Mathf.Approximately(Input.mousePosition.y, position.y))
            {
                if (Mathf.Abs(newPos.x - position.x) + Mathf.Abs(newPos.y - position.y) <= 5)
                {
                    SetPlayerTile(Input.mousePosition);
                    Debug.Log("Tile : " + GridTest.Instance.TileClicked(Input.mousePosition) + " World : " + Input.mousePosition);
                }
                newPos = position;
                Debug.Log(Mathf.Abs(newPos.x - position.x) + Mathf.Abs(newPos.y - position.y));
            }
        }
    }

    public void OnClick(BaseEventData data)
    {
        Debug.Log(gameObject.tag);
    }

    public void SetPlayerTile(Vector3 newPos)
    {
        Vector3 playerPos = newPos;
        playerPos = GridTest.Instance.TileClicked(playerPos);
        playerPos.x += 75.5f;
        playerPos.y += 0.5f;

        thePlayer.transform.position = playerPos;
    }

    public void StartPlayerTile(Vector3Int tile)
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
