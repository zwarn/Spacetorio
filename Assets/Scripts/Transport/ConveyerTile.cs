using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ConveyerTile : TileObject {

    private ConveyerNode inConnection;
    private ConveyerNode outConnection;
    private List<ConveyerNode> inArm;
    private List<ConveyerNode> outArm;
    private Direction input;
    private Direction output;
    private ConveyerNode middle;

    //TODO: maybe extract into a settings class
    // conveyer belt speed
    private float speed = 1f;
    // distance from middle of the tile to the edge
    private float distance = 0.5f;
    // number of nodes in an arm
    private int numberOfNodes = 5;

    public void init(Direction output, Direction input, ConveyerNode inConnection)
    {
        this.output = output;
        this.middle = new ConveyerNode(transform.position, speed);
        outArm = createArm(output, false, null);
        inArm = createArm(input, true, inConnection);
    }

    public List<ConveyerNode> createArm(Direction dir, bool inside, ConveyerNode connection)
    {
        // Danger : untested
        Vector3 from = transform.position;
        Vector3 to = from + Directions.toVector(dir) * distance;
        ConveyerNode prevNode = middle;
        Vector3 prevPosition = middle.from;
        List<ConveyerNode> arm = new List<ConveyerNode>();
        for (int i = 1; i <= numberOfNodes; i++)
        {
            Vector3 currentPosition = Vector3.Lerp(from, to, i / numberOfNodes);
            ConveyerNode currentNode = new ConveyerNode(currentPosition, speed);

            link(currentNode, prevNode, inside);

            arm.Add(currentNode);
            prevNode = currentNode;
            prevPosition = currentPosition;
        }

        if (connection != null)
        {
            link(prevNode, connection, inside);
        }

        return arm;
    }

    private void link(ConveyerNode fromNode, ConveyerNode toNode, bool forward)
    {
        if (forward)
        {
            fromNode.to = toNode.from;
            fromNode.output = toNode;
        }
        else
        {
            toNode.to = fromNode.from;
            toNode.output = fromNode;
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    foreach (ConveyerNode node in inArm)
        {
            node.Update();
        }
        middle.Update();
        foreach (ConveyerNode node in outArm)
        {
            node.Update();
        }
    }
}
