//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//int x,
//    y;


//Console.WriteLine();

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RobotOnMarsDemo;

public static class Program
{
    static void Main(string[] args)
    {
        var host = CreateHostBuilder(args).Build();
        Console.WriteLine("Set plateau dimensions.");
        var platform = new Platform();
        Console.Write("insert x: ");
        platform.X = Convert.ToInt32(Console.ReadLine());
        Console.Write("insert y: ");
        platform.Y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("insert path");
        string? path = Console.ReadLine();
        
        var robot = new Robot();
        host.Services.GetService<IMakeMovement>()?.Walk(platform,robot,path);
        Console.WriteLine($"{robot.Position.X},{robot.Position.Y},{robot.Facing}");
    }

    private static IHostBuilder CreateHostBuilder(string[] args)
    {
        var hostBuilder = Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((context, builder) =>
            {
                builder.SetBasePath(Directory.GetCurrentDirectory());
            })
            .ConfigureServices((context, services) =>
            {
                services.AddSingleton<IMakeMovement, MakeMovement>();
            });

        return hostBuilder;
    }
}


