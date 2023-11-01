using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ContactoPersona:BaseEntity
    {
        public int IdPersonaFk { get; set; }
        public Persona Persona { get; set; }

        public int IdTipoContacFk { get; set; }
        public TipoContacto TipoContacto { get; set; }
    }
}