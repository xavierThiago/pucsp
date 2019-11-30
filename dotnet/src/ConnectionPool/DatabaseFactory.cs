using System;
using System.Data;

namespace PucSp.DesignPatterns.DatabasePool
{
    public static class DatabaseFactory
    {
        public static DatabaseConnection Create(DatabaseType type)
        {
            if (type == DatabaseType.None)
            {
                throw new ArgumentException("Invalid database type.", nameof(type));
            }

            var connectionBuilder = new ConnectionBuilder();
            var connection = default(DatabaseConnection);

            switch (type)
            {
                case DatabaseType.SqlServer:
                    {
                        connection = new DatabaseConnection();

                        break;
                    }
                case DatabaseType.Postgresql:
                default:
                    {
                        connection = new DatabaseConnection();

                        break;
                    }
            }

            return connectionBuilder
                        .AddConfiguration(null)
                        .AddProvider(type)
                        .AddVerification()
                        .Build();
        }
    }
}
