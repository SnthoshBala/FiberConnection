using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiberConnection.Data;
using FiberConnection.FiberConnection;
using FiberConnection.Repository;
using FiberConnection.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace FiberConnection
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
            services.AddScoped<IFiberPlan<FiberPlan>,FiberPlan>();
            services.AddScoped<IFiberPlanRepo<FiberPlan>,FiberPlanRepo>();
            services.AddScoped<IFiberPlanServ<FiberPlan>,FiberPlanServ>();

            services.AddScoped<IBilling<Billing>, Billing>();
            services.AddScoped <IBillingRepo<Billing>, BillingRepo>();
            services.AddScoped<IBillingServ<Billing>, BillingServ>();

            services.AddScoped<ICustomer<Customer>, Customer>();
            services.AddScoped<ICustomerRepo<Customer>, CustomerRepo>();
            services.AddScoped<ICustomerServ<Customer>, CustomerServ>();

            services.AddScoped<IOffer<Offer>, Offer>();
            services.AddScoped<IOfferRepo<Offer>, OfferRepo>();
            services.AddScoped<IOfferServ<Offer>, OfferServ>();

            services.AddScoped<IStatus<Status>,Status>();
            services.AddScoped<IStatusRepo<Status>,StatusRepo>();
            services.AddScoped<IStatusServ<Status>,StatusServ>();

            services.AddScoped<IAdmin<Admin>, Admin>();
            services.AddScoped<IAdminRepo<Admin>, AdminRepo>();
            services.AddScoped<IAdminServ<Admin>, AdminServ>();

            services.AddScoped<IEmployee<Employee>, Employee>();
            services.AddScoped<IEmployeeRepo<Employee>, EmployeeRepo>();
            services.AddScoped<IEmployeeServ<Employee>, EmployeeServ>();

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddControllersWithViews();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            loggerFactory.AddLog4Net();
            app.UseRouting();

            app.UseSession();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Fiber}/{action=PlanDetails}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
