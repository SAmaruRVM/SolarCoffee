namespace SolarCoffee.BackEnd.WebApi;

public class Startup
{
    public void Configure(IApplicationBuilder app)
    {
        app.UseDeveloperExceptionPage();
        app.UseRouting();

        app.UseEndpoints(endpoints => endpoints.MapControllers());
    }
}
