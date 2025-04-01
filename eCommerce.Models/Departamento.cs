using System;
using System.Collections.Generic;

namespace eCommerce.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string? NomeDepartamento { get; set; }
        public ICollection<Usuario>? Usuarios { get; set; }
    }
}