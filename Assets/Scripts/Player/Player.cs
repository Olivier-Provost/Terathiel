using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Player : MonoBehaviour {

    public GameObject thePlayer;
    public float Health = 100f;
    public float actionPoint = 6f;
    Vector3 position;
    Vector3 newPos;
    //Vector3Int tilePos;

    //bool myTurn;
    
    // Use this for initialization
	void Start () {
        
        //tilePos = gt.TileClicked(position);
	}

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {

            position = thePlayer.transform.position;
            if (Mathf.Abs(newPos.x - position.x) + Mathf.Abs(newPos.y - position.y) <= 5)
            {
                SetPlayerTile(Input.mousePosition);
            }
            newPos = position;
            Debug.Log(Mathf.Abs(newPos.x - position.x) + Mathf.Abs(newPos.y - position.y));
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
}
