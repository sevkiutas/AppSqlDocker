using Bussiness.ProductManager;
using DAL.Mapper;
using DAL.SqlDbService.Repository;
using DAL.SqlDbService.SqlDbContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<DataContext>();
builder.Services.AddSingleton<IConfiguration>(builder.Configuration);

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductManager,ProductManager>(); 
builder.Services.AddAutoMapper(typeof(Mapper).Assembly);

var app = builder.Build();

//Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}


app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=Index}/{id?}");

app.Run();
