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

        public Task<DriverDto?> CreateAsync(CreateDriverDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<List<DriverDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<DriverDto?> GetByDocumentAsync(string document)
        {
            throw new NotImplementedException();
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
