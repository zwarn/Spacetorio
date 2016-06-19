using UnityEngine;

/// <summary>
/// A component that creates copies of the
/// given <see cref="resourceTemplate"/> and
/// hands it to the defined <see cref="output"/>.
/// </summary>
public class Producer : MonoBehaviour {

    /// <summary>
    /// The output the spawned <see cref="Resource"/> 
    /// is handed to.
    /// </summary>
    public ResourceTaker output;

    /// <summary>
    /// The time (in seconds) it takes until
    /// a new resource is created from the
    /// <see cref="resourceTemplate"/>.
    /// </summary>
    public float cooldown = 1;

    /// <summary>
    /// The <see cref="Resource"/> that is used
    /// as template to create more instances from.
    /// </summary>
    public Resource resourceTemplate;

    private float timeToSpawn;
    private Resource resource;

	/// <summary>
    /// Initializes the next <see cref="timeToSpawn"/> to
    /// the current <see cref="Time.time"/> plus 
    /// <see cref="cooldown"/>.
    /// </summary>
	void Start () {
        timeToSpawn = Time.time + cooldown;
	}
	
	/// <summary>
    /// Creates a new <see cref="Resource"/> iff
    /// the current <see cref="resource"/> is null and
    /// the current <see cref="Time.time"/> is greater
    /// or equal to the <see cref="timeToSpawn"/>. Afterwards
    /// it is handed to the <see cref="output"/>.
    /// </summary>
	void Update () {
	    if (resource == null && Time.time > timeToSpawn)
        {
            resource = (Resource) Instantiate(resourceTemplate, transform.position, transform.rotation);
        }

        if (resource != null && output != null && output.Accepts(resource))
        {
            output.Take(resource);
            resource = null;
            timeToSpawn = Time.time + cooldown;
        }

	}
}
