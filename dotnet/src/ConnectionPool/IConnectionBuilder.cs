namespace PucSp.DesignPatterns.DatabasePool
{
    public interface IConnectionBuilder
    {
        IConnectionBuilder AddConfiguration(IDatabaseConfiguration configuration);
        IConnectionBuilder AddProvider(DatabaseType type);
        IConnectionBuilder AddVerification();

        DatabaseConnection Build();
    }
}
