using System;
using System.Collections;


namespace Supermercado
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int dni;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }

        public string mostrarPersona()
        {
            return "Nombre: " + Nombre + " Apellido: " + Apellido
            + " DNI: " + Dni.ToString();
        }


    }
}




