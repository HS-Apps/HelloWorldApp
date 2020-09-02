using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using HelloWorldMessage.Services;

namespace HelloWorldMessage
{

    class Program
    {        
        static void Main(string[] args)
        {         
            ServiceProvider serviceProvider = RegisterServices();

            var message_destination = serviceProvider.GetService<IWriteService>();

            var config = serviceProvider.GetService<IConfigService>();

            string message = GetMessage(config.MessageApiUri);

            message_destination.WriteMessage(message);
        }

        private static ServiceProvider RegisterServices()
        {      
            
            return new ServiceCollection()
                .AddTransient<IWriteService, WriteService>()
                .AddTransient<IConfigService, ConfigService>()
                .BuildServiceProvider();
        }

        private static string GetMessage(string api_uri)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();

            string message = client.GetStringAsync(new Uri(api_uri)).Result;
            return message;
        }

    }
}
