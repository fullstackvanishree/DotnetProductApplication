using Microsoft.Extensions.Configuration;

namespace Demo_ProductApp.Utility
{
    //Microsoft.Extensions.Configuration
    //Microsoft.Extensions.Configuration.FileExtension
    //Microst.extensions.Configuration.json
    internal static class DbConnUtil
    {
        private static IConfiguration _iconfiguration;
        //create a constructor
        static DbConnUtil()
        {
            GetAppSettingsFile();
        }

        private static void GetAppSettingsFile()
        {
            var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json");
                     _iconfiguration = builder.Build();

        }

        public static string GetConnectionString()
        {
            return _iconfiguration.GetConnectionString("LocalConnectionString");
        }
    }
}
