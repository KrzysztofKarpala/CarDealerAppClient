using CarDealerAppClient.Models.Cars;

namespace CarDealerAppClient.Services.Cars
{
    public interface ICarService
    {
        Task AddCarAsync(AddCarCommand addCarCommand);
        Task<CarModel> GetCarAsync(string carId);
        Task<List<CarModel>> GetAllCarsAsync();
    }
}
