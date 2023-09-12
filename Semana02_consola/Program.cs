using System;

namespace Semana02_consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1");
            Empleado emp = new Empleado();
            emp.Nombre = "Anderson";
            emp.Apellido = "Almeyda";
            emp.Sueldo = 3800;
            emp.Edad = 23;
            Console.WriteLine($"Empleado: {emp.Nombre} {emp.Apellido}");
            emp.CalcularSueldoNetoMasna();
            Console.WriteLine("==================================");
            Console.WriteLine("==================================");
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("Ejercicio 2");
            Estudiante est = new Estudiante("Anderson", 100, 100, 100);
            Console.WriteLine($"Estudiante: {est.Nombre}");
            Console.WriteLine($"Promedio: {est.SacarRicoPromedio()}");
            Console.WriteLine($"Tu Nota es: {est.CalcularCalificacion()}");
            Console.WriteLine($"Estado: {est.isReprobado()}");
            Console.WriteLine("==================================");
            Console.WriteLine("==================================");
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("Ejercicio 3");
            Producto prod1 = new Producto("Camiseta", 25);
            Console.WriteLine($"Producto: {prod1.getNombre()}");
            Console.WriteLine($"Precio: ${prod1.getPrecio()}");
            Console.WriteLine("==================================");
            Producto prod2 = new Producto("Zapatos", 50);
            Console.WriteLine($"Producto: {prod2.getNombre()}");
            Console.WriteLine($"Precio: ${prod2.getPrecio()}");
            Console.WriteLine("==================================");
            prod1.aplicarDescuento(10);
            Console.WriteLine("==================================");
            Console.WriteLine("==================================");
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
