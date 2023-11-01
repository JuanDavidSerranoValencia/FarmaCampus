using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class MovimientoInventario : BaseEntity
    {
        public DateTime FechaMovimientos { get; set; }
        public DateTime FechaVencimiento { get; set; }


        public int IdPersonaFK { get; set; }
        public Persona Persona { get; set; }


        public int IdTipoMovFk { get; set; }
        public TipoMovInventario TipoMovInventario { get; set; }

        public ICollection<DetalleMovimiento> DetallesMovimientos { get; set; }

    }
}