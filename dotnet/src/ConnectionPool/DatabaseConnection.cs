using Moq;
using System;
using System.Data;

namespace PucSp.DesignPatterns.DatabasePool
{
    public class DatabaseConnection
    {
        public IDataReader Execute(string sql)
        {
            if (sql == null)
            {
                throw new ArgumentNullException(nameof(sql));
            }

            if (sql.Length == 0)
            {
                return null;
            }

            return Mock.Of<IDataReader>();
        }
    }
}
