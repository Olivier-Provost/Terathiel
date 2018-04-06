using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridTest : MonoBehaviour {
    
    Tilemap tm;
    Vector3Int tilePos;

    void Start()
    {
        tm = GetComponent<Tilemap>();
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log(TileClicked(Input.mousePosition));
        }
        //Debug.Log(grid.cellLayout);
    }

    public Vector3Int TileClicked(Vector3 mousePositionOnClick)
    {
        Vector3Int tilePos;

        Vector3 mp = Camera.main.ScreenToWorldPoint(mousePositionOnClick);
        mp.z = 0;

        tilePos = tm.WorldToCell(mp);

        return tilePos;
    }

}
