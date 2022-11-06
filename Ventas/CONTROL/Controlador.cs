using MODEO;
namespace CONTROL
{
    public class Controlador
    {
        BaseDatos bd = new BaseDatos();
        Ventas v = new Ventas();
        bool validarNumero = false;

        public void VisualizarVenta(DataGridView dgvDatos)
        {
            dgvDatos.Rows.Add(v.IdVenta, v.NProducto, v.CUnitario, v.Cantidad, v.NCliente, v.FechaVenta);
        }
        public void GuardarVenta(TextBox idven, TextBox npro, TextBox cunit, TextBox cant, TextBox ncli, DateTime fecha, DataGridView dgvDatos)
        {
            v.IdVenta = idven.Text;
            v.NProducto = npro.Text;
            v.CUnitario = Convert.ToDouble(cunit);
            v.Cantidad = Convert.ToInt32(cant);
            v.NCliente = ncli.Text;
            v.FechaVenta = fecha;
            bd.AgregarVenta(v);
            VisualizarVenta(dgvDatos);
            MessageBox.Show("Venta Agregado");
        }
        public void RemoverVentas(int i, DataGridView dgvDatos)
        {
            dgvDatos.Rows.RemoveAt(i);
            bd.RemoverVenta(i);
            MessageBox.Show("Venta Eliminada");
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