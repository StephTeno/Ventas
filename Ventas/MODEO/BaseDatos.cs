using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEO
{
    public class BaseDatosVentas
    {
        ArrayList datos = new ArrayList();
        public ArrayList Datos { get { return datos; } set { datos = value; } }
        public void AgregarVenta(Ventas dato)
        {
            datos.Add(dato);
        }
        public Ventas BuscarVentas(string texto)
        {
            Ventas v = new Ventas();
            return v = (Ventas)datos[datos.IndexOf(texto)];
        }
    }
    public class BaseDatosClientes
    {
        ArrayList clientes = new ArrayList();
        public ArrayList Clientes { get { return clientes; } set { clientes = value; } }
        public void AgregarCliente(Clientes dato)
        {
            clientes.Add(dato);
        }
        public void RemoverCliente(int i)
        {
            if (i != -1)
                clientes.RemoveAt(i);
        }
        public Clientes BuscarCliente(string texto)
        {
            Clientes c = new Clientes();
            return c = (Clientes)clientes[clientes.IndexOf(texto)];
        }
        public void EditarCliente(string id, string nombre, string email, string direccion) 
        {
            Clientes c = new Clientes();
            c.Nombre= nombre;
            c.Email = email;
            c.Direccion = direccion;
            Modificar(id, c);
        }
        public void Modificar(string id, Clientes c)
        {
            int aux = 0;
            foreach(Clientes cl in clientes)
            {
                if (cl.IdCliente == id)
                    clientes.Insert(aux, c);
                aux++;
            }
        }
    }
}
