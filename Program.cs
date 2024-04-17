using Microsoft.AspNetCore.OData;
using Microsoft.OData.ModelBuilder;
using ODataExpandFilter;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddControllers()
    .AddOData(o =>
    {
        var b = new ODataConventionModelBuilder();
        b.EntitySet<Product>("products");
        b.EntityType<ProductType>();
        b.EntityType<ProductCategory>();
            
        o.AddRouteComponents(b.GetEdmModel());
        o.Expand().Filter();
    });

var app = builder.Build();
app.UseODataRouteDebug();
app.MapControllers();
app.Run();


