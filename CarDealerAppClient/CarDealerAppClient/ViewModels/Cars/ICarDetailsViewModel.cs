using CarDealerAppClient.Models.Cars;
using System.ComponentModel;

namespace CarDealerAppClient.ViewModels.Cars
{
    public interface ICarDetailsViewModel
    {
        CarModel Car { get; set; }
        Task GetCarById(string id);
        Task DeleteCarById(string id);
        Task NavigateToCar();
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
