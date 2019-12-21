using PucSp.DesignPatterns.ConfigurationManager.Core;

namespace PucSp.DesignPatterns.ConfigurationManager.Infrastructure
{
    public class EnvironmentConfigurationProvider : IConfigurationProvider
    {
        public IDatabaseConfiguration Read()
        {
            return new DatabaseConfiguration("env-host", 2, "env-user", "env123", "simple-database");
        }
    }
}
