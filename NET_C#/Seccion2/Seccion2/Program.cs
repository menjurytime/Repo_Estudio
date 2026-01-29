using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Precalentar el horno");
            Console.WriteLine("2. Mezclar harina y mantequilla");
            Console.WriteLine("3. Agregar azucar y 1 huevo");
            Console.WriteLine("4. Amasar y mezclar");
            Console.WriteLine("5. Darles forma y poner en los moldes");
            Console.WriteLine("6. Hornear durante 10 minutos");

            //Declaracion y asignacion de variables
            int numeroLibros = 120, librosNiños, edad;            
            char salon = 'A';
            string saludo = "tu salon es:", nombreUsuario, entrada;
            double promedioExamen = 9.8;

            //decimal y float van con una letra al final
            decimal promedioDinero = 7.5M;
            float promedioGastos = 7.5F;
            
            List<string> personas = new List<string>;
            


            Console.WriteLine(saludo);
            Console.WriteLine(salon);
            Console.WriteLine(numeroLibros);
            Console.WriteLine(promedioExamen);
            Console.WriteLine(promedioDinero);
            Console.WriteLine(promedioGastos);

            //concatenar cadenas
            Console.WriteLine("El promedio del "+"examen es: {0};  el dinero ganado este mes es de: {1} y los gastos fueron de {2}", promedioExamen, promedioDinero, promedioGastos);
            Console.WriteLine("Hola, buenos dias, " + saludo + salon);

            //leer datos del usuario
            Console.WriteLine("Hola, buenos dias, como te llamas?");
            nombreUsuario = Console.ReadLine();
            Console.WriteLine("Bienvenido " + nombreUsuario);

            //paresear o convertir tipos de datos
            Console.WriteLine("cual es tu edad?");
            entrada = Console.ReadLine();
            edad = Convert.ToInt32(entrada);
            edad = Int32.Parse(entrada);
            Console.WriteLine("tu edad mas 5 años es: {0}",edad + 5);

            //Condicional if else
            if (edad >= 18)
            {
                Console.WriteLine("eres mayor de edad");
            }
            else
            {
                Console.WriteLine("eres menor de edad");
            }

            //Variable tupla, contiene multiples valores
            (string,int,double,string) tuplaDePrueba = ("johan",38,50.5,"tupla de prueba");
            Console.WriteLine(tuplaDePrueba.Item2);
            Console.WriteLine(tuplaDePrueba);


        }
    }
}
