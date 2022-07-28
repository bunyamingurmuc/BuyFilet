using AutoMapper;
using Buyfilet.BLL.DependencyResolvers;
using Buyfilet.BLL.Helpers;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddDependencies(builder.Configuration);
builder.Services.AddControllersWithViews();

var profiles = ProfileHelper.GetPorfiles();
var mapperConfiguration = new MapperConfiguration(opt =>
{
    opt.AddProfiles(profiles);
});
var mapper = mapperConfiguration.CreateMapper();
builder.Services.AddSingleton(mapper);


var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Shop}/{action=Product}/{id=2}"
    );
});
app.MapRazorPages();
app.Run();
