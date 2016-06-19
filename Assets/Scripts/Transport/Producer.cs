using UnityEngine;
using System.Collections;

public class Producer : MonoBehaviour {

    public ResourceTaker output;
    public float cooldown = 1;
    public Resource resourceTemplate;
    private float timeToSpawn;
    private Resource resource;

	// Use this for initialization
	void Start () {
        timeToSpawn = Time.time + cooldown;
	}
	
	// Update is called once per frame
	void Update () {
	    if (resource == null && Time.time > timeToSpawn)
        {
            Resource newResource = (Resource) Instantiate(resourceTemplate, transform.position, transform.rotation);
            //Resource newResource = gameObject.GetComponent<Resource>();
            if (newResource == null) throw new System.Exception("newly created Resource isen't a resource");
            resource = newResource;
        }

        if (resource != null && output != null && output.Accepts(resource))
        {
            output.Take(resource);
            resource = null;
            timeToSpawn = Time.time + cooldown;
        }

	}
}
