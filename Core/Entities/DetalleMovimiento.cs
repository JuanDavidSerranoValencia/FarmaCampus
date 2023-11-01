using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class DetalleMovimiento:BaseEntity
    {
        public int Cantidad { get; set; }
        public int Precio { get; set; }

        public int IdInventarioFk { get; set; }
        public Inventario Inventario { get; set; }

        public int IdMovInvFk { get; set; }
        public MovimientoInventario MovimientosInventario { get; set; }
    }
}