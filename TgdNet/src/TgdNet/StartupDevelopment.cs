namespace TgdNet
{
    using Microsoft.AspNet.Builder;
    using Microsoft.AspNet.Hosting;
    using Microsoft.Framework.Configuration;
    using Microsoft.Framework.DependencyInjection;
    using Microsoft.Dnx.Runtime;

    public class StartupDevelopment
    {
        public StartupDevelopment(IHostingEnvironment env, IApplicationEnvironment appEnv)
        {
            var configuration = new ConfigurationBuilder();
            configuration.SetBasePath(appEnv.ApplicationBasePath)
                .AddJsonFile("config.json", false)
                .AddEnvironmentVariables();
            this.Configuration = configuration.Build();
        }
        public IConfiguration Configuration { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {

        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseWelcomePage();
        }
    }
}
