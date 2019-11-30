namespace PucSp.DesignPatterns.ConfigurationManager.Core
{
    public interface IDatabaseConfiguration
    {
        string Host { get; }
        int Port { get; }
        string User { get; }
        string Password { get; }
        string Database { get; }

        string ToJson();
    }
}
