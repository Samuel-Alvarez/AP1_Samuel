using System.ComponentModel.DataAnnotations;

public class Aportes
{
    [Key]
    [Range(0, int.MaxValue, ErrorMessage = "El ID debe estar en el rango de {1} y {2}.")]
    public int AporteId { get; set; }

    [Required(ErrorMessage = "Es obligatorio introducir la Persona")]
    [MinLength(3, ErrorMessage = "La persona debe tener al menos {1} caractéres.")]
    [MaxLength(35, ErrorMessage = "La Persona no debe pasar de {1} caractéres.")]
    public string? Persona { get; set; }

    [Range(1, 1_000_000, ErrorMessage ="El Monto debe ser Obligatorio" )]

    public float Monto { get; set; }

}
