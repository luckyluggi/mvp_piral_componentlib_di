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
        // configure (local) dependency injection here
    }
    
    public static void ConfigureShared(IServiceCollection services)
    {
        // configure (globally shared) dependency injection here
        services.AddComponentLibServices();
    }
}  