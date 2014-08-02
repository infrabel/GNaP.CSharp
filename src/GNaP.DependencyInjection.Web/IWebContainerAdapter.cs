namespace GNaP.DependencyInjection.Web
{
    using System;
    using DependencyInjection;

    public interface IWebContainerAdapter : IContainerAdapter
    {
        void AddScoped(Type serviceType, Type implementationType);
    }
}