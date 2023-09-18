using CarDealerAppClient.Models.Cars;
using CarDealerAppClient.Services.Cars;
using CarDealerAppClient.Services.Navigation;
using CarDealerAppClient.ViewModels.Base;
using CarDealerAppClient.ViewModels.Cars;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace CarDealer.Client.ViewModels.Cars
{
    public class CarViewModel : BaseViewModel, ICarViewModel
    {
        private readonly ICarService _carService;
        public ObservableCollection<CarModel> Cars { get; set; } = new ObservableCollection<CarModel>();
        public AddCarCommand AddCarCommand { get; set; } = new AddCarCommand();
        public CarModel SelectedCar { get; set; } = new CarModel();
        public CarViewModel(INavigationService navigationService, ICarService carService) : base(navigationService)
        {
            _carService = carService;
            LoadCars();
        }

        public async Task LoadCars()
        {
            try
            {
                var cars = await _carService.GetAllCarsAsync();
                foreach (var car in cars)
                {
                    if(Cars.Any(x => x.CarId == car.CarId))
                    {
                        continue;
                    }
                    Cars.Add(car);
                }
                OnPropertyChanged(nameof(Cars));
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                throw;
            }
        }

        public async Task AddCar()
        {
            await _carService.AddCarAsync(AddCarCommand);
            await LoadCars();
            AddCarCommand = new AddCarCommand();
        }

        public async Task NavigateToCarDetails(string id)
        {
            await _navigationService.NavigateAsync($"cardetails/{id}");
        }
    }
}
