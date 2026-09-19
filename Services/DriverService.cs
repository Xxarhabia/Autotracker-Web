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

        public async Task<(bool Success, string Message, DriverDto dto)> AssignVehicleAsync(string document, string plate)
        {
            var response = await _httpClient.PatchAsync(
                $"api/drivers/{document}/assign/{plate}",
                new StringContent(string.Empty)
            );

            if (!response.IsSuccessStatusCode)
                return (false, await ReadErrorMessageAsync(response), null);

            var driver = await response.Content.ReadFromJsonAsync<DriverDto>();
            return (true, null, driver);
        }

        public async Task<(bool Success, string Message, DriverDto dto)> UnassignVehicleAsync(string document)
        {
            var response = await _httpClient.PatchAsync(
                $"api/drivers/{document}/unassign",
                new StringContent(string.Empty)
            );

            if (!response.IsSuccessStatusCode)
                return (false, await ReadErrorMessageAsync(response), null);

            var driver = await response.Content.ReadFromJsonAsync<DriverDto>();
            return (true, null, driver);
        }

        private static async Task<string> ReadErrorMessageAsync(HttpResponseMessage response)
        {
            var raw = await response.Content.ReadAsStringAsync();

            if (string.IsNullOrWhiteSpace(raw))
                return "Ocurrio un error inesperado";

            try
            {
                var text = System.Text.Json.JsonSerializer.Deserialize<string>(raw);
                return text ?? raw;
            }
            catch
            {
                return raw;
            }
        }
    }
}
