using System;
using UnityEngine;
/// <summary>
/// Enumeration that defines directions of
/// movement.
/// </summary>
public enum Direction {
    NORTH,
    EAST,
    SOUTH,
    WEST
}

static class Directions
{
    public static Vector3 toVector(Direction direction)
    {
        switch (direction)
        {
            case Direction.EAST:
                return new Vector3(1, 0);
            case Direction.NORTH:
                return new Vector3(0, -1);
            case Direction.SOUTH:
                return new Vector3(0, 1);
            case Direction.WEST:
                return new Vector3(-1, 0);
            default:
                throw new Exception("Unknown Direction");
        }
    }

    public static GridPosition toGridPosition(Direction direction)
    {
        switch (direction)
        {
            case Direction.EAST:
                return new GridPosition(1, 0);
            case Direction.NORTH:
                return new GridPosition(0, -1);
            case Direction.SOUTH:
                return new GridPosition(0, 1);
            case Direction.WEST:
                return new GridPosition(-1, 0);
            default:
                throw new Exception("Unknown Direction");
        }
    }
}
