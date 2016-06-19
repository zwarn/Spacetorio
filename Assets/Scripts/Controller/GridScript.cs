using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GridScript : MonoBehaviour {

    public int mapSizeX = 10;
    public int mapSizeY = 10;
    public float tileSize = 1f;


    public Dictionary<IntPosition, Tile> tiles;

    public Tile getNeighbor(Tile tile, Direction dir)
    {
        IntPosition neighborPosition = tile.Position.getNeighbor(dir);
        if (!inMap(neighborPosition))
        {
            return null;
        }
        Tile neighbor;
        tiles.TryGetValue(neighborPosition, out neighbor);
        return neighbor;
    }

    private bool inMap(IntPosition position)
    {
        return !(position.X < 0 || position.X >= mapSizeX || position.Y < 0 || position.Y >= mapSizeY);
    }

    public Vector2 toVector(IntPosition position)
    {
        //TODO: 
        return Vector2.zero;
    }

    public IntPosition toPosition(Vector2 vector)
    {
        //TODO:
        return null;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
