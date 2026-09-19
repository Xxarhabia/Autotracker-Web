namespace AutoTrackerWeb.Models.Drivers
{
    public class DriverListDto
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Document { get; set; } = string.Empty;
        public string? VehiclePlate { get; set; }
    }
}
