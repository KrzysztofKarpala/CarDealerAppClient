using CarDealerAppClient.Models.Cars;
using System.Diagnostics;
using System.Text.Json;

namespace CarDealerAppClient.Services.Cars
{
    public class CarService : ICarService
    {
        private readonly HttpClient _httpClient;
        public CarService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task AddCarAsync(AddCarCommand addCarCommand)
        {
            var json = JsonSerializer.Serialize(addCarCommand);
            var contentString = new StringContent(json);
            contentString.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            HttpResponseMessage response = await _httpClient.PostAsync("api/v1/cars/addcar", contentString);
            if(!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException();
            }
        }

        public async Task<List<CarModel>> GetAllCarsAsync()
        {
            try
            {
                var responseString = await _httpClient.GetStringAsync("api/v1/cars/getallcars");
                var options = new JsonSerializerOptions
                {
                    IncludeFields = true,
                    PropertyNameCaseInsensitive = true,
                };
                var cars = JsonSerializer.Deserialize<List<CarModel>>(responseString, options);
                return cars;
            }
            catch (Exception ex)
            {
                Debug.Write(ex);
                throw;
            }

        }

        public async Task<CarModel> GetCarAsync(string carId)
        {
            try
            {
                var responseString = await _httpClient.GetStringAsync($"api/v1/cars/getcarbyid?carId={carId}");
                var options = new JsonSerializerOptions
                {
                    IncludeFields = true,
                    PropertyNameCaseInsensitive = true,
                };
                var car = JsonSerializer.Deserialize<CarModel>(responseString, options);
                return car;
            }
            catch (Exception ex)
            {
                Debug.Write(ex);
                throw;
            }
        }
    }
}
