namespace Attribinter.Parameters;

using Microsoft.CodeAnalysis;

using System;

/// <inheritdoc cref="IConstructorParameterFactory"/>
public sealed class ConstructorParameterFactory : IConstructorParameterFactory
{
    /// <summary>Instantiates a <see cref="ConstructorParameterFactory"/>, handling creation of <see cref="IConstructorParameter"/>.</summary>
    public ConstructorParameterFactory() { }

    IConstructorParameter IConstructorParameterFactory.Create(IParameterSymbol symbol)
    {
        if (symbol is null)
        {
            throw new ArgumentNullException(nameof(symbol));
        }

        return new ConstructorParameter(symbol);
    }

    private sealed class ConstructorParameter : IConstructorParameter
    {
        private readonly IParameterSymbol Symbol;

        public ConstructorParameter(IParameterSymbol symbol)
        {
            Symbol = symbol;
        }

        IParameterSymbol IConstructorParameter.Symbol => Symbol;
    }
}
