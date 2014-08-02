namespace GNaP.DependencyInjection
{
    using System;
    using Microsoft.Practices.ServiceLocation;

    /// <summary>
    /// Interface which extends the microsoft service locator interface with extra bind methods.
    /// </summary>
    public interface IContainerAdapter : IServiceLocator
    {
        // TODO: Add key later

        /// <summary>
        /// Binds 1 type to another.
        /// A new instance is created every time
        /// </summary>
        /// <param name="serviceType">Type which will be requested from the container</param>
        /// <param name="implementationType">Type which the container will supply</param>
        void Add(Type serviceType, Type implementationType);
        
        /// <summary>
        /// Binds an instance to a type
        /// A single instance is created and it acts like a singleton
        /// </summary>
        /// <param name="serviceType">Type which will be requested from the container</param>
        /// <param name="implementationType">The instance the container will return</param>
        void AddSingleton(Type serviceType, Type implementationType);

        /// <summary>
        /// Binds an instance to a type
        /// A specific instance is given all the time. You are responsible for its initial creation
        /// </summary>
        /// <param name="serviceType">Type which will be requested from the container</param>
        /// <param name="implementation">The instance the container will return</param>
        void AddInstance(Type serviceType, object implementation);
    }
}
