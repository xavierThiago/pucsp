using PucSp.DesignPatterns.ConfigurationManager.Core;

namespace PucSp.DesignPatterns.ConfigurationManager.Infrastructure
{
    public interface IConfigurationProvider
    {
        IDatabaseConfiguration Read();
    }
}
