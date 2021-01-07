using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_Ex8
{
    abstract class Checks
    {
        // clase abstracta para los metodos de comprobación de persona

        protected string checkNombre(string nombre)
        {
            // Comprobador de que el nombre no esté vacio ni tenga números.
            string numeros = "0123456789";
            string nombreCorrecto = nombre;
            while (nombreCorrecto.Length <= 0 && (nombreCorrecto.IndexOf(numeros) < 0))
            {
                Console.WriteLine("ERROR: El nombre {0} no puede estar vacio o contener números", nombreCorrecto);
                Console.WriteLine("Introduzca otra vez el nombre: ");
                nombreCorrecto = Console.ReadLine();
            }
            return nombreCorrecto;
        }

        protected int checkEdad(int edad, string nombre)
        {
            // Comprobador de que la edad sea un número entero
            int edadCorrecta = edad;
            while (edadCorrecta <= 0 || edadCorrecta >= 80)
            {
                Console.WriteLine("ERROR: La edad de {0} debe ser mayor que 0 y menor de 80 sin decimales", nombre);
                Console.WriteLine("Introduzca otra vez la edad: ");
                edadCorrecta = Convert.ToInt32(Console.ReadLine());
            }
            return edadCorrecta;
        }

        protected char checkSexo(char sexo, string nombre)
        {
            // comprueba si sexo es m o f, si no, 
            char sexoCorrecto = sexo;
            while (sexoCorrecto != 'M' && sexoCorrecto != 'F')
            {
                Console.WriteLine("ERROR: El sexo de {0} debe ser 'M' (masculino) o 'F' (femenino). Introduzca el sexo correcto: ", nombre);
                sexoCorrecto = Convert.ToChar(Console.ReadLine());
            }
            return sexoCorrecto;
        }
    }
}
