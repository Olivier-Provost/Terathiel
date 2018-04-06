using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public class PlayerTile : Tile {
    
    public Vector3Int playerPos;

    public override bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go)
    {
        return base.StartUp(playerPos, tilemap, go);
    }

    public override void RefreshTile(Vector3Int position, ITilemap tilemap)
    {
        base.RefreshTile(position, tilemap);
    }

    public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData)
    {
        base.GetTileData(position, tilemap, ref tileData);
    }
}
