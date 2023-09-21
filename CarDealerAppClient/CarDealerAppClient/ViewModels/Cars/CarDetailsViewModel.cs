using CarDealerAppClient.Models.Cars;
using CarDealerAppClient.Services.Cars;
using CarDealerAppClient.Services.Navigation;
using CarDealerAppClient.ViewModels.Base;

namespace CarDealerAppClient.ViewModels.Cars
{
    public class CarDetailsViewModel : BaseViewModel, ICarDetailsViewModel
    {
        private readonly ICarService _carService;
        public CarDetailsViewModel(INavigationService navigationService, ICarService carService) : base(navigationService)
        {
            _carService = carService;
        }

        public CarModel Car { get; set; } = new CarModel();

        public async Task DeleteCarById(string id)
        {
            await _carService.DeleteCarAsync(id);
            OnPropertyChanged(nameof(Car));
            await NavigateToCar();
        }

        public async Task GetCarById(string id)
        {
            Car = await _carService.GetCarAsync(id);
            OnPropertyChanged(nameof(Car));
        }



        public async Task NavigateToCar()
        {
            await _navigationService.NavigateAsync($"/car");
        }
    }
}
