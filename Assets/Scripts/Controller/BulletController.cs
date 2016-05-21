using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

    private Vector3 _direction;
    private float _speed;

    public BulletController(Vector2 direction, float speed = 0)
    {
        _direction = direction;
        _speed = speed;
    }	
	
	// Update is called once per frame
	void Update () {
        transform.position += _direction * _speed;
	}
}
