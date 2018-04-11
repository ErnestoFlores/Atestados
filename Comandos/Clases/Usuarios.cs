using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos.Clases
{
    public class Usuarios
    {
        public int Id_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Numero { get; set; }
        public string Passwor { get; set; }
        public string Tipo { get; set; }

        public Usuarios() { }

        public Usuarios(int id_Usu, string nombre, string numero, string passwor, string tipo)
        {
            Id_Usuario = id_Usu;
            Nombre = nombre;
            Numero = numero;
            Passwor = passwor;
            Tipo = tipo;
        }

        public Usuarios(string numero, string passwor, string tipo)
        {
            
            Numero = numero;
            Passwor = passwor;
            Tipo = tipo;
        }


    }
}
