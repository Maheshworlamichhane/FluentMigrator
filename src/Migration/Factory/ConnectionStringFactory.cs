using Microsoft.Extensions.Configuration;

namespace Migration.Factory
{
    public class ConnectionStringFactory : IConnectionStringFactory
    {
        private readonly string _connectionString;

        public ConnectionStringFactory()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false);
                    
                  
            IConfiguration config = builder.Build();

            _connectionString = config.GetConnectionString("DefaultConnection");

        }

        public string GetConnectionString()
        {
            return _connectionString;
        }
    }
}
