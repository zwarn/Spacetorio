using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class Consumer : MonoBehaviour, ResourceTaker {

    public List<String> acceptableTags;
    public Action<Resource> onConsume;

    public bool Accepts(Resource resource)
    {
        return acceptableTags.Contains(resource.gameObject.tag);
    }

    public void Take(Resource resource)
    {
        if (!Accepts(resource)) throw new Exception("doesn't accept given resource");
        onConsume(resource);
        Destroy(resource);
    }
    
}
