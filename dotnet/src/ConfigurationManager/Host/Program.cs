using System;
using PucSp.DesignPatterns.ConfigurationManager.Core;

namespace PucSp.DesignPatterns.ConfigurationManager.Host
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var configuration = DatabaseSettings.Instance;

            Console.WriteLine(configuration.ToJson());
        }
    }
}
