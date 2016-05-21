using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {

    public GameObject toSpawn;
    public int cooldown = 10;
    private float spawntime;

    public void spawn()
    {
        GameObject.Instantiate(toSpawn, transform.position, transform.rotation);
    }

    private void resetTimer()
    {
        spawntime = Time.time + cooldown;
    }

	// Use this for initialization
	void Start () {
        resetTimer();
	}
	
	// Update is called once per frame
	void Update () {
	    if (Time.time > spawntime)
        {
            spawn();
            resetTimer();

        }
	}
}
