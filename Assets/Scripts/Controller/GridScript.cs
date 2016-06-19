using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Grid : MonoBehaviour {

    public int mapSizeX = 10;
    public int mapSizeY = 10;
    public float tileSize = 1f;


    public Tile[,] tiles;

    public Tile getNeighbor(Tile tile, Direction dir)
    {
        IntPosition neighborPosition = tile.Position.getNeighbor(dir);
        if (!inMap(neighborPosition))
        {
            return null;
        }
        return tiles[neighborPosition.X, neighborPosition.Y];
    }

    public Tile getTile(IntPosition position)
    {
        if (!inMap(position))
        {
            return null;
        }
        return tiles[position.X, position.Y];
    }

    private bool inMap(IntPosition position)
    {
        return !(position.X < 0 || position.X >= mapSizeX || position.Y < 0 || position.Y >= mapSizeY);
    }

    public Vector3 toVector(IntPosition position)
    {
        return getUpperRightCorner() + new Vector3(position.X, position.Y) * tileSize;
    }

    public IntPosition toPosition(Vector3 vector)
    {
        Vector3 relativPosition = getUpperRightCorner() - vector;
        return round(relativPosition / tileSize);
    }

    private IntPosition round(Vector3 vector)
    {
        return new IntPosition(Mathf.RoundToInt(vector.x), Mathf.RoundToInt(vector.y));
    }

    private Vector3 getUpperRightCorner()
    {
        return transform.position - new Vector3(mapSizeX, mapSizeY) * tileSize / 2;
    }
    
	void Start () {
	    for (int x = 0; x < mapSizeX; x++)
        {
            for (int y = 0; y < mapSizeY; y++)
            {
                tiles[x, y] = new Tile(x, y);
            }
        }
	}
}
