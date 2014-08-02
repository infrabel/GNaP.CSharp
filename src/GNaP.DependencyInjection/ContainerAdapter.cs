namespace GNaP.DependencyInjection
{
    using System;
    using Microsoft.Practices.ServiceLocation;

    public abstract class ContainerAdapter : ServiceLocatorImplBase, IContainerAdapter
    {
        public abstract void Add(Type serviceType, Type implementationType);
        public abstract void AddSingleton(Type serviceType, Type implementationType);
        public abstract void AddInstance(Type serviceType, object implementation);
    }
}