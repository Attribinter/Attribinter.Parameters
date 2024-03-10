namespace Attribinter.Parameters.TypeParameterFactoryCases;

internal sealed class FactoryContext
{
    public static FactoryContext Create()
    {
        TypeParameterFactory factory = new();

        return new(factory);
    }

    public TypeParameterFactory Factory { get; }

    private FactoryContext(TypeParameterFactory factory)
    {
        Factory = factory;
    }
}
