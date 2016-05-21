using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Consumer : MonoBehaviour {

    public List<string> labelsToConsume;
    public Action onConsume;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (labelsToConsume.Contains(other.gameObject.tag))
        {
            Destroy(other.gameObject);
            onConsume();
        }
    }

    // Use this for initialization
    void Start () {
        onConsume = () => Debug.Log("consumed");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
