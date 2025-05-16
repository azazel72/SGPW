using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SGPW.Shared.Services;
using SGPW.Web.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add device-specific services used by the SGPW.Shared project
builder.Services.AddSingleton<IFormFactor, FormFactor>();

await builder.Build().RunAsync();
