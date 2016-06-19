using UnityEngine;
using System.Collections;
using System;

public class IntPosition {

    public int X;
    public int Y;

    public IntPosition(int x, int y)
    {
        X = x;
        Y = y;
    }

    public IntPosition add(IntPosition other)
    {
        return new IntPosition(X + other.X, Y + other.Y);
    }

    public IntPosition getNeighbor(Direction dir)
    {   
        return add(getRelativePosition(dir));
    }

    private IntPosition getRelativePosition(Direction dir)
    {
        switch (dir)
        {
            case Direction.EAST:
                return new IntPosition(1, 0);
            case Direction.NORTH:
                return new IntPosition(0, -1);
            case Direction.SOUTH:
                return new IntPosition(0, 1);
            case Direction.WEST:
                return new IntPosition(-1, 0);
            default:
                throw new Exception("Unknown Direction");
        }
    }
}
