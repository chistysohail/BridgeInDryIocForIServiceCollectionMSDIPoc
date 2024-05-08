using DryIoc;
using DryIoc.Microsoft.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Step A: Create a new instance of ServiceCollection
        var services = new ServiceCollection();

        // Step B: Add any services using the Microsoft DI framework
        services.AddTransient<ISomeService, SomeService>();  // Example service

        // Step C: Create a DryIoc container and integrate with IServiceCollection
        var container = new Container()
            .WithDependencyInjectionAdapter(services);

        // Step D: Register any additional services directly with DryIoc if needed
        container.Register<IOtherService, OtherService>(Reuse.Singleton);

        // Step E: Resolve services and use them
        var someService = container.Resolve<ISomeService>();
        someService.DoSomething();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

public interface ISomeService
{
    void DoSomething();
}

public class SomeService : ISomeService
{
    public void DoSomething()
    {
        Console.WriteLine("SomeService is doing something.");
    }
}

public interface IOtherService
{
    void PerformAction();
}

public class OtherService : IOtherService
{
    public void PerformAction()
    {
        Console.WriteLine("OtherService is performing an action.");
    }
}
