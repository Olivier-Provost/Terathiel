using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridTest  {
    
    Tilemap tm;
    Vector3Int tilePos;

    #region Singleton
    private static GridTest instance;

    private GridTest() {
        tm = GameObject.FindObjectOfType<Tilemap>();
    }

    public static GridTest Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GridTest();
            }
            return instance;
        }
    }
    #endregion

    public Vector3Int TileClicked(Vector3 mousePositionOnClick)
    {
        Vector3Int tilePos;

        Vector3 mp = Camera.main.ScreenToWorldPoint(mousePositionOnClick);
        mp.z = 0;

        tilePos = tm.WorldToCell(mp);

        return tilePos;
    }

    public Vector3 TileToWorld(Vector3Int tileSelected)
    {
        Vector3 tile;

        tile = tm.CellToLocal(tileSelected);

        Debug.Log("Tile : " + tileSelected + " World : " + tile);

        return tile;
    }
}
