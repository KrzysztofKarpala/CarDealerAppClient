using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using Blazorise.Modules;
using CarDealer.Client.ViewModels.Cars;
using CarDealerAppClient;
using CarDealerAppClient.Services.Cars;
using CarDealerAppClient.Services.Navigation;
using CarDealerAppClient.ViewModels.Cars;
using CarDealerAppClient.ViewModels.Login;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:8080/") });
builder.Services.AddScoped<INavigationService, NavigationService>();

builder.Services.AddScoped<ICarViewModel, CarViewModel>();
builder.Services.AddScoped<ICarService, CarService>();
builder.Services.AddScoped<ICarDetailsViewModel, CarDetailsViewModel>();
builder.Services.AddScoped<ILoginViewModel, LoginViewModel>();
AddBlazorise(builder.Services);
builder.Services.AddScoped<IJSTableModule, JSTableModule>();
await builder.Build().RunAsync();


void AddBlazorise(IServiceCollection services)
{
    services
        .AddBlazorise();
    services
        .AddBootstrapProviders()
        .AddFontAwesomeIcons();

}
