using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    class SuperPoder
    {
        // Propiedades
        public string Nombre;
        public string Descripcion;
        public NivelPoder Nivel;

        // Constructor
        public SuperPoder()
        {
            Nivel = NivelPoder.NivelUno;
        }
    }
}
