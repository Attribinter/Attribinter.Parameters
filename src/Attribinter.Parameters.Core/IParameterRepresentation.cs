namespace Attribinter.Parameters;

/// <summary>Represents a representation of some parameter.</summary>
/// <typeparam name="TParameter">The type of the represented parameter.</typeparam>
public interface IParameterRepresentation<in TParameter>
{
    /// <summary>Determines whether the provided parameter is the represented parameter.</summary>
    /// <param name="parameter">The parameter.</param>
    /// <returns>A <see cref="bool"/> indicating whether the provided parameter is the represented parameter.</returns>
    public abstract bool Represents(TParameter parameter);
}
