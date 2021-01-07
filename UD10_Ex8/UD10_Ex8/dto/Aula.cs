using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_Ex8
{
    class Aula
    {
        //ATRIBUTOS
        private int identificador;
        private int maxEstudiantes;
        private string destino;
        private Profesor Profesor;
        private List<Alumno> Alumnos;

        // GETTERS Y SETTERS

        public int _Identificador
        {
            get { return identificador; }
            set { identificador = value; }
        }
        public int _MaxEstudiantes
        {
            get { return maxEstudiantes; }
            set { maxEstudiantes = value; }
        }
        public string _Destino
        {
            get { return destino; }
            set { destino = value; }
        }

        // CONSTRUCTOR
        public Aula(int identificador, int maxEstudiantes, string destino, Profesor professor, List<Alumno> alumnos)
        {
            _Identificador = identificador;
            _MaxEstudiantes = comprobadorAlumno(alumnos, maxEstudiantes);
            _Destino = comprobadorDestino(destino);
            Profesor = professor;
            Alumnos = alumnos;
        }

        // METODOS
        public override string ToString()
        {
            int contadorAlumnos = 0;
            Console.WriteLine("--------------------");
            Console.WriteLine("------ AULA {0} ------", _Identificador);
            Console.WriteLine("---- {0} ----", _Destino);
            Console.WriteLine("--------------------");
            Console.WriteLine("Profesor:");
            Console.WriteLine(Profesor.ToString());
            Console.WriteLine("Lista de Alumnos:");
            foreach (Alumno y in Alumnos)
            {
                contadorAlumnos++;
                Console.WriteLine("{0}.- ", contadorAlumnos);
                Console.WriteLine(y.ToString());
            }

            return "";
        }

        private int comprobadorAlumno(List<Alumno> x, int max)
        {
            // comprueba que en la lista haya alumnos y que no se pase del maximo permitido por aula.
            int contadorAlumnos = 0;

            foreach (object y in x)
            {
                contadorAlumnos++;
            }

            if (contadorAlumnos > max)
            {
                Console.WriteLine("ERROR: DEMASIADOS ALUMNOS - REVISE LA LISTA DE ALUMNOS");
                Console.WriteLine("Máximo permitido: {0} - Alumnos en la lista: {1}", max, contadorAlumnos);
            }
            return max;
        }

        private string comprobadorDestino(string destino)
        {
            string x = destino;
            // comprueba que el destino este entre las materias matematicas , filosofia o fisica
            while ((x != "matematicas") && (x != "filosofia") && (x != "fisica"))
            {
                Console.WriteLine("ERROR: Matéria incorrecta: {0} no está entre las materias disponibles (matematicas, filosofia, fisica). Por favor introduzca de nuevo: ", x);
                x = Console.ReadLine();
            }
            return x;
        }

        public void mostrarNotas()
        {
            // mostramos la cantidad de alumnos y alumnas que estan aprobados, separado por genero.

            int hombresAprobados = 0;
            int mujeresAprobadas = 0;

            foreach (Alumno x in Alumnos) // recorre lista alumnos
            {
                if (x._Sexo == 'M') // si el alumno masculono
                {
                    if (x._NotaMedia >= 5)
                    {
                        hombresAprobados++;
                    }
                }
                else
                {
                    if (x._NotaMedia >= 5)
                    {
                        mujeresAprobadas++;
                    }
                }
            }

            Console.WriteLine("Hombres aprobados: {0}", hombresAprobados);
            Console.WriteLine("Mujeres aprobadas: {0}", mujeresAprobadas);

        }

        public Boolean habraClase()
        {
            // determina si habrá clase dependiendo las condiciones: si hay profesor o un 50% de alumnos presentes.

            int asistente = 0;

            if (!Profesor._NoDisponible) //si el profesor no esta
            {
                Console.WriteLine("PROFESOR NO DISPONIBLE, NO HABRÁ CLASES");
                return false;
            }
            else
            {
                foreach (Alumno x in Alumnos) // recorre lista alumnos
                {
                    if (x._Novillos == false) // si el alumno no hace pellas
                    {
                        asistente++;
                    }
                }
                if (asistente > (Alumnos.Count / 2)) // miramos el total de asistentes, si es menor que la mitad
                {
                    Console.WriteLine("HAN FALTADO {0} ESTUDIANTES DE {1}, NO HABRÁ CLASE", asistente, Alumnos.Count);
                    return false;
                }
                else
                {
                    Console.WriteLine("SÍ HABRÁ CLASE");
                    Console.WriteLine("Cantidad Alumnos haciendo novillos: {0} de {1}", asistente, Alumnos.Count);
                    mostrarNotas();
                    return true;
                }
            }
        }
    }
}
