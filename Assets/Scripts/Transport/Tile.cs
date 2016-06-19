using UnityEngine;
using System.Collections;

public class Tile {

    public IntPosition Position;
    public TileObject TileObject;

    public Tile(int x, int y)
    {
        Position = new IntPosition(x, y);
    }

    public Tile (IntPosition position)
    {
        this.Position = position;
    }

}
