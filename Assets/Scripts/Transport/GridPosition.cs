using System;

/// <summary>
/// A position in a grid. Uses integers
/// to denote <see cref="X"/> and 
/// <see cref="Y"/> position.
/// </summary>
public class GridPosition {

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
    public GridPosition(int x, int y)
    {
        X = x;
        Y = y;
    }

    /// <summary>
    /// Adds the other <see cref="GridPosition"/>s 
    /// <see cref="X"/> and <see cref="Y"/> parameter
    /// to the ones of the current instance.
    /// </summary>
    /// <returns>A new <see cref="GridPosition"/> where
    /// the <see cref="X"/> and <see cref="Y"/> parameters
    /// are added.</returns>
    public GridPosition Add(GridPosition other)
    {
        return new GridPosition(X + other.X, Y + other.Y);
    }

    /// <summary>
    /// Gets the <see cref="GridPosition"/> of the neighbour
    /// in the given <see cref="Direction"/>. 
    /// Calls <see cref="getRelativePosition(Direction)"/>.
    /// </summary>
    /// <param name="dir">The given <see cref="Direction"/></param>
    public GridPosition GetNeighbor(Direction dir)
    {   
        return Add(getRelativePosition(dir));
    }

    /// <summary>
    /// Returns a new <see cref="GridPosition"/> that matches the given <see cref="Direction"/>.
    private GridPosition getRelativePosition(Direction dir)
    {
        return Directions.toGridPosition(dir);
    }
}
