Multiple DOcuments and Filters
https://github.com/domaindrivendev/Swashbuckle.AspNetCore#generate-multiple-swagger-documents
services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API - V1", Version = "v1" });
    c.SwaggerDoc("v2", new OpenApiInfo { Title = "My API - V2", Version = "v2" });
});

"/swagger/v1/swagger.json" and "/swagger/v2/swagger.json".
[HttpPost]
[ApiExplorerSettings(GroupName = "v2")]
public void Post([FromBody]Product product)


https://stackoverflow.com/a/56045085/26877
using System;
using System.Linq;
using System.Web.Http;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.Swagger;

using Microsoft.AspNetCore.Mvc.ApiExplorer;

internal class SwaggerFilterOutControllers : IDocumentFilter
{

    void IDocumentFilter.Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
    {
        foreach (var item in swaggerDoc.Paths.ToList())
        {
            if (!(item.Key.ToLower().Contains("/api/endpoint1") ||
                  item.Key.ToLower().Contains("/api/endpoint2")))
            {
                swaggerDoc.Paths.Remove(item.Key);
            }
        }

        swaggerDoc.Definitions.Remove("Model1");
        swaggerDoc.Definitions.Remove("Model2");
    }
}

services.AddSwaggerGen(c => { 
    c.SwaggerDoc("v1", new OpenApiInfo { 
        Title = "My API - V1",
        Version = "v1" 
    });
    c.SwaggerDoc("v2", new OpenApiInfo {
        Title = "My API - V2",
        Version = "v2"
    });
});