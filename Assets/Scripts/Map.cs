using UnityEngine;
using System.Collections;

public class State {

    public Tile[,] Tiles;


    public State (int size)
    {
        tiles = new Tile[size, size];
    }

    private Tile getTile(Vector2 vector)
    {
        if (vector.x >= 0 && vector.x < tiles.GetLength(0) && vector.y >= 0 && vector.x < tiles.GetLength(1))
        {
            return tiles[Mathf.FloorToInt(vector.x), Mathf.FloorToInt(vector.y)];
        }
        return null;
    }

}
