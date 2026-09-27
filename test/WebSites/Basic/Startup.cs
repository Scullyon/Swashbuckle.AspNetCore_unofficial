using System.Globalization;
using System.Reflection;
using Basic.Swagger;
using Microsoft.AspNetCore.Localization;
using Microsoft.OpenApi;

namespace Basic;

public class Startup : StartupBase
{

    public override void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        base.Configure(app, env);
        app.UseSwaggerUI(c =>
        {
            c.RoutePrefix = ""; // serve the UI at root
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "V1 Docs");
        });
    }
}
