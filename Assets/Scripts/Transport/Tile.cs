/// <summary>
/// A class representing a tile in a <see cref="Grid"/>.
/// </summary>
public class Tile {

    /// <summary>
    /// The position of the tile.
    /// </summary>
    public IntPosition Position;

    /// <summary>
    /// The object that lies on the tile.
    /// </summary>
    public TileObject TileObject;

    /// <summary>
    /// Initializes the <see cref="Position"/>
    /// with the given x and y parameters.
    /// </summary>
    public Tile(int x, int y)
    {
        Position = new IntPosition(x, y);
    }

    /// <summary>
    /// Initializes the <see cref="Position"/> with
    /// the given position.
    /// </summary>
    /// <param name="position"></param>
    public Tile (IntPosition position)
    {
        this.Position = position;
    }

}
