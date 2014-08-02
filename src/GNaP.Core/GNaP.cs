namespace GNaP.Core
{
    using System;
    using DependencyInjection;

    public class GNaP
    {
        private static GNaPConfig _config;

        public static IGNaPConfig Config
        {
            get { return _config ?? (_config = new GNaPConfig()); }
        }

        public static IContainerAdapter Container
        {
            get
            {
                if (_config == null || _config.ContainerAdapter == null)
                    throw new InvalidOperationException("Call Config.UseContainer() first.");
                
                return _config.ContainerAdapter;
            }
        }

        protected GNaP()
        {
        }
    }
}