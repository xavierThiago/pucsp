using System;
using System.Threading;
using PucSp.DesignPatterns.ConfigurationManager.Infrastructure;

namespace PucSp.DesignPatterns.ConfigurationManager.Core
{
    public class DatabaseSettings
    {
        // Locking mechanism to read-write database settings (when new information is fetched from queue).
        private static ReaderWriterLockSlim _lock = new ReaderWriterLockSlim();

        // Lazy struct is thread safe on initialization only.
        private static IDatabaseConfiguration _configuration;

        private DatabaseSettings()
        {
            _configuration = ConfigurationFactory.Create(ConfigurationType.Environment);
        }

        // Simplified get/set. Ideally, an event system would update the new information from the configuration queue.
        public static IDatabaseConfiguration Instance
        {
            get
            {
                _lock.EnterReadLock();

                IDatabaseConfiguration value = null;

                if (_configuration == null)
                {
                    value = ConfigurationFactory.Create(ConfigurationType.Environment);
                }

                _lock.ExitReadLock();

                return value;
            }
            set
            {
                _lock.EnterWriteLock();

                _configuration = value;

                _lock.ExitWriteLock();
            }
        }
    }
}
