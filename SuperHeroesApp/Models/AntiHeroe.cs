using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    internal class AntiHeroe: SuperHeroes
    {
        public string RealizarAccionAntiHeroica(string accion)
        {
            return $"{NombreEIdentidadSetreta} está realizando una acción antiheroica: {accion}";
        }
    }
}
