using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    class SuperHeroes : Heroe
    {
        // Propiedades
        public int Id;
        
        public string IdentidadSecreta;
        public string Ciudad;
        public List<SuperPoder> SuperPoderes;
        public bool PuedeVolar;

        // ejemplo de encapsulamiento
        private string _Nombre;
        public override string Nombre
        {
            get { return _Nombre; }
            set
            {
                _Nombre = value.Trim();
            }
        }

        public string NombreEIdentidadSetreta
        {
            get { return $"{Nombre} ({IdentidadSecreta})"; }
        }


        // Constructor
        public SuperHeroes()
        {
            Id = 0;
            SuperPoderes = new List<SuperPoder>();
            PuedeVolar = false;
        }

        public string UsarSuperPoderes()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var poder in SuperPoderes)
            {
                sb.AppendLine($"{NombreEIdentidadSetreta} esta usando el superpoder {poder.Nombre}!!");
            }

            return sb.ToString();
        }

        public override string SalvarElMundo()
        {
            return $"{NombreEIdentidadSetreta} está salvando el mundo!";
        }

        public override string SalvarPersonas()
        {
            //return base.SalvarPersonas();
            return $"{NombreEIdentidadSetreta} ha salvando a +100 personas! quiere decir que {base.SalvarPersonas()}";
        }

    }
}
