// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Objetos
Botella botella1 = new Botella();
Botella botella2 = new Botella();

// Asignación de valores a las propiedades
botella1.Color = "Black";
botella1.Brand = "Bubba";
botella2.Capacity = 32;
botella2.Stickers = false;

Console.WriteLine($"Botella 1: Color - {botella1.Color}, Marca - {botella1.Brand}.");
Console.WriteLine($"Botella 2: Capacidad - {botella2.Capacity}oz, Tiene stickers? - {botella2.Stickers}.");

// Clase
class Botella
{
    // Propiedades
    public string Color;
    public string Brand;
    public bool Stickers;
    public double Height;
    public double weight;
    public double Capacity;
}