using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

    public Vector3 Direction;
    public float Speed;

    public BulletController(Vector2 direction, float speed = 0)
    {    }	
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.up * Speed;
	}
}
