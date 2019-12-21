using System;
using PucSp.DesignPatterns.ConfigurationManager.Core;

namespace PucSp.DesignPatterns.ConfigurationManager.Infrastructure
{
    public static class ConfigurationFactory
    {
        public static IDatabaseConfiguration Create(ConfigurationType type)
        {
            if (type == ConfigurationType.None)
            {
                throw new InvalidOperationException("Provider not supported.");
            }

            IConfigurationProvider provider;

            switch (type)
            {
                case ConfigurationType.JsonFile:
                    {
                        provider = new JsonFileConfigurationProvider();

                        return provider.Read();
                    }
                case ConfigurationType.Queue:
                    {
                        provider = new QueueConfigurationProvider();

                        return provider.Read();
                    }
                case ConfigurationType.Environment:
                default:
                    {
                        provider = new EnvironmentConfigurationProvider();

                        return provider.Read();
                    }
            }
        }
    }
}
