using UnityEngine;

public class BulletController : MonoBehaviour {
    
    public Vector3 Direction;
    public float Speed;
    public int LifeTime;

    public BulletController(Vector2 direction, float speed = 0)
    {    }	
	
    void Start()
    {
        Destroy(gameObject, LifeTime);
    }

	// Update is called once per frame
	void Update () {
        transform.position += transform.up * Speed;        
	}
}
