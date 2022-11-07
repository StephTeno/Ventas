using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEO
{
    public class Clientes
    {
        private string idCliente;
        private string nombre;
        private string email;
        private string direccion;

        public Clientes(string idCliente, string nombre, string email, string direccion)
        {
            this.idCliente = idCliente;
            this.nombre = nombre;
            this.email = email;
            this.direccion = direccion;
        }
        public Clientes() { }
        public string IdCliente { get { return idCliente; } set { idCliente = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }
    }
    
}
