using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Persona:BaseEntity
    {
        public string NombrePersona { get; set; }
        public DateTime FechaRegistro { get; set; }

        public int IdRolPersonaFk { get; set; }
        public RolPersona RolPersona { get; set; }

        public int IdTipoDocFk { get; set; }
        public TipoDocumento TipoDocumento { get; set; }

        public int IdTipoPerFk { get; set; }
        public TipoPersona TipoPersona{ get; set; }


        public ICollection<ContactoPersona> ContactosPersonas { get; set; }
        public ICollection<UbicacionPersona> UbicacionesPersonas { get; set; }
        public ICollection<MovimientoInventario> MovimientosInventarios { get; set; }
    
    } 
}