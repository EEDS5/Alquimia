using System;
using System.Collections.Generic;

namespace waAlquimia.Models;

public partial class Administracion
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Contraseña { get; set; } = null!;

    public string Rol { get; set; } = null!;
}
