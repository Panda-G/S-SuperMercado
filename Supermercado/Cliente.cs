using System;
using System.Collections;


namespace Supermercado
{
    public class Cliente : Persona
    {
        private string nacimiento = null;

        public string getNacimiento()
        {
            return this.nacimiento;
        }

        public void setNacimiento(string nuevoNacimiento)
        {
            this.nacimiento = nuevoNacimiento;
        }

        public string mostrarCajero()
        {
            return "Nombre: " + this.Nombre + " Apellido: " + this.Apellido
            + " DNI: " + this.Dni.ToString() + " Fecha de Nacimiento: " + this.getNacimiento();
        }


    }
}




