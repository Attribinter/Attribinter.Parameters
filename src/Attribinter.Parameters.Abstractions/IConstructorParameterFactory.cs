namespace Attribinter.Parameters;

using Microsoft.CodeAnalysis;

/// <summary>Handles creation of <see cref="IConstructorParameter"/>.</summary>
public interface IConstructorParameterFactory
{
    /// <summary>Creates a <see cref="IConstructorParameter"/>, representing a constructor parameter.</summary>
    /// <param name="symbol">The symbol associated with the constructor parameter.</param>
    /// <returns>The created <see cref="IConstructorParameter"/>.</returns>
    public abstract IConstructorParameter Create(IParameterSymbol symbol);
}
