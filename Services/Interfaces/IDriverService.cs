using AutoTrackerWeb.Models.Drivers;

namespace AutoTrackerWeb.Services.Interfaces
{
    public interface IDriverService
    {
        Task<List<DriverListDto>> GetAllAsync();
        Task<DriverListDto?> GetByDocumentAsync(string document);
        Task<DriverDto?> CreateAsync(CreateDriverDto dto);
        Task<DriverDto?> AssignVehicleAsync(string document, string plate);
        Task<DriverDto?> UnassignVehicleAsync(string document);
    }
}
