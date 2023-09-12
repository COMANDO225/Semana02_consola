using System;

namespace Semana02_consola
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get;  set; }
        public int Sueldo { get; set; }

        // aqui viene lo rico, sistema de quinta ctaegoria
        public double CalcularSueldoNetoMasna()
        {
            // sueldo anual
            double sueldoAnualBruto = Sueldo * 12;
            // la rica grati (Julio y Dic)
            double gratificacion = Sueldo * 2;
            // es tu sueldo bruto liquido con grati
            double ingresoAnualProyectado = sueldoAnualBruto + gratificacion;
            // valor de una UIT
            double uit = 4950;
            // valor de 7UITs que se te descuentan a tu bruto anual
            double sevenUits = uit * 7;
            // la renta neta
            double rentaNeta = ingresoAnualProyectado - sevenUits;

            double impuestoAnual = CalcularImpuestoAnio(rentaNeta);
            double impuestoMensual = impuestoAnual / 12;
            double sueldoNetoMasna = Sueldo - impuestoMensual;

            MostrarInfo(
                sueldoAnualBruto, 
                rentaNeta, 
                impuestoAnual, 
                impuestoMensual, 
                sueldoNetoMasna
            );

            MostrarComentario(Nombre, Apellido, Edad, sueldoNetoMasna);

            return sueldoNetoMasna;
        }
        // calculamos las tasas de interes segun el margen de tu sueldito :'(
        private double CalcularImpuestoAnio(double rentaNeta)
        {
            if (rentaNeta <= 24750){
                return rentaNeta * 0.08;
            } else if (rentaNeta <= 99000){
                return rentaNeta * 0.14;
            } else if (rentaNeta <= 173250){
                return rentaNeta * 0.17;
            } else if (rentaNeta <= 222750){
                return rentaNeta * 0.20;
            } else {
                return rentaNeta * 0.30;
            }
        }
        // para no ir tan diferente de la clase grabado, aqui hare las funciones vacias
        private void MostrarInfo(
            double sueldoAnualBruto, 
            double rentaNeta, 
            double impuestoAnual, 
            double impuestoMensual, 
            double sueldoNetoMasna
        ){
            Console.WriteLine($"Sueldo: S/.{Sueldo}");
            Console.WriteLine($"Sueldo anual bruto: S/.{sueldoAnualBruto}");
            Console.WriteLine($"Renta neta: S/.{rentaNeta}");
            Console.WriteLine($"Impuesto anual: S/.{impuestoAnual}");
            Console.WriteLine($"Impuesto mensual: S/.{impuestoMensual}");
            Console.WriteLine($"Sueldo mensual neto: S/.{sueldoNetoMasna}");
        }

        private void MostrarComentario(string Nombre, string Apellido, int Edad, double sueldoNetoMasna)
        {
            Console.WriteLine($"Soy {Nombre} {Apellido}, tengo {Edad} años y mi sueldo neto mensual es de S/.{sueldoNetoMasna}");
        }
    }
}
