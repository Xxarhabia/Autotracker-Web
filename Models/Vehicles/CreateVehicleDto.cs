using System.ComponentModel.DataAnnotations;

namespace AutoTrackerWeb.Models.Vehicles
{
    public class CreateVehicleDto
    {
        [Required(ErrorMessage = "La placa es obligatoria")]
        public string Plate { get; set; } = string.Empty;
        [Required(ErrorMessage = "La marca es obligatoria")]
        public string Brand { get; set; } = string.Empty;
        [Required(ErrorMessage = "El modelo es obligatorio")]
        public string Model { get; set; } = string.Empty;
        [Required(ErrorMessage = "El año es obligatorio")]
        public string Year { get; set; } = string.Empty;
    }
}
