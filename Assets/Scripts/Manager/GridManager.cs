using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager {

    #region singleton
    private static GridManager instance;

    private GridManager() { }

    public static GridManager Instance
    {
        get
        {
            if (instance == null)
                instance = new GridManager();

            return instance;
        }
    }
    #endregion singleton

    Dictionary<Vector2Int, Transform> grille = new Dictionary<Vector2Int, Transform>();
    List<GameObject> moveRange = new List<GameObject>();
    List<GameObject> attackRange = new List<GameObject>();

    GameObject parentMoveTile, parentAttackTile;
    int maxGridXY, minGridXY;

    public void Init(int _gridSize, Transform _player)
    {
        //Création de la grille
        maxGridXY = _gridSize / 2;
        minGridXY = -maxGridXY;

        for (int i = minGridXY; i <= maxGridXY; i++)
        {
            for (int j = minGridXY; j <= maxGridXY; j++)
            {
                grille.Add(new Vector2Int(i, j), null);
            }
        }

        foreach(Transform player in _player)
        {
            UpdateDeLaGrille(player);
        }

        if(!parentMoveTile)
        {
            parentMoveTile = new GameObject();
            parentMoveTile.name = "Moving Tiles Parent";
        }

        if(!parentAttackTile)
        {
            parentAttackTile = new GameObject();
            parentAttackTile.name = "Attack Tiles Parent";
        }
    }

    public void EndTurn()
    {
        RemoveMovingTiles();
        RemoveAttackTiles();
    }

    public void UpdateDeLaGrille(Transform _player)
    {
        Vector2Int pos = new Vector2Int((int)_player.position.x, (int)_player.position.z);
        grille[pos] = _player;
    }

    public void UpdateDeLaGrille(Transform _player, Vector2Int _oldPos)
    {
        grille[_oldPos] = null;

        Vector2Int pos = new Vector2Int((int)_player.position.x, (int)_player.position.z);
        grille[pos] = _player;
    }

    //Enlever les cases de visualisation des mouvements et attaques
    public void RemoveMovingTiles()
    {
        if (moveRange.Count > 0)
        {
            foreach (GameObject tile in moveRange)
                GameObject.Destroy(tile);

            moveRange = new List<GameObject>();
        }
    }

    public void RemoveAttackTiles()
    {
        if (attackRange.Count > 0)
        {
            foreach (GameObject tile in attackRange)
                GameObject.Destroy(tile);

            attackRange = new List<GameObject>();
        }
    }

    public void CreateAttackTiles(Vector2Int _tile)
    {
        GameObject tile = GameObject.Instantiate(Resources.Load<GameObject>("Prefabs/AttackTile"));
        tile.name = "Attack Tile";
        tile.transform.position = new Vector3(_tile.x, _tile.y, 0);
        tile.transform.SetParent(parentAttackTile.transform);
        attackRange.Add(tile);
    }

    public void CreateMovingTiles(Vector2Int _tile)
    {
        GameObject tile = GameObject.Instantiate(Resources.Load<GameObject>("Prefabs/MovingTile"));
        tile.name = "Moving Tile";
        tile.transform.position = new Vector3(_tile.x, _tile.y, 0);
        tile.transform.SetParent(parentMoveTile.transform);
        moveRange.Add(tile);
    }

    public int GetMaxGridXY()
    {
        return maxGridXY;
    }
}
