using System;

namespace PucSp.DesignPatterns.DatabasePool
{
    public class ConnectionBuilder : IConnectionBuilder
    {
        private IDatabaseConfiguration _configuration;
        private DatabaseConnection _connection;

        public ConnectionBuilder()
        { }

        public IConnectionBuilder AddConfiguration(IDatabaseConfiguration configuration)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }

            this._configuration = configuration;

            Console.WriteLine("Database configuration added.");

            return this;
        }

        public IConnectionBuilder AddProvider(DatabaseType type)
        {
            if (type == DatabaseType.None)
            {
                throw new ArgumentException("Invalid database type.", nameof(type));
            }

            this._connection = new DatabaseConnection();

            Console.WriteLine("Database provider added.");

            return this;
        }

        public IConnectionBuilder AddVerification()
        {
            if (this._connection == null)
            {
                throw new InvalidOperationException("Can not ping an invalid connection.");
            }

            Console.WriteLine("Initializing connection test...");
            Console.WriteLine("Done.");

            return this;
        }

        public DatabaseConnection Build()
        {
            if (this._configuration == null)
            {
                throw new InvalidOperationException("Can not create connection without any configuration.");
            }

            return this._connection;
        }
    }
}
