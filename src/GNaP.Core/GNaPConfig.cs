namespace GNaP.Core
{
    using System;
    using DependencyInjection;

    public interface IGNaPConfig : IFluentInterface
    {
        IAppConfigurator UseContainer(Func<IContainerAdapter> createContainerFunc);
    }

    public class GNaPConfig : IGNaPConfig
    {
        internal IContainerAdapter ContainerAdapter { get; private set; }

        public IAppConfigurator UseContainer(Func<IContainerAdapter> createContainerFunc)
        {
            ContainerAdapter = createContainerFunc();

            return new AppConfigurator();
        }

        internal GNaPConfig()
        {
        }
    }
}