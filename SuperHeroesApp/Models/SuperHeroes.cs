using SuperHeroesApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    class SuperHeroes : Heroe, ISuperHeroe
    {
        // Propiedades
        public int Id { get; set; }
        
        public string IdentidadSecreta { get; set; }
        public string Ciudad { get; set; }
        public List<SuperPoder> SuperPoderes { get; set; }
        public bool PuedeVolar { get; set; }

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
