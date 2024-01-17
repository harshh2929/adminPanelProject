using adminPanelProject.Data;
using adminPanelProject.Services.EmployeeService;
using adminPanelProject.Services.LoginService;
using adminPanelProject.Services.ProductService;
using adminPanelProject.Services.SellerService;
using adminPanelProject.Services.SignupService;
using Twilio.Clients;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>();
builder.Services.AddScoped<ISellerService, SellerService>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ILoginService, LoginService>();
builder.Services.AddScoped<ISignupService, SignupService>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigin",
        builder => builder.WithOrigins("http://localhost:4200") 
                          .AllowAnyHeader()
                          .AllowAnyMethod());
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowOrigin"); // Enable CORS

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
