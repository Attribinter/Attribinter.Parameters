namespace Attribinter.Parameters.ConstructorParameterFactoryCases;

using Microsoft.CodeAnalysis;

using Moq;

using System;

using Xunit;

public sealed class Create
{
    private IConstructorParameter Target(IParameterSymbol symbol) => Target(Context.Factory, symbol);
    private static IConstructorParameter Target(IConstructorParameterFactory factory, IParameterSymbol symbol) => factory.Create(symbol);

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
        var symbol = Mock.Of<IParameterSymbol>();

        var result = Target(symbol);

        Assert.Same(symbol, result.Symbol);
    }
}
