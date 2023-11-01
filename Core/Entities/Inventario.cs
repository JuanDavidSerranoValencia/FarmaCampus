using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Inventario : BaseEntity
    {
        public string NombreInventario { get; set; }
        public int Precio { get; set; }
        public int Stock { get; set; }
        public int StockMin { get; set; }
        public int StockMax { get; set; }

        public int IdPresentacionFk { get; set; }
        public Presentacion Presentacion{ get; set; }

        public int IdProductoFk { get; set; }
        public Producto Producto { get; set; }

        public ICollection<DetalleMovimiento> DetallesMovimientos { get; set; }
    }
}