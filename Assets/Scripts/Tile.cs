using UnityEngine;

public class Tile
{
    public int Speed = 0;
    public Direction Dir;

    public Vector3 getVector()
    {
        switch (Dir)
        {
            case Direction.North: return Vector2.up;
            case Direction.East: return Vector2.right;
            case Direction.South: return Vector2.down;
            case Direction.West: return Vector2.left;
        }
        return Vector3.zero;
    }
}

