using Microsoft.Extensions.Configuration;
using System.IO;

namespace AppForms.Infrastructure.Shared.Utilities
{
    public class ConfigurationService
    {
        private static IConfiguration _configuration = null;
        public static void SetConfiguration(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public static IConfiguration Configuration
        {
            get
            {
                if (_configuration == null)
                {
                    var builder = new ConfigurationBuilder();
                    _configuration = builder.Build();
                }
                return _configuration;
            }
        }

        public static string Get(string path)
        {
            var x = Configuration[path];
            return x;
        }

        public static string SqlDataConnection
        {
            get
            {
                return Configuration.GetConnectionString("AdPoc");
            }
        }

        public static string BlobStorageConnection
        {
            get
            {
                return Configuration.GetConnectionString("AzureBlobStorageAccount");
            }
        }
    }
}
