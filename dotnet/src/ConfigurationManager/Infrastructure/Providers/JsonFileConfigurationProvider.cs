using PucSp.DesignPatterns.ConfigurationManager.Core;

namespace PucSp.DesignPatterns.ConfigurationManager.Infrastructure
{
    public class JsonFileConfigurationProvider : IConfigurationProvider
    {
        public IDatabaseConfiguration Read()
        {
            return new DatabaseConfiguration("json-host", 1, "json-user", "json123", "cool-database");
        }
    }
}
