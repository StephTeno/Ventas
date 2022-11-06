namespace VISTA
{
    public partial class Form1 : Form
    {
        int tri=3;
        Thread th;
        public Form1()
        {
            InitializeComponent();
            pbrContinuar.Value = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            tri = 3;
        }

        private void time_Tick(object sender, EventArgs e)
        {
            if (pbrContinuar.Value < 100)
                pbrContinuar.Value++;
            if (pbrContinuar.Value == 100)
            {
                time.Enabled = false;
                th = new Thread(AbrirNuevoFrom);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                this.Close();
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string clave = txtContrase�a.Text;
            if (usuario == "Steph")
            {
                if (clave == "MoneyMoney")
                {
                    time.Enabled = true;
                }
                else { MessageBox.Show("Contrase�a Incorrecto"); txtContrase�a.Clear(); txtContrase�a.Focus(); }
            }
            else { MessageBox.Show("Usuario Incorrecto"); Limpiar(); txtUsuario.Focus(); }
            if (usuario != "Steph" && clave != "MoneyMoney")
            {
                tri--;
                if (tri == 0)
                {
                    MessageBox.Show("Ha llegado al n�mero m�ximo de intentos");
                    this.Close();
                }
            }
        }
        public void Limpiar()
        {
            txtUsuario.Clear();
            txtContrase�a.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void AbrirNuevoFrom()
        {
            Application.Run(new Principal());
        }

        private void Mostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (Mostrar.Checked == true)
                txtContrase�a.PasswordChar = '\0';
            else if (Mostrar.Checked == false)
                txtContrase�a.PasswordChar = '*';
        }
    }
}