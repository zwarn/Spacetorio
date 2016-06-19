using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// A sample implementation of a conveyor belt.
/// </summary>
public class Belt : MonoBehaviour, ResourceTaker {

    private Resource cargo;
    private float progress;
    public Vector3 from;
    public Vector3 to;
    public ResourceTaker output;
    public float speed;

    public bool Accepts(Resource resource)
    {
        return cargo == null;
    }

    public void Take(Resource resource)
    {
        if (cargo != null) throw new Exception("Pushed resource to nonempty belt.");
        cargo = resource;
        progress = 0;
        setPosition();
    }

    void Update()
    {
        if (cargo == null) return;

        progress += speed * Time.deltaTime;
        if (progress > 1)
        {
            progress = 1;
            if (output != null && output.Accepts(cargo))
            {
                output.Take(cargo);
                cargo = null;
                progress = 0;
                return;
            }
        }
        setPosition();
    }

    private void setPosition()
    {
        if (cargo != null)
        {
            cargo.gameObject.transform.position = Vector3.Lerp(from, to, progress);
        }
    }
}
