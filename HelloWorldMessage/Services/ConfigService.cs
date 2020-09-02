using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace HelloWorldMessage
{


    class ConfigService : IConfigService
    {
        private IConfiguration _config;
        public ConfigService()
        {
            _config = LoadConfiguration();
        }

        public string MessageApiUri
        {
            get => _config ["api:message_uri"];
        }
        

        private IConfiguration LoadConfiguration()
        {
            var builder = new ConfigurationBuilder()
                           .AddJsonFile("appsettings.json", true, true)
                           .Build();

            return builder;
        }

    }
}
