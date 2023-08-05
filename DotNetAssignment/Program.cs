using DotNetAssignment.Areas.Identity.Data;
using DotNetAssignment.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ??
    throw new InvalidOperationException("Connection string 'DotNetAssignmentContextConnection' not found.");

builder.Services.AddDbContext<DotNetAssignmentContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddIdentity<DotNetAssignmentUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<DotNetAssignmentContext>()
    .AddDefaultUI()
    .AddDefaultTokenProviders();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllers();
app.MapRazorPages();

app.Run();
