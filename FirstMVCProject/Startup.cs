namespace FirstMVCProject;
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // Configurações de DI aqui
        services.AddControllers();
    }

    public void Configure(IApplicationBuilder app)
    {
        // Pipeline de middleware aqui
        app.UseRouting();
        app.UseEndpoints(endpoints => endpoints.MapControllers());
    }
}