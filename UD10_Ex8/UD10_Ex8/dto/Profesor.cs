using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_Ex8
{
    class Profesor : Checks
    {
        //ATRIBUTOS 
        private string nombre;
        private int edad;
        private char sexo;
        private string[] materias;
        private Boolean noDisponible;

        //GETTERS Y SETTERS
        public string _Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int _Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public char _Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public string[] _Materias
        {
            get { return materias; }
            set { materias = value; }
        }
        public Boolean _NoDisponible
        {
            get { return noDisponible; }
            set { noDisponible = value; }
        }

        //CONSTRUCOR
        public Profesor(string nombre, int edad, char sexo, string[] materias )
        {
            _Nombre = checkNombre(nombre);
            _Edad = checkEdad(edad, nombre);
            _Sexo = checkSexo(sexo, nombre);
            _Materias = checkMaterias(materias, nombre);
            _NoDisponible = estarDisponible();

        }

        // METODOS
        public override string ToString()
        {
            Console.WriteLine(" Nombre: {0} \n Edad: {1} \n Sexo: {2} \n Materias: {3}", _Nombre, _Edad, _Sexo, string.Join(", ", _Materias));
            Console.WriteLine("Profesor disponible: {0}", _NoDisponible);
            return "";
        }

        protected string[] checkMaterias(string[] materias, string nombre)
        {
            // comprueba que las materias introducidas sean o matematicas o filosofia o fisica
            for (int x = 0; x < materias.Length; x++)
            {
                while ((materias[x] != "matematicas") && (materias[x] != "filosofia") && (materias[x] != "fisica"))
                {
                    Console.WriteLine("ERROR: Profesor {0}: \n Matéria incorrecta: {1} no está entre las materias disponibles (matematicas, filosofia, fisica). Por favor introduzca de nuevo: ", nombre, materias[x]);
                    materias[x] = Console.ReadLine();
                }
            }
            return materias;
        }

        private Boolean estarDisponible()
        {
            // decide aleatoriamente (20%) si el profesor esta disponible o no: numero random del 0 al 100; de 0 a 20 no esta, de 21 a 100 sí esta;
            Random quizas = new Random();
            int esta = quizas.Next(0, 101);

            if (esta < 20)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}
