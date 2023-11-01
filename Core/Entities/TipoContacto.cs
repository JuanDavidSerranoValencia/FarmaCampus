using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class TipoContacto:BaseEntity
    {
        public string NombreContacto { get; set; }

        public ICollection<ContactoPersona> ContactosPersonas{ get; set; }
    }
}