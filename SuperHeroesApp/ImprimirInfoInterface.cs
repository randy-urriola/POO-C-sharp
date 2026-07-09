using SuperHeroesApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp
{
    internal class ImprimirInfoInterface
    {
        public void ImprimirInfo(ISuperHeroe heroe)
        {
            Console.WriteLine(heroe.HeroeInfo());
        }
    }
}
