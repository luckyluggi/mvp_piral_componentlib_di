using component_lib;
using Microsoft.Extensions.DependencyInjection;

public class Module{
    public static void ConfigureShared(IServiceCollection services){
        services.AddComponentLibServices();
    }
} 