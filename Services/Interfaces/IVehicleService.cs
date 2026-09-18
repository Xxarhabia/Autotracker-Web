using AutoTrackerWeb.Models.Vehicles;

namespace AutoTrackerWeb.Services.Interfaces
{
    public interface IVehicleService
    {
        Task<List<VehicleDto>> GetAllAsync();
        Task<VehicleDto?> GetByPlateAsync(string plate);
        Task<VehicleDto?> CreateAsync(CreateVehicleDto dto);
    }
}
