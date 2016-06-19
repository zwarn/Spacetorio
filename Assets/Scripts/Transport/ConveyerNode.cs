using UnityEngine;
using System;

/// <summary>
/// A node on a conveyor belt.
/// </summary>
public class ConveyerNode : ResourceTaker {

    /// <summary>
    /// The starting position of the cargo.
    /// </summary>
    public Vector3 from;
    
    /// <summary>
    /// The final position of the cargo before
    /// it is handed over to the output.
    /// </summary>
    public Vector3 to;

    /// <summary>
    /// The output that will take the cargo
    /// when the progress reaches one.
    /// </summary>
    public ResourceTaker output;

    /// <summary>
    /// The speed with which the cargo moves
    /// over the conveyer belt.
    /// </summary>
    public float speed;

    private Resource cargo;
    private float progress;

    /// <summary>
    /// Returns <c>true</c> iff the current <see cref="cargo"/> is null, regardless
    /// of the given resource.
    /// </summary>
    public bool Accepts(Resource resource)
    {
        return cargo == null;
    }

    /// <summary>
    /// Puts the given resource onto the conveyor belt. Sets
    /// the <see cref="progress"/> to zero to indicate that
    /// the resource is at the beginning of its journey over
    /// this belt. Calls <see cref="SetPosition()"/> afterwards.
    /// </summary>
    public void Take(Resource resource)
    {
        if (cargo != null) throw new Exception("Pushed resource to nonempty belt.");
        cargo = resource;
        progress = 0;
        SetPosition();
    }

    /// <summary>
    /// Iff cargo is not null, its progress is
    /// computed with regard to the given <see cref="speed"/>.
    /// Iff the <see cref="progress"/> is greater or equal
    /// one the cargo will be handed to the registered 
    /// <see cref="output"/>. Iff there is no <see cref="output"/>
    /// or it does not accept the cargo nothing happens until
    /// this state of affair changes. <see cref="SetPosition"/>
    /// is called afterwards.
    /// </summary>
    public void Update()
    {
        if (cargo == null) return;

        progress += speed * Time.deltaTime;
        if (progress >= 1)
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
        SetPosition();
    }

    /// <summary>
    /// Moves the <see cref="cargo"/> to a position given by 
    /// <see cref="from"/>, <see cref="to"/> and the current
    /// <see cref="progress"/> by setting its <see cref="GameObject"/>s 
    /// <see cref="Transform.position"/>.
    /// </summary>
    private void SetPosition()
    {
        if (cargo != null)
        {
            cargo.gameObject.transform.position = Vector3.Lerp(from, to, progress);
        }
    }
}
