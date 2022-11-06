using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace MODEO
{
    public class Ventas
    {
        private string idVenta;
        private string nProducto;//nombre del producto
        private double cUnitario;
        private int cantidad;
        private string nCliente;
        private DateTime fechaVenta;

        public Ventas(string idVenta, string nProducto, double cUnitario, int cantidad, string nCliente, DateTime fechaVenta)
        {
            this.idVenta = idVenta;
            this.nProducto = nProducto;
            this.cUnitario = cUnitario;
            this.cantidad = cantidad;
            this.nCliente = nCliente;
            this.fechaVenta = fechaVenta;
        }
        public Ventas() { }
        public string IdVenta { get { return idVenta; } set { idVenta = value; } }
        public string NProducto { get { return nProducto; } set { nProducto = value; } }
        public double CUnitario { get { return cUnitario; } set { cUnitario = value; } }
        public int Cantidad { get { return cantidad; } set { cantidad = value; } }
        public string NCliente { get { return nCliente; } set { nCliente = value; } }
        public DateTime FechaVenta { get { return fechaVenta; } set { fechaVenta = value; } }
    }
    public class BaseDatos
    {
        ArrayList datos = new ArrayList();
        public void AgregarVenta(Ventas dato)
        {
            datos.Add(dato);
        }

        public void RemoverVenta(int i)
        {
            if (i != -1)
                datos.RemoveAt(i);
        }
        public static void Consulta()
        {

        }
    }
}
