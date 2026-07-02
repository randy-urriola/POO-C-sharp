// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var poderVolar = new SuperPoder();
poderVolar.Nombre = "Vuelo";
poderVolar.Descripcion = "Capacidad de volar por el aire.";
poderVolar.Nivel = NivelPoder.NivelDos;

var poderFuerza = new SuperPoder();
poderFuerza.Nombre = "Super fuerza";
poderFuerza.Nivel = NivelPoder.NivelTres;

var poderAgilidad = new SuperPoder();
poderAgilidad.Nombre = "Agilidad sobrehumana";
poderAgilidad.Descripcion = "Capacidad de moverse con gran rapidez y destreza.";
poderAgilidad.Nivel = NivelPoder.NivelDos;

var superman = new SuperHeroes();
var spiderman = new SuperHeroes();
var wonderwoman = new SuperHeroes();

superman.Id = 1;
superman.Nombre = "Superman";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;
List<SuperPoder> supermanPoderes = new List<SuperPoder>();
supermanPoderes.Add(poderFuerza);
supermanPoderes.Add(poderVolar);
superman.SuperPoderes = supermanPoderes;

spiderman.Id = 2;
spiderman.Nombre = "Spider-Man";
spiderman.IdentidadSecreta = "Peter Parker";
spiderman.Ciudad = "Nueva York";
spiderman.PuedeVolar = false;
List<SuperPoder> spidermanPoderes = new List<SuperPoder>();
spidermanPoderes.Add(poderAgilidad);
spiderman.SuperPoderes = spidermanPoderes;

wonderwoman.Id = 3;
wonderwoman.Nombre = "Wonder Woman";
wonderwoman.IdentidadSecreta = "Diana Prince";
wonderwoman.Ciudad = "Themyscira";
wonderwoman.PuedeVolar = true;
List<SuperPoder> wonderwomanPoderes = new List<SuperPoder>();
wonderwomanPoderes.Add(poderVolar);
wonderwomanPoderes.Add(poderFuerza);
wonderwoman.SuperPoderes = wonderwomanPoderes;

class SuperHeroes
{
    public int Id;
    public string Nombre;
    public string IdentidadSecreta;
    public string Ciudad;
    public List<SuperPoder> SuperPoderes;
    public bool PuedeVolar;
}

class SuperPoder
{
    public string Nombre;
    public string Descripcion;
    public NivelPoder Nivel;
}

enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}