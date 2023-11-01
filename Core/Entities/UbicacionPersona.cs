using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class UbicacionPersona:BaseEntity
    {
        public string TipoVia { get; set; }
        public int NumeroPri { get; set; }
        public string Letra { get; set; }
        public string Bis{ get; set; }
        public string LetraSec { get; set; }
        public string Cardinal { get; set; }
        public int NumeroSec { get; set; }
        public string LetraTer { get; set; }
        public string Complemento { get; set; }

        public int IdCiudadFk { get; set; }
        public Ciudad Ciudad{ get; set; }

        public int IdPersonaFk { get; set; }
        public Persona Persona { get; set; }

        
    }
}