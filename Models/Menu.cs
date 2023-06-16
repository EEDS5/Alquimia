using System;
using System.Collections.Generic;

namespace waAlquimia.Models;

public partial class Menu
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool Disponible { get; set; }

    public int? PlatilloId { get; set; }

    public int? BebidaId { get; set; }

    public int? PostreId { get; set; }

    public virtual Bebida? Bebida { get; set; }

    public virtual Platillo? Platillo { get; set; }

    public virtual Postre? Postre { get; set; }
}
