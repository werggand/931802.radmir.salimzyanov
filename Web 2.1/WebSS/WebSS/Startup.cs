using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using WebSS.Services;


namespace WebSS
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();  // добавляем сервисы MVC
            services.AddTransient<Pass>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting(); // используем систему маршрутизации
            app.UseStaticFiles();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
