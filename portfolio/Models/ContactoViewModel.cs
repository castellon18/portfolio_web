using System.ComponentModel.DataAnnotations;

namespace portfolio.Models;

public class ContactoViewModel
{
    [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
    [StringLength(100, ErrorMessage = "El campo {0} no puede exceder {1} caracteres.")]
    public string Nombres { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
    [StringLength(100, ErrorMessage = "El campo {0} no puede exceder {1} caracteres.")]
    public string Apellidos { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
    [RegularExpression(@"^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$", ErrorMessage = "El campo {0} no es un correo electrónico válido.")]
    [EmailAddress(ErrorMessage = "El campo {0} no es un correo electrónico válido.")]
    public string Email { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es obligatorio.")]
    public string Mensaje { get; set; } = string.Empty;
}
