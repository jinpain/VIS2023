using CustomAuthentication;
using DeceasedPatientsRegistry.Data.Filters;
using DeceasedPatientsRegistry.Domain;
using DeceasedPatientsRegistry.Services.DatabaseHandlers.ExternalAPIHandlers.MedicalEconomicExaminationAPI;
using DeceasedPatientsRegistry.Services.DatabaseHandlers.Repositories;
using ForceRenderComponentLibrary;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using SignalRHubLibrary;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddServerSideBlazor().AddCircuitOptions(options => { options.DetailedErrors = true; });


// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

//auth
builder.Services.AddAuthenticationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();

// Database connect
string conStr = builder.Configuration.GetSection("ConnectionStrings").GetValue<string>("DefaultConnection");
builder.Services.AddDbContextFactory<ApplicationContext>(opt => opt.UseMySql(conStr, ServerVersion.AutoDetect(conStr)));

builder.Services.AddScoped<ForceRenderComponentService>();
builder.Services.AddScoped<HeadersFilterTable>();

//EFWHandlers
builder.Services.AddScoped<PatientRepository>();
builder.Services.AddScoped<DepartmentRepository>();
builder.Services.AddScoped<StaffRepository>();
builder.Services.AddScoped<ReportRepository>();
builder.Services.AddScoped<ArchiveRepository>();
builder.Services.AddScoped<NoteRepository>();
builder.Services.AddScoped<MedicalHistoryRouteMapRepository>();
builder.Services.AddScoped<LogsRepository>();
builder.Services.AddScoped<ConclusionRepository>();

//API
builder.Services.AddScoped<InsuranceCompanyAPI>();

//Hub
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<NotificationHub>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.MapHub<NotificationHub>("/notificationHub");

app.Run();
