using System.Text;
using SuperHeroesApp.Models;

// Creación de instancias de superpoderes
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

var regeneracion = new SuperPoder();
regeneracion.Nombre = "Regeneración";
regeneracion.Descripcion = "Capacidad de curarse rápidamente de heridas y enfermedades.";
regeneracion.Nivel = NivelPoder.NivelTres;

// Creación de instancias de superhéroes
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

// Uso de los superpoderes de Superman
string result = superman.UsarSuperPoderes();
Console.WriteLine(result);

// Probando los Records
var batman = new SuperHeroes();
var batman2 = new SuperHeroes();
batman.Id = 4;
batman.Nombre = "Batman";
batman.IdentidadSecreta = "Bruce Wayne";

batman2.Id = 4;
batman2.Nombre = "Batman";
batman2.IdentidadSecreta = "Bruce Wayne";

Console.WriteLine(batman == batman2); // false, porque las clases comparan por referencia

SuperHeroesRecord superHeroesRecord1 = new SuperHeroesRecord(5, "Flash", "Barry Allen");
SuperHeroesRecord superHeroesRecord2 = new SuperHeroesRecord(5, "Flash", "Barry Allen");

Console.WriteLine(superHeroesRecord1 == superHeroesRecord2); // true, porque los records comparan por valor


// Herencia de clases
var wolverine = new AntiHeroe();
wolverine.Id = 5;
wolverine.Nombre = "Wolverine";
wolverine.IdentidadSecreta = "Logan";
wolverine.Ciudad = "Alberta";
wolverine.PuedeVolar = false;

List<SuperPoder> wolverinePoderes = new List<SuperPoder>();
wolverinePoderes.Add(regeneracion);
wolverinePoderes.Add(poderFuerza);
wolverine.SuperPoderes = wolverinePoderes;
result = wolverine.RealizarAccionAntiHeroica("luchar contra los buenos.");
Console.WriteLine(result);

// abstracción de clases
string resultadoSalvarMundo = superman.SalvarElMundo();
string resultadoSalvarTierra = superman.SalvarTierra();
Console.WriteLine(resultadoSalvarMundo);
Console.WriteLine(resultadoSalvarTierra);

// Polimorfismo de clases
string resultadoSalvarPersonas = superman.SalvarPersonas();
Console.WriteLine(resultadoSalvarPersonas);


// Conjunto cerrado de valores posibles
enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}

// Records
public record SuperHeroesRecord(int Id, string Nombre, string IdentidadSecreta);