using System;

namespace Semana02_consola
{
    public class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public string getNombre()
        {
            return Nombre;
        }

        public double getPrecio()
        {
            return Precio;
        }

        public void aplicarDescuento(double porcentaje)
        {
            Precio = Precio - (Precio * porcentaje / 100);
            Console.WriteLine($"-----------------({Nombre})--------------------");
            Console.WriteLine($"El precio con descuento de {porcentaje}% es: ${Precio}");
            Console.WriteLine("-----------------------------------------------");
        }

        public Producto(string nombre, double precio)
        {
            this.Nombre = nombre;
            this.Precio = precio;
        }
    }
}
