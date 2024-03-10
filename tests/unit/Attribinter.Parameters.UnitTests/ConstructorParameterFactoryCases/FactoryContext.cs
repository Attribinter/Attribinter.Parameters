namespace Attribinter.Parameters.ConstructorParameterFactoryCases;

internal sealed class FactoryContext
{
    public static FactoryContext Create()
    {
        ConstructorParameterFactory factory = new();

        return new(factory);
    }

    public ConstructorParameterFactory Factory { get; }

    private FactoryContext(ConstructorParameterFactory factory)
    {
        Factory = factory;
    }
}
