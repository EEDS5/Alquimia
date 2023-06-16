using System;
using System.Collections.Generic;

namespace waAlquimia.Models;

public partial class Bebida
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal Precio { get; set; }

    public bool Disponible { get; set; }

    public virtual ICollection<Menu> Menus { get; set; } = new List<Menu>();
}
