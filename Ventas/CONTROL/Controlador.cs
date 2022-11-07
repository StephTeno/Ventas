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
        public void ConsultaCont(TextBox NomC, int e)
        {
            switch (e)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    break;
            }
        }
    }
}