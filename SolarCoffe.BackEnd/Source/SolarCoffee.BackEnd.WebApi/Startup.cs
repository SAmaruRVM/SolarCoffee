namespace SolarCoffee.BackEnd.WebApi;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddDbContext<SolarCoffeeContext>();
    }

    
    public void Configure(IApplicationBuilder app)
    {
        app.UseDeveloperExceptionPage();
        app.UseRouting();

        app.UseEndpoints(endpoints => endpoints.MapControllers());
    }
}
