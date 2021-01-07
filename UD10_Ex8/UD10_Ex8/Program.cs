using System;
using System.Collections.Generic;

namespace UD10_Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            // PROFESSORES
            string[] p1materias = new string[] { "matematicas", "fisica" };
            Profesor p1 = new Profesor("Gandalf", 45, 'M', p1materias);

            //LISTA DE ALUMOS
            List<Alumno> lista1 = new List<Alumno>();

            // ALUMNOS
            Alumno a1 = new Alumno("Frodo", 18, 'M', 5.8);
            Alumno a2 = new Alumno("Sam", 17, 'M', 3.0);
            Alumno a3 = new Alumno("Merry", 15, 'M', 2.1);
            Alumno a4 = new Alumno("Pipin", 16, 'M', 6.2);
            Alumno a5 = new Alumno("Aragorn", 22, 'M', 5.5);
            Alumno a6 = new Alumno("Legolas", 24, 'M', 7.1);
            Alumno a7 = new Alumno("Gimli", 28, 'M', 7.2);
            Alumno a8 = new Alumno("Boromir", 30, 'M', 4.5);
            Alumno a9 = new Alumno("Elrond", 23, 'M', 6.1);
            Alumno a10 = new Alumno("Galadriel", 14, 'F', 5.9);
            Alumno a11 = new Alumno("Durin", 31, 'M', 9.1);
            Alumno a12 = new Alumno("Thorin", 21, 'M', 7.3);
            Alumno a13 = new Alumno("Sauron", 30, 'M', 4.1);
            Alumno a14 = new Alumno("Boca de Sauron", 18, 'M', 0.5);
            Alumno a15 = new Alumno("Saruman", 31, 'M', 4.5);
            Alumno a16 = new Alumno("Beren", 24, 'M', 6.4);
            Alumno a17 = new Alumno("Lucien", 16, 'F', 6.9);
            Alumno a18 = new Alumno("Theoden", 14, 'M', 8.1);
            Alumno a19 = new Alumno("Gloin", 31, 'M', 10);
            Alumno a20 = new Alumno("Kelebrimbor", 11, 'M', 0);

            // añadimos alumnos a la lista
            lista1.Add(a1);
            lista1.Add(a2);
            lista1.Add(a3);
            lista1.Add(a4);
            lista1.Add(a5);
            lista1.Add(a6);
            lista1.Add(a7);
            lista1.Add(a8);
            lista1.Add(a9);
            lista1.Add(a10);
            lista1.Add(a11);
            lista1.Add(a12);
            lista1.Add(a13);
            lista1.Add(a14);
            lista1.Add(a15);
            lista1.Add(a16);
            lista1.Add(a17);
            lista1.Add(a18);
            lista1.Add(a19);
            lista1.Add(a20);

            // AULA
            Aula aula1 = new Aula(001, 30, "matematicas", p1, lista1);

            aula1.ToString(); //printamos la lista de alumnos


            // revisamos si habra clase, si hay tambien ejecutara el metodo
            // que printa cantidad de personas aprobadas separado por genero
            aula1.habraClase(); 



        }
    }
}
