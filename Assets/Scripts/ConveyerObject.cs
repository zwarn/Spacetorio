using UnityEngine;
using System.Collections;

public class ConveyerObject : MonoBehaviour {

    GameController gameController;

	// Use this for initialization
	void Start () {
        gameController = GameController.Instance;
	}
	
	// Update is called once per frame
	void Update () {
        Tile currentTile = gameController.State.getTile(transform.position.x, transform.position.y);
        if (currentTile != null)
        {
            transform.Translate(currentTile.getVector() * currentTile.Speed * Time.deltaTime);
        }
	}
}
