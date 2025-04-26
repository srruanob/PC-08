using System;
 
public class Estudiante
{
    string nombre;
    int edad;
    string carrera; 
    int carnet;
    int NotaAdmisión;

    public static void Main()
    {
        Console.Write("Ingrese su nombre: ");
        string nombreIngresado = Console.ReadLine();
 
        Console.Write("Ingrese su edad: ");
        int edadIngresada = int.Parse(Console.ReadLine());

        Console.Write("Ingrese su carrera: ");
        string carreraIngresada = Console.ReadLine();
 
        Console.Write("Ingrese su carnet: ");
        int carnetIngresado = int.Parse(Console.ReadLine());

        Console.Write("Ingrese su NotaAdmisión: ");
        int NotaAdmisiónIngresada = int.Parse(Console.ReadLine());

        Estudiante objetoEstudiante = new Estudiante(nombreIngresado, edadIngresada, carreraIngresada, carnetIngresado, NotaAdmisiónIngresada);
        
        objetoEstudiante.MostrarResumen();

        if (objetoEstudiante.PuedeMatricular())
        {
            Console.WriteLine("\nEl estudiante puede matricularse.");
        }
        else
        {
            Console.WriteLine("\nEl estudiante NO puede matricularse.");
        }
    }
    public bool PuedeMatricular()
    {
        return NotaAdmisión >= 75 && carnet.ToString().EndsWith("2025");
    }

    public Estudiante(string nombre, int edad, string carrera, int carnet, int NotaAdmisión)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.carrera = carrera;
        this.carnet = carnet;
        this.NotaAdmisión = NotaAdmisión;
    }

    public void MostrarResumen()
    {
        Console.WriteLine("\n--- Resumen del Estudiante ---");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Carrera: {carrera}");
        Console.WriteLine($"Carnet: {carnet}");
        Console.WriteLine($"Nota de Admisión: {NotaAdmisión}");
    }
}
