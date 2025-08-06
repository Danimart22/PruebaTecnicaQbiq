using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using VisordeRickyMorty;
using VisordeRickyMorty.Models;
using VisordeRickyMorty.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://rickandmortyapi.com/") });
builder.Services.AddScoped<CharactersService>();

await builder.Build().RunAsync();
