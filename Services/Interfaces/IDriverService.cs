using AutoTrackerWeb.Models.Drivers;

namespace AutoTrackerWeb.Services.Interfaces
{
    public interface IDriverService
    {
        Task<List<DriverDto>> GetAllAsync();
        Task<DriverDto?> GetByDocumentAsync(string document);
        Task<DriverDto?> CreateAsync(CreateDriverDto dto);
        Task<DriverDto?> AssignVehicleAsync(string document, string plate);
        Task<DriverDto?> UnassignVehicleAsync(string document);
    }
}
