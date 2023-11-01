using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Producto:BaseEntity
    {
        public string NombreProducto { get; set; }

        public int IdMarcaFk { get; set; }
        public Marca Marca { get; set; }

        public ICollection<Inventario> Inventariss { get; set; }
    }
}