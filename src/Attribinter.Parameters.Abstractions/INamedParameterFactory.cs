namespace Attribinter.Parameters;

/// <summary>Handles creation of <see cref="INamedParameter"/>.</summary>
public interface INamedParameterFactory
{
    /// <summary>Creates a <see cref="INamedParameter"/>, representing a named parameter.</summary>
    /// <param name="name">The name of the named parameter.</param>
    /// <returns>The created <see cref="INamedParameter"/>.</returns>
    public abstract INamedParameter Create(string name);
}
