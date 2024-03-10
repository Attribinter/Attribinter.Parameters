namespace Attribinter.Parameters.NamedParameterFactoryCases;

internal sealed class FactoryContext
{
    public static FactoryContext Create()
    {
        NamedParameterFactory factory = new();

        return new(factory);
    }

    public NamedParameterFactory Factory { get; }

    private FactoryContext(NamedParameterFactory factory)
    {
        Factory = factory;
    }
}
