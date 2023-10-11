using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.FluentValidation;
using Blazorise.Icons.FontAwesome;
using Blazorise.Modules;
using CarDealer.Client.ViewModels.Cars;
using CarDealerAppClient;
using CarDealerAppClient.Services.Cars;
using CarDealerAppClient.Services.Navigation;
using CarDealerAppClient.ViewModels.Cars;
using CarDealerAppClient.ViewModels.Login;
using CarDealerAppClient.ViewModels.Registration;
using CarDealerAppClient.ViewModels.User;
using FluentValidation;
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
builder.Services.AddScoped<IUserViewModel, UserViewModel>();
builder.Services.AddScoped<IPasswordRecoveryViewModel, PasswordRecoveryViewModel>();
builder.Services.AddScoped<IRegistrationViewModel, RegistrationViewModel>();
AddBlazorise(builder.Services);
builder.Services.AddScoped<IJSTableModule, JSTableModule>();
await builder.Build().RunAsync();


void AddBlazorise(IServiceCollection services)
{
    services
        .AddBlazorise();
    services
        .AddBootstrapProviders()
        .AddFontAwesomeIcons()
        .AddBlazoriseFluentValidation();
    services.AddValidatorsFromAssembly(typeof(App).Assembly);
}
