using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataModel;
using IdentityServer4.Models;
using IService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Service;
using SingleSignOnSystem.Models;

namespace SingleSignOnSystem
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        private void CheckSameSite(HttpContext httpContext, CookieOptions options)
        {
            if (options.SameSite == SameSiteMode.None)
            {
                var userAgent = httpContext.Request.Headers["User-Agent"].ToString();
                // TODO: Use your User Agent library of choice here.
                if (userAgent.Contains("Chrome"))
                {
                    options.SameSite = SameSiteMode.Unspecified;
                }
                //options.SameSite = SameSiteMode.None;
            }
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.Configure<CookiePolicyOptions>(options =>
            //{
            //    options.MinimumSameSitePolicy = SameSiteMode.Unspecified;
            //    options.OnAppendCookie = cookieContext =>
            //        CheckSameSite(cookieContext.Context, cookieContext.CookieOptions);
            //    options.OnDeleteCookie = cookieContext =>
            //        CheckSameSite(cookieContext.Context, cookieContext.CookieOptions);
            //});

            services.ConfigureNonBreakingSameSiteCookies();
            //services.AddSession();

            //services.AddIdentityServer()//Ids4����
            // .AddDeveloperSigningCredential()//��ӿ�����Աǩ��ƾ��
            // .AddInMemoryIdentityResources(Config.GetIdentityResources()) //����ڴ�apiresource
            // .AddInMemoryApiResources(Config.GetApis())
            // .AddInMemoryClients(Config.GetClients());//�������ļ���Client������Դ�ŵ��ڴ�


            // configure identity server with in-memory stores, keys, clients and scopes
            //services.AddIdentityServer()
            //    .AddDeveloperSigningCredential()
            //    .AddInMemoryApiResources(new List<ApiResource>
            //    {
            //    new ApiResource("api1", "My API")
            //    })
            //    .AddInMemoryClients(new List<Client>
            //    {
            //    // client credentials client
            //    new Client
            //    {
            //        ClientId = "client",
            //        AllowedGrantTypes = GrantTypes.ClientCredentials,

            //        ClientSecrets =
            //        {
            //            new Secret("secret".Sha256())
            //        },
            //        AllowedScopes = { "api1" }
            //    }
            //    });


            services.AddTransient<IMemberService, MemberService>();//serviceע��
            string sss = Configuration.GetConnectionString("sqlconn");
            services.AddDbContext<EFContext>(options => options.UseSqlServer(Configuration.GetConnectionString("sqlconn")));//ע��DbContext

            services.AddControllersWithViews();


            services.AddIdentityServer()//Ids4����
                .AddDeveloperSigningCredential()
                .AddInMemoryIdentityResources(Config.GetIdentityResources())
                .AddInMemoryClients(Config.GetClients(Configuration));//�������ļ���Client������Դ�ŵ��ڴ�
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseRouting();
            //app.UseAuthorization();
            //����ids4�м��
            app.UseIdentityServer();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
