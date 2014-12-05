namespace GNaP.DependencyInjection.Web
{
    public static class WebContainerAdapterExtensions
    {
        public static void AddScoped<TServiceType, TImplementationType>(this IWebContainerAdapter container)
        {
            container.AddScoped(typeof(TServiceType), typeof(TImplementationType));
        }
    }
}
