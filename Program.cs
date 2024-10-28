using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;
using Tarea5;
using Tarea5.Data;
using Tarea5.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

// Configuración de Entity Framework Core
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=Tarea5.db"));

// Registro de servicios
builder.Services.AddScoped<PlataformaService>();
builder.Services.AddScoped<VideojuegoService>();
builder.Services.AddScoped<PersonajeService>();

await builder.Build().RunAsync();
