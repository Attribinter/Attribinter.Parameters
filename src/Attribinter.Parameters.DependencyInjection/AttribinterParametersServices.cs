namespace Attribinter.Parameters;

using Microsoft.Extensions.DependencyInjection;

using System;

/// <summary>Allows the services of <i>Attribinter.Parameters</i> to be registered with <see cref="IServiceCollection"/>.</summary>
public static class AttribinterParametersServices
{
    /// <summary>Registers the services of <i>Attribinter.Parameters</i> with the provided <see cref="IServiceCollection"/>.</summary>
    /// <param name="services">The <see cref="IServiceCollection"/> with which services are registered.</param>
    /// <returns>The provided <see cref="IServiceCollection"/>, so that calls can be chained.</returns>
    public static IServiceCollection AddAttribinterParameters(this IServiceCollection services)
    {
        if (services is null)
        {
            throw new ArgumentNullException(nameof(services));
        }

        services.AddSingleton<ITypeParameterFactory, TypeParameterFactory>();
        services.AddSingleton<IConstructorParameterFactory, ConstructorParameterFactory>();
        services.AddSingleton<INamedParameterFactory, NamedParameterFactory>();

        return services;
    }
}
