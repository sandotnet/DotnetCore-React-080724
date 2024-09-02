using Ocelot.DependencyInjection;
using Ocelot.Middleware;

namespace ECommGateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);
            builder.Services.AddOcelot(builder.Configuration); //Register Ocelot to DI
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");
            app.UseOcelot(); //configure Ocelot middleware to the project
            app.Run();
        }
    }
}
