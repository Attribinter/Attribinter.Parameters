namespace Attribinter.Parameters.TypeParameterFactoryCases;

using Microsoft.CodeAnalysis;

using Moq;

using System;

using Xunit;

public sealed class Create
{
    private ITypeParameter Target(ITypeParameterSymbol symbol) => Target(Context.Factory, symbol);
    private static ITypeParameter Target(ITypeParameterFactory factory, ITypeParameterSymbol symbol) => factory.Create(symbol);

    private readonly FactoryContext Context = FactoryContext.Create();

    [Fact]
    public void NullSymbol_ThrowsArgumentNullException()
    {
        var exception = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(exception);
    }

    [Fact]
    public void ValidSymbol_ContainsSymbol()
    {
        var symbol = Mock.Of<ITypeParameterSymbol>();

        var result = Target(symbol);

        Assert.Same(symbol, result.Symbol);
    }
}
