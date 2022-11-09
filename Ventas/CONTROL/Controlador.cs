using MODEO;
namespace CONTROL
{
    public class Controlador
    {
        BaseDatosVentas bdventas = new BaseDatosVentas();
        Ventas v = new Ventas();
        BaseDatosClientes bdclientes = new BaseDatosClientes();
        Clientes c = new Clientes();
        bool validarNumero = false;

        public void VisualizarVenta(DataGridView dgvVentas)
        {
            dgvVentas.Rows.Add(v.IdVenta, v.NProducto, v.CUnitario, v.Cantidad, v.IdCliente, v.NCliente, v.FechaVenta);
        }
        public void VisualizarCliente(DataGridView dgvClientes)
        {
            dgvClientes.Rows.Add(c.IdCliente, c.Nombre, c.Email, c.Direccion);
        }
        public void GuardarVenta(TextBox idcli, TextBox idven, TextBox npro, TextBox cunit, TextBox cant, TextBox ncli, DateTime fecha, DataGridView dgvVentas)
        {
            v.IdVenta = idven.Text;
            v.IdCliente = idcli.Text;
            v.NProducto = npro.Text;
            v.CUnitario = Convert.ToDouble(cunit);
            v.Cantidad = Convert.ToInt32(cant);
            v.NCliente = ncli.Text;
            v.FechaVenta = fecha;
            bdventas.AgregarVenta(v);
            VisualizarVenta(dgvVentas);
            MessageBox.Show("Venta Agregado");
        }
        public void GuardarCliente(TextBox idcli, TextBox nomb, TextBox ema, TextBox dir, DataGridView dgvClientes)
        {
            c.IdCliente = idcli.Text;
            c.Nombre = nomb.Text;
            c.Email = ema.Text;
            c.Direccion = dir.Text;
            bdclientes.AgregarCliente(c);
            VisualizarCliente(dgvClientes);
            MessageBox.Show("Cliente Agregado");
        }
        public void RemoverCliente(int i, DataGridView dgvDatos)
        {
            dgvDatos.Rows.RemoveAt(i);
            bdclientes.RemoverCliente(i);
            MessageBox.Show("Cliente Eliminado");
        }
        public void ModificarCliente(TextBox idcli, TextBox nomb, TextBox ema, TextBox dir)
        {
            bdclientes.EditarCliente(idcli.Text, nomb.Text, ema.Text, dir.Text); ;
        }
        public void BuscarCliente(TextBox idcli)
        {
            Clientes e = bdclientes.BuscarCliente(idcli.Text);
        }
        public void ConsultaCliente(TextBox NomC, CheckBox op1, CheckBox op2, CheckBox op3, CheckBox op4, CheckBox op5)
        {
            int e = Consultar(op1, op2, op3, op4, op5);
            switch (e)
            {
                case 1:
                    var Producto = bdventas.Datos.OfType<Ventas>();
                    //var mas = Producto.Where(x=>x.);
                    //var MasVentas= from v in Producto
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }
        }
        public int Consultar(CheckBox op1, CheckBox op2, CheckBox op3, CheckBox op4, CheckBox op5)
        {
            int o;
            if (op1.Checked)
                return o = 1;
            else if (op2.Checked)
                return o = 2;
            else if (op3.Checked)
                return o = 3;
            else if (op4.Checked)
                return o = 4;
            else if (op5.Checked)
                return o = 5;
            return o=0;
        }
    }
}