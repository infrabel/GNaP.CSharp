namespace GNaP.Core
{
    /// <summary>
    /// Marker interface to build the fluent interface on
    /// </summary>
    public interface IAppConfigurator : IFluentInterface
    {
    }

    /// <summary>
    /// Dummy class intended as a starting point for the fluent interface
    /// </summary>
    internal class AppConfigurator : IAppConfigurator
    {
    }
}
