using CarDealerAppClient.Models.Cars;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace CarDealerAppClient.ViewModels.Cars
{
    public interface ICarViewModel
    {
        ObservableCollection<CarModel> Cars { get; set; }
        AddCarCommand AddCarCommand { get; set; }
        CarModel SelectedCar { get; set; }
        Task LoadCars();
        Task AddCar();
        Task NavigateToCarDetails(string id);
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
