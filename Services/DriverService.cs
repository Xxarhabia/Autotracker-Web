using AutoTrackerWeb.Models.Drivers;
using AutoTrackerWeb.Services.Interfaces;

namespace AutoTrackerWeb.Services
{
    public class DriverService : IDriverService
    {
        private readonly HttpClient _httpClient;

        public DriverService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<DriverDto?> CreateAsync(CreateDriverDto dto)
        {
            var response = await _httpClient.PostAsJsonAsync(
                "api/drivers",
                dto
            );

            if (!response.IsSuccessStatusCode)
                return null;

            return await response.Content.ReadFromJsonAsync<DriverDto>();

        }

        public async Task<List<DriverListDto>> GetAllAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<DriverListDto>>(
                "api/drivers"
            ) ?? [];
        }

        public async Task<DriverListDto?> GetByDocumentAsync(string document)
        {
            var response = await _httpClient.GetAsync(
                $"api/drivers/{document}"    
            );

            if (!response.IsSuccessStatusCode)
                return null;

            return await response.Content.ReadFromJsonAsync<DriverListDto>();
        }

        public Task<DriverDto?> AssignVehicleAsync(string document, string plate)
        {
            throw new NotImplementedException();
        }

        public Task<DriverDto?> UnassignVehicleAsync(string document)
        {
            throw new NotImplementedException();
        }
    }
}
