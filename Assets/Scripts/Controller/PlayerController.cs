using UnityEngine;
using System.Collections;
using System;

public class PlayerController : MonoBehaviour , Player {

    public float speed = 1f;

    public void move(Vector2 direction)
    {
        Vector3 vector = new Vector3(direction.x, direction.y, 0);
        vector *= speed * Time.deltaTime;
        gameObject.transform.Translate(vector);
    }
    
    // Use this for initialization
    void Start () {
        InputController.Instance.registerPlayer(this);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
