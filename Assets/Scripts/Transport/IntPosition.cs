using System;

/// <summary>
/// A position in a grid. Uses integers
/// to denote <see cref="X"/> and 
/// <see cref="Y"/> position.
/// </summary>
public class IntPosition {

    /// <summary>
    /// The x parameter of this position.
    /// </summary>
    public int X;

    /// <summary>
    /// The y parameter of this position.
    /// </summary>
    public int Y;

    /// <summary>
    /// Constructor that initializes <see cref="X"/> 
    /// and <see cref="Y"/> with the given parameters.
    /// </summary>
    public IntPosition(int x, int y)
    {
        X = x;
        Y = y;
    }

    /// <summary>
    /// Adds the other <see cref="IntPosition"/>s 
    /// <see cref="X"/> and <see cref="Y"/> parameter
    /// to the ones of the current instance.
    /// </summary>
    /// <returns>A new <see cref="IntPosition"/> where
    /// the <see cref="X"/> and <see cref="Y"/> parameters
    /// are added.</returns>
    public IntPosition Add(IntPosition other)
    {
        return new IntPosition(X + other.X, Y + other.Y);
    }

    /// <summary>
    /// Gets the <see cref="IntPosition"/> of the neighbour
    /// in the given <see cref="Direction"/>. 
    /// Calls <see cref="getRelativePosition(Direction)"/>.
    /// </summary>
    /// <param name="dir">The given <see cref="Direction"/></param>
    public IntPosition GetNeighbor(Direction dir)
    {   
        return Add(getRelativePosition(dir));
    }

    /// <summary>
    /// Returns a new <see cref="IntPosition"/> that matches the given <see cref="Direction"/>.
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
