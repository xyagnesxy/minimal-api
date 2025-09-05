using MinimalApi;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;


CreateHostBuilder(args).Build().Run();
public partial class Program
{ 
    

    public static IHostBuilder CreateHostBuilder(string[] args) {
        return Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });

    }
    

}

