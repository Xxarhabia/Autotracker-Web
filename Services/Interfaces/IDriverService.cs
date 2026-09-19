using AutoTrackerWeb.Models.Drivers;

namespace AutoTrackerWeb.Services.Interfaces
{
    public interface IDriverService
    {
        Task<List<DriverListDto>> GetAllAsync();
        Task<DriverListDto?> GetByDocumentAsync(string document);
        Task<DriverDto?> CreateAsync(CreateDriverDto dto);
        Task<(bool Success, string Message, DriverDto dto)> AssignVehicleAsync(string document, string plate);
        Task<(bool Success, string Message, DriverDto dto)> UnassignVehicleAsync(string document);
    }
}
