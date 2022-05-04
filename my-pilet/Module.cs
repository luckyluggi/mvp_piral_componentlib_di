using component_lib;
using Microsoft.Extensions.DependencyInjection;

public class Module
{
    public static void Main()
    {
        // this entrypoint should remain empty 
    }

    public static void ConfigureServices(IServiceCollection services)
    {
        // configure dependency injection here
        services.AddComponentLibServices();
    }
    
    public static void ConfigureShared(IServiceCollection services)
    {
        // configure dependency injection here
        // services.AddComponentLibServices();
    }
}  