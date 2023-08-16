// See https://aka.ms/new-console-template for more information
using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;
using Migration.Factory;
using System;
using System.Reflection;

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Migration Starting");
Console.WriteLine("------------------------------------------------------------");
Console.ResetColor();

var serviceProvider = CreateServices();
using (var scope = serviceProvider.CreateScope())
{
    UpdateDatabase(scope.ServiceProvider);
}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Migration Completed!");
Console.ResetColor();

static ServiceProvider CreateServices()
{
    return new ServiceCollection()

        // Add common FluentMigrator services
        .AddFluentMigratorCore()
        .ConfigureRunner(rb => rb
            // Add SQLite support to FluentMigrator
            .AddSqlServer()
            // Set the connection string
            .WithGlobalConnectionString((sp) =>
            {
                var connectionstringFactory = sp.GetService<IConnectionStringFactory>();
                return connectionstringFactory.GetConnectionString();
            })
            
            .ScanIn(Assembly.GetExecutingAssembly()).For.All())
        // Enable logging to console in the FluentMigrator way
        .AddLogging(lb => lb.AddFluentMigratorConsole())
        .AddSingleton<IConnectionStringFactory, ConnectionStringFactory>()
        // Build the service provider
        .BuildServiceProvider(false);
}
/// <summary>
/// Update the database
/// </summary>
static void UpdateDatabase(IServiceProvider serviceProvider)
{
    // Instantiate the runner
    var runner = serviceProvider.GetRequiredService<IMigrationRunner>();
    if (runner.HasMigrationsToApplyUp())
    {
        runner.ListMigrations();

        runner.MigrateUp();     // Execute the migrations
    }
    //runner.MigrateDown(20230801033000);


}