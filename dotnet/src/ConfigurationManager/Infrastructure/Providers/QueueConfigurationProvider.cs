using PucSp.DesignPatterns.ConfigurationManager.Core;

namespace PucSp.DesignPatterns.ConfigurationManager.Infrastructure
{
    public class QueueConfigurationProvider : IConfigurationProvider
    {
        public IDatabaseConfiguration Read()
        {
            return new DatabaseConfiguration("queue-host", 2, "queue-user", "queue123", "interesting-database");
        }
    }
}
