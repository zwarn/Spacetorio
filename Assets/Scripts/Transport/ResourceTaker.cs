/// <summary>
/// A simple interface describing a component
/// that takes a resource.
/// </summary>
public interface ResourceTaker
{
    /// <summary>
    /// Checks if the given resource should be accepted.
    /// </summary>
    /// <param name="resource">The resource to check.</param>
    /// <returns><c>true</c> iff the resource will be accepted by
    /// this component, <c>false</c> else.</returns>
    bool Accepts(Resource resource);

    /// <summary>
    /// Takes the given resource.
    /// </summary>
    void Take(Resource resource);
}
