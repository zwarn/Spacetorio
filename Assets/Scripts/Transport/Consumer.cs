using UnityEngine;
using System;

/// <summary>
/// A generic consumer that offers a <see cref="onConsume"/> 
/// <see cref="Action"/>.
/// </summary>
public abstract class Consumer : MonoBehaviour, ResourceTaker {

    /// <summary>
    /// The <see cref="Action"/> that is called when
    /// <see cref="Take(Resource)"/> is called.
    /// </summary>
    public Action<Resource> onConsume;    

    /// <summary>
    /// Always returns <c>true</c>. Should be overridden
    /// by child classes.
    /// </summary>
    public virtual bool Accepts(Resource resource) {
        return true;
    }

    /// <summary>
    /// Calls <see cref="onConsume"/> with the given
    /// <see cref="Resource"/>. Afterwards destroys
    /// it by calling 
    /// <see cref="UnityEngine.Object.Destroy(UnityEngine.Object)"/>.
    /// <param name="resource">The given resource.</param>
    /// </summary>
    public virtual void Take(Resource resource)
    {
        onConsume(resource);
        Destroy(resource);
    }
    
}
