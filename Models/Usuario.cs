using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace waAlquimia.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    [Display(Name = "Correo Electronico")]
    [Required]
    public string Email { get; set; } = null!;

    [Display(Name = "Contraseña")]
    [Required]
    public string Password { get; set; } = null!;

    public string? Telefono { get; set; }
}
