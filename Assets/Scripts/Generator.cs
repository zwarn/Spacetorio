using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {

    public GameObject toSpawn;
    public int cooldown = 10;
    private float spawntime;

    public void Spawn()
    {
        GameObject.Instantiate(toSpawn, transform.position, transform.rotation);
    }

    private void ResetTimer()
    {
        spawntime = Time.time + cooldown;
    }

	// Use this for initialization
	void Start () {
        ResetTimer();
	}
	
	// Update is called once per frame
	void Update () {
	    if (Time.time > spawntime)
        {
            Spawn();
            ResetTimer();

        }
	}
}
