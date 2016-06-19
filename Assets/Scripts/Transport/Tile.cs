using UnityEngine;
using System.Collections;

public class Tile {

    public IntPosition Position;
    public TileObject TileObject;

    public Tile (IntPosition position)
    {
        this.Position = position;
    }

}
