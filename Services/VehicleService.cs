using AutoTrackerWeb.Models.Vehicles;
using AutoTrackerWeb.Services.Interfaces;

namespace AutoTrackerWeb.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly HttpClient _httpClient;

        public VehicleService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<VehicleDto?> CreateAsync(CreateVehicleDto dto)
        {
            var response = await _httpClient.PostAsJsonAsync(
                "api/vehicles", 
                dto    
            );

            if (!response.IsSuccessStatusCode)
                return null;

            return await response.Content.ReadFromJsonAsync<VehicleDto>();
        }

        public async Task<List<VehicleDto>> GetAllAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<VehicleDto>>(
                "api/vehicles"    
            ) ?? [];
        }

        public async Task<VehicleDto?> GetByPlateAsync(string plate)
        {
            var response = await _httpClient.GetAsync(
                $"api/vehicles/{plate}"    
            );

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                return null;

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<VehicleDto>();
        }
    }
}
