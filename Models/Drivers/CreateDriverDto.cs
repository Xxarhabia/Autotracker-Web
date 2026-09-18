using System.ComponentModel.DataAnnotations;

namespace AutoTrackerWeb.Models.Drivers
{
    public class CreateDriverDto
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "El documento es obligatorio")]
        public string Document { get; set; } = string.Empty;

        [Required(ErrorMessage = "El telefono es obligatorio")]
        public string Phone { get; set; } = string.Empty;
    }
}
