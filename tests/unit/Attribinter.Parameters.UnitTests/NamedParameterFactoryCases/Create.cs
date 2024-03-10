namespace Attribinter.Parameters.NamedParameterFactoryCases;

using System;

using Xunit;

public sealed class Create
{
    private INamedParameter Target(string name) => Target(Context.Factory, name);
    private static INamedParameter Target(INamedParameterFactory factory, string name) => factory.Create(name);

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
        var name = "Foo";

        var result = Target(name);

        Assert.Same(name, result.Name);
    }
}
