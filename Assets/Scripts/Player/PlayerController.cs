using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    protected GV.PLAYER_UNIT whichPlayer;
    protected float maxLife, currentLife, actionPoints;

    protected float moveRange;
    protected float maxAttackRange;
    protected float minAttackRange;

    Vector3 position;
    Vector3 newPos;
    GameObject thePlayer;

    public void RenderMoveTile()
    {
        float maxX = transform.position.x + moveRange;
        float minX = transform.position.x - moveRange;
        float maxY = transform.position.y + moveRange;
        float minY = transform.position.y - moveRange;

        float maxGridXY = GridManager.Instance.GetMaxGridXY();
        float minGridXY = -maxGridXY;

        Vector2Int playerPos = new Vector2Int((int)transform.position.x, (int)transform.position.y);

        for (float x = minX; x <= maxX; x++)
        {
            if (x >= minGridXY && x <= maxGridXY)
            {
                for (float y = minY; y <= maxY; y++)
                {
                    if (y >= minGridXY && y <= maxGridXY)
                    {
                        Vector2Int movingTilePos = new Vector2Int((int)x, (int)y);
                        if (Vector2Int.Distance(playerPos, movingTilePos) <= moveRange)
                        {
                            GridManager.Instance.CreateMovingTiles(movingTilePos);
                        }
                    }
                }
            }
        }
    }

    public void RenderAttackTile()
    {
        float maxX = transform.position.x + maxAttackRange;
        float minX = transform.position.x - maxAttackRange;
        float maxY = transform.position.y + maxAttackRange;
        float minY = transform.position.y - maxAttackRange;

        float maxGridXY = GridManager.Instance.GetMaxGridXY();
        float minGridXY = -maxGridXY;

        Vector2Int playerPos = new Vector2Int((int)transform.position.x, (int)transform.position.y);

        for (float x = minX; x <= maxX; x++)
        {
            if (x >= minGridXY && x <= maxGridXY)
            {
                for (float y = minY; y <= maxY; y++)
                {
                    if (y >= minGridXY && y <= maxGridXY)
                    {
                        Vector2Int movingTilePos = new Vector2Int((int)x, (int)y);
                        if (Vector2Int.Distance(playerPos, movingTilePos) >= minAttackRange && Vector2Int.Distance(playerPos, movingTilePos) <= maxAttackRange)
                        {
                            GridManager.Instance.CreateMovingTiles(movingTilePos);
                        }
                    }
                }
            }
        }
    }

    public void Init() { }

    void Start()
    {
        position = new Vector3(3, 3, 0);
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
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

    public void upDateAP(float cost)
    {
        actionPoints -= cost;
    }
}
