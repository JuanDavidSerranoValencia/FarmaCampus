using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class TipoMovInventario : BaseEntity
    {
        public string NombreMovimientoInv { get; set; }

        public ICollection<MovimientoInventario> MovimientosInventarios{ get; set; }
    }
}