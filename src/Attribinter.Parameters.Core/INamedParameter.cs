namespace Attribinter.Parameters;

/// <summary>Represents a named parameter.</summary>
public interface INamedParameter
{
    /// <summary>The name of the named parameter.</summary>
    public abstract string Name { get; }
}
