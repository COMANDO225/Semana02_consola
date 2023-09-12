using System;

namespace Semana02_consola
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public int ExCsharp1 { get; set; }
        public int ExCsharp2 { get; set; }
        public int ExCsharp3 { get; set; }

        // creamos un constructor para la clase Estudiante, esto nos ayudara
        // en el momento de instanciar un objeto de la clase Estudiante
        public Estudiante(string nombre, int exCsharp1, int exCsharp2, int exCsharp3)
        {
            this.Nombre = nombre;
            this.ExCsharp1 = exCsharp1;
            this.ExCsharp2 = exCsharp2;
            this.ExCsharp3 = exCsharp3;
        }

        // sacaremos el rico promedio de estos 3 examenes
        public double SacarRicoPromedio()
        {
            if (ExCsharp1 > 100 || ExCsharp2 > 100 || ExCsharp3 > 100) {
                Console.WriteLine("No puedes tener más de 100 papu");
                return 0;
            }
            if (ExCsharp1 < 0 || ExCsharp2 < 0 || ExCsharp3 < 0)
            {
                Console.WriteLine("No puedes tener menos de 100 papu");
                return 0;
            }
            double promMasna = (ExCsharp1 + ExCsharp2 + ExCsharp3) / 3;
            return promMasna;
        }

        // ahora tenemos que hallar como sera calificado el estudiante
        // recordemos que tengo que retornar un strign que seria la califiqueishon
        public string CalcularCalificacion()
        {
            double prom = SacarRicoPromedio();
            // literal en el doc. ya nos dio como dbeemos hacerlo
            if (prom >= 90){
                return "A";
            } else if (prom >= 80) {
                return "B";
            } else if (prom >= 70) {
                return "C";
            } else if (prom >= 60) {
                return "D";
            } else {
                return "F";
            }
        }

        public string isReprobado() {
            if (CalcularCalificacion() == "F") {
                return "Reprobaste como todo en la vida.";
            } else {
                return "Aprobaste, por esta vez.";
            }
        }
    }
}
