using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class RolPersona:BaseEntity
    {
        public string NombreRol { get; set; }

        public ICollection<Persona> Persons{ get; set; }
    }
}