using UnityEngine;
using System.Collections;

public class State {

    Tile[,] tiles;


    public State (int size)
    {
        tiles = new Tile[size, size];
    }

    public Tile getTile(float x, float y)
    {
        if (x >= 0 && x < tiles.GetLength(0) && y >= 0 && x < tiles.GetLength(1))
        {
            return tiles[Mathf.FloorToInt(x), Mathf.FloorToInt(y)];
        }
        return null;
    }

}
