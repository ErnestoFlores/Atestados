using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandos.Clases
{
    public class Seguros
    {
        // Propiedades
        public int Id_Aseguradora { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string Telefono_1 { get; set; }
        public string Telefono_2 { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Notas { get; set; }

        public Seguros(int id_Aseguradora, string nombre, string domicilio,
                            string telefono_1, string telefono_2, string fax,
                            string email, string notas)
        {
            Id_Aseguradora = id_Aseguradora;
            Nombre = nombre;
            Domicilio = domicilio;
            Telefono_1 = telefono_1;
            Telefono_2 = telefono_2;
            Fax = fax;
            Email = email;
            Notas = notas;
        }
    }
}
