using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_Ex8
{
    class Alumno : Checks
    {
        //ATRIBUTOS 
        private string nombre;
        private int edad;
        private char sexo;
        private double notaMedia;
        private Boolean novillos;

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
        public double _NotaMedia
        {
            get { return notaMedia; }
            set { notaMedia = value; }
        }
        public Boolean _Novillos
        {
            get { return novillos; }
            set { novillos = value; }
        }

        //CONSTRUCOR
        public Alumno(string nombre, int edad, char sexo, double notaMedia)
        {
            _Nombre = checkNombre(nombre);
            _Edad = checkEdad(edad, nombre);
            _Sexo = checkSexo(sexo, nombre);
            _NotaMedia = checkNotaMedia(notaMedia, nombre);
            _Novillos = hacerNovillos();
        }

        // METODOS
        public override string ToString()
        {
            Console.WriteLine(" Nombre: {0} \n Edad: {1} \n Sexo: {2} \n Nota Media: {3} \n", _Nombre, _Edad, _Sexo, _NotaMedia);
            Console.WriteLine("Alumno disponible: {0}", _Novillos);
            return "";
        }

        private double checkNotaMedia(double nota, string nombre)
        {
            // comprueba que la nota esté entre 0 y 10
            double notaCorrecta = nota;
            while (notaCorrecta < 0 || notaCorrecta > 10)
            {
                Console.WriteLine("ERROR: La nota media de {0} no puede ser ni menor que 0 ni mayor que 10. Introduzca nota de nuevo: ", nombre);
                notaCorrecta = Convert.ToDouble(Console.ReadLine());
            }
            return notaCorrecta;
        }

        private Boolean hacerNovillos()
        {
            // decide aleatoriamente (50%) si el alumno hace pellas o no: numero random del 0 al 100; de 0 a 49 hace pellas, de 50 a 100 no;
            Random quizas = new Random();
            int esta = quizas.Next(0, 101); 

            if (esta < 50)
            {
                return true;
            }
            else
            {
                return false;
            } 
        }


    }
}
