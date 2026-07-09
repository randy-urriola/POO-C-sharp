using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Interfaces
{
    internal interface ISuperHeroe
    {
        int Id { get; set; }
        string Nombre { get; set; }
        string IdentidadSecreta { get; set; }
        string Ciudad { get; set; }
        bool PuedeVolar { get; set; }
        List<Models.SuperPoder> SuperPoderes { get; set; }

        string HeroeInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ID: {Id}");
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Identidad Secreta: {IdentidadSecreta}");
            sb.AppendLine($"Ciudad: {Ciudad}");
            sb.AppendLine($"Puede Volar: {PuedeVolar}");

            foreach (var poder in SuperPoderes)
            {
                sb.AppendLine($"{Nombre} esta usando el superpoder {poder.Nombre}!!");
            }
            return sb.ToString();
        }
    }
}
