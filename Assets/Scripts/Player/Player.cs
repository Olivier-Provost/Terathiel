using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Player : MonoBehaviour {

    public GameObject thePlayer;

    Vector3 position;
    Vector3 newPos;

    //bool myTurn;

    void Start()
    {
        position = new Vector3(3, 3, 0);
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Vector3 mp = Input.mousePosition;
            Debug.Log(mp);
            if (mp.x >= 238 && mp.x <= 874 && mp.y >= 93 && mp.y <= 337)
            {
                newPos = GridTest.Instance.TileClicked(Input.mousePosition);
                if ((Mathf.Abs(newPos.x - position.x) + Mathf.Abs(newPos.y - position.y)) <= 5)
                {
                    SetPlayerTile(Input.mousePosition);
                    position = newPos;
                }
                Debug.Log(Mathf.Abs(newPos.x - position.x) + Mathf.Abs(newPos.y - position.y));
            }
        }
    }

    public void SetPlayerTile(Vector3 newPos)
    {
        Vector3 playerPos = newPos;
        playerPos = GridTest.Instance.TileClicked(playerPos); 
        playerPos.x += 72.6f;
        playerPos.y += 19.1f;

        thePlayer.transform.position = playerPos;
    }

    public Vector3 GetPlayerPosition()
    {
        return position;
    }
}
