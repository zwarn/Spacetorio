using UnityEngine;
using System.Collections;

public class MapGenerator : MonoBehaviour {

    public GameObject gunObject;
    public GameObject producerObject;
    public GameObject beltPrefab;
    
	void Start () {
        Producer producer = producerObject.GetComponent<Producer>();
        Consumer consumer = gunObject.GetComponent<GunController>().BulletConsumer;

        Vector3 to = new Vector3(2, 2, 0);
        Vector3 from = new Vector3(1, 2, 0);
        ResourceTaker taker = consumer;

        taker = createBelt(from, to, taker);
        to = from;
        from = new Vector3(1, 1);

        taker = createBelt(from, to, taker);
        to = from;
        from = new Vector3(1, 0);

        taker = createBelt(from, to, taker);
        to = from;
        from = new Vector3(0, 0);

        taker = createBelt(from, to, taker);
        producer.output = taker;
    }

    private ResourceTaker createBelt(Vector3 from, Vector3 to, ResourceTaker resourceTaker)
    {
        Vector3 position = Vector3.Lerp(from, to, 0.5f);
        GameObject gameObject = (GameObject) GameObject.Instantiate(beltPrefab, position, Quaternion.identity);
        Belt belt = gameObject.GetComponent<Belt>();
        belt.from = from;
        belt.to = to;
        belt.speed = 1;
        belt.output = resourceTaker;

        return belt;
    }
}
