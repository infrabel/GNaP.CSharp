namespace GNaP.DependencyInjection
{
    using System;

    public static class ContainerAdapterExtensions
    {
        public static void Add<TServiceType, TImplementationType>(this IContainerAdapter container)
        {
            container.Add(typeof(TServiceType), typeof(TImplementationType));
        }

        public static void Add(this IContainerAdapter container, Type serviceType)
        {
            container.Add(serviceType, serviceType);
        }

        public static void AddSingleton<TServiceType, TImplementationType>(this IContainerAdapter container)
        {
            container.AddSingleton(typeof(TServiceType), typeof(TImplementationType));
        }

        public static void AddSingleton(this IContainerAdapter container, Type serviceType)
        {
            container.AddSingleton(serviceType, serviceType);
        }

        public static void AddInstance<TServiceType>(this IContainerAdapter container, object implementation)
        {
            container.AddInstance(typeof(TServiceType), implementation);   
        }
    }
}
