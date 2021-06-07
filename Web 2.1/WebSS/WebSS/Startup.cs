using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using WebSS.Services;


namespace WebSS
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();  // ��������� ������� MVC
            services.AddTransient<Pass>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting(); // ���������� ������� �������������
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
