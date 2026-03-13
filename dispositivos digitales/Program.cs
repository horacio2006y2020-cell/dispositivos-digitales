using System; using System.Collections.Generic;

List<Dispositivo> dispositivos = new List<Dispositivo>();
Console.WriteLine("¿Cuántos dispositivos desea ingresar?");
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    Dispositivo dis = new Dispositivo();
    Console.WriteLine($"\n1. Dispositivo {i + 1}");
    Console.WriteLine("Nombre:"); dis.Nombre = Console.ReadLine();
    Console.WriteLine("Rendimiento 1:"); dis.Rendimient1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Rendimiento 2:"); dis.Rendimiento2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Rendimiento 3:"); dis.Rendimiento3 = double.Parse(Console.ReadLine());
    dispositivos.Add(dis);
}
double sumaPromedios = 0;
Dispositivo mejor = dispositivos[0];

Console.WriteLine("\n--- LISTADO DE DISPOSITIVOS ---");

foreach (Dispositivo d in dispositivos)
{
    d.MostrarDatos();
    sumaPromedios += d.CalcularPromedio();

    if (d.CalcularPromedio() > mejor.CalcularPromedio())
    {
        mejor = d;
    }
    Console.WriteLine($"\nPromedio general del laboratorio: {sumaPromedios / dispositivos.Count:F2}");

    Console.WriteLine("\nDispositivo con mejor rendimiento:");
    mejor.MostrarDatos();
}

class Dispositivo
{
    public string Nombre;
    public double Rendimient1;
    public double Rendimiento2;
    public double Rendimiento3;

    public double CalcularPromedio()
    {
        return (Rendimient1 + Rendimiento2 + Rendimiento3) / 3;
    }
    public string ObtenerEstado()
    {
        if (CalcularPromedio() <= 80) return "Optimo";
        else return "Necesita mantenimiento";
    }
    public void MostrarDatos()
    {
        Console.WriteLine($"nombre: {Nombre} | Promedio: {CalcularPromedio():F2} | Estado: {ObtenerEstado()}");
    }
}











