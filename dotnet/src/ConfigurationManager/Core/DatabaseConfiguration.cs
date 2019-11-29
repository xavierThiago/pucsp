using System;
using Newtonsoft.Json;

namespace PucSp.DesignPatterns.ConfigurationManager.Core
{
    public class DatabaseConfiguration : IDatabaseConfiguration
    {
        [JsonProperty("host")]
        public string Host { get; }

        [JsonProperty("port")]
        public int Port { get; }

        [JsonProperty("user")]
        public string User { get; }

        [JsonProperty("password")]
        public string Password { get; }

        [JsonProperty("database")]
        public string Database { get; }

        public DatabaseConfiguration(string host, int port, string user, string password, string database)
        {
            if (host == null)
            {
                throw new ArgumentNullException(nameof(host));
            }

            if (port <= 0)
            {
                throw new ArgumentException("Port number is not valid.", nameof(port));
            }

            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }

            if (database == null)
            {
                throw new ArgumentNullException(nameof(database));
            }

            this.Host = host;
            this.Port = port;
            this.User = user;
            this.Password = password;
            this.Database = database;
        }

        public string ToJson() => JsonConvert.SerializeObject(this);
    }
}
