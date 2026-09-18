namespace AutoTrackerWeb.Models.Vehicles
{
    public class VehicleDto
    {
        public int Id { get; set; }
        public string Plate { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string Year { get; set; } = string.Empty;
        public bool EngineOn { get; set; }
    } 
}
