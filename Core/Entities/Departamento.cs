using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Departamento:BaseEntity
    {
        public string NombreDepartamento { get; set; }

        public ICollection<Ciudad> Ciudads { get; set; }
        public int IdPaisFk { get; set; }
        public Pais Pais { get; set; }
    }
}