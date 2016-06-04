using UnityEngine;

public class State
{

    Tile[,] tiles;


    public State(int size)
    {
        tiles = new Tile[size, size];
        for (int x = 0; x < size; x++)
        {
            for (int y = 0; y < size; y++)
            {
                tiles[x, y] = new Tile();
            }
        }
    }

    public Tile getTile(float fx, float fy)
    {
        int x = Mathf.FloorToInt(fx);
        int y = Mathf.FloorToInt(fy);
        return getTile(x, y);
        
    }

    public Tile getTile(int x, int y)
    {
        if (x >= 0 && x < tiles.GetLength(0) && y >= 0 && y < tiles.GetLength(1))
        {
            return tiles[x, y];
        }
        return null;
    }

}
