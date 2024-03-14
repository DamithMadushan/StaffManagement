using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SM.Application;
using SM.Infrastructure.Persistance.Models;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("SM",
         builder =>
         {
             builder
             .AllowAnyOrigin()
             .AllowAnyMethod()
             .AllowAnyHeader()
             .WithExposedHeaders("X-Access-Token-Expired");
             //.WithHeaders(HeaderNames.ContentType);
         });
});

var cs = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.Configure<FormOptions>(options =>
{
    options.ValueLengthLimit = int.MaxValue;
    options.MultipartBodyLengthLimit = long.MaxValue; // <-- !!! long.MaxValue
    options.MultipartBoundaryLengthLimit = int.MaxValue;
    options.MultipartHeadersCountLimit = int.MaxValue;
    options.MultipartHeadersLengthLimit = int.MaxValue;

});
builder.Services.Configure<IISServerOptions>(options =>
{
    options.MaxRequestBodySize = long.MaxValue; // or your desired value

});



// Add services to the container.
builder.Services.AddDomainServices(builder.Configuration);
builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddInfrastructureServices(builder.Configuration);
builder.Services.AddCommonServices(builder.Configuration);




builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();

builder.Services.Configure<JsonOptions>(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});
var app = builder.Build();
//app.UseMiddleware<HttpDebuggerMiddleware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("SM");
//app.UseAuthentication();

app.UseSession();

//app.UseAuthorization();

app.MapControllers();

app.Run();