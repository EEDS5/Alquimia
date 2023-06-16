using System;
using System.Collections.Generic;

namespace waAlquimia.Models;

public partial class Reserva
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime? FechaReserva { get; set; }

    public TimeSpan? HoraReserva { get; set; }

    public int? CantidadPersonas { get; set; }
}
