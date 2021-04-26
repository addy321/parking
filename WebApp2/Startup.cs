using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Model;
using Service.dbimplement;
using Service.dbinterface;
using System.Data.SqlClient;

namespace WebApp2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews().AddRazorRuntimeCompilation();//��ͼ����
            services.AddRazorPages();
            services.AddMvc();//mvc
            services.AddSession();//session�洢
            services.AddSingleton<ISysUserService, SysUserService>();//�û��ӿ�ע��
            services.AddSingleton<ICwxxService, CwxxService>();//��λ�ӿ�ע��
            services.AddSingleton<ITcxxService, TcxxService>();//ͣ���ӿ�ע��
            services.Configure<ConnStr>(this.Configuration.GetSection("ConnStr"));//�������ݿ������ַ���
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=User}/{action=Login}/{id?}");
            });
        }
    }
}
