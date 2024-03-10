namespace Attribinter.Parameters;

using Microsoft.CodeAnalysis;

/// <summary>Represents a constructor parameter.</summary>
public interface IConstructorParameter
{
    /// <summary>The symbol associated with the constructor parameter.</summary>
    public abstract IParameterSymbol Symbol { get; }
}
