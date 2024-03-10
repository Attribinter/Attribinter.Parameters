namespace Attribinter.Parameters;

using System;

/// <inheritdoc cref="INamedParameterFactory"/>
public sealed class NamedParameterFactory : INamedParameterFactory
{
    /// <summary>Instantiates a <see cref="NamedParameterFactory"/>, handling creation of <see cref="INamedParameter"/>.</summary>
    public NamedParameterFactory() { }

    INamedParameter INamedParameterFactory.Create(string name)
    {
        if (name is null)
        {
            throw new ArgumentNullException(nameof(name));
        }

        return new NamedParameter(name);
    }

    private sealed class NamedParameter : INamedParameter
    {
        private readonly string Name;

        public NamedParameter(string name)
        {
            Name = name;
        }

        string INamedParameter.Name => Name;
    }
}
