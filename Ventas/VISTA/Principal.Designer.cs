namespace VISTA
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.tbcPrincipal = new System.Windows.Forms.TabControl();
            this.Venta = new System.Windows.Forms.TabPage();
            this.tbcSecVenta = new System.Windows.Forms.TabControl();
            this.Registro = new System.Windows.Forms.TabPage();
            this.txtVcant = new System.Windows.Forms.TextBox();
            this.txtVcostPro = new System.Windows.Forms.TextBox();
            this.lblVCant = new System.Windows.Forms.Label();
            this.txtVnomPro = new System.Windows.Forms.TextBox();
            this.lblVcostoPro = new System.Windows.Forms.Label();
            this.txtVnomC = new System.Windows.Forms.TextBox();
            this.lblVnomPro = new System.Windows.Forms.Label();
            this.txtVidC = new System.Windows.Forms.TextBox();
            this.lblVidVentas = new System.Windows.Forms.Label();
            this.lblVidV = new System.Windows.Forms.Label();
            this.lblVnomC = new System.Windows.Forms.Label();
            this.lblVIdC = new System.Windows.Forms.Label();
            this.Mostrar = new System.Windows.Forms.TabPage();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.Clientes = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.RegistroCliente = new System.Windows.Forms.TabPage();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbnCcancelar = new System.Windows.Forms.Button();
            this.btnCagregar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblIDC = new System.Windows.Forms.Label();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.MostrarClientes = new System.Windows.Forms.TabPage();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.ModificarCliente = new System.Windows.Forms.TabPage();
            this.txtMidcliente = new System.Windows.Forms.TextBox();
            this.lblMdireccion = new System.Windows.Forms.Label();
            this.lblNemail = new System.Windows.Forms.Label();
            this.lblMnombre = new System.Windows.Forms.Label();
            this.btnCMcancelar = new System.Windows.Forms.Button();
            this.btnCconfirmar = new System.Windows.Forms.Button();
            this.txtMdireccion = new System.Windows.Forms.TextBox();
            this.txtMemail = new System.Windows.Forms.TextBox();
            this.txtMnombre = new System.Windows.Forms.TextBox();
            this.lblMidcliente = new System.Windows.Forms.Label();
            this.Menú = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.registroDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.registroDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTodoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton4 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dtpVfecha = new System.Windows.Forms.DateTimePicker();
            this.lblVFecha = new System.Windows.Forms.Label();
            this.btnVcancelar = new System.Windows.Forms.Button();
            this.btnVaceptar = new System.Windows.Forms.Button();
            this.Consultas = new System.Windows.Forms.TabPage();
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnVconsultar = new System.Windows.Forms.Button();
            this.tbcPrincipal.SuspendLayout();
            this.Venta.SuspendLayout();
            this.tbcSecVenta.SuspendLayout();
            this.Registro.SuspendLayout();
            this.Mostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.Clientes.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.RegistroCliente.SuspendLayout();
            this.MostrarClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.ModificarCliente.SuspendLayout();
            this.Menú.SuspendLayout();
            this.Consultas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcPrincipal
            // 
            this.tbcPrincipal.Controls.Add(this.Venta);
            this.tbcPrincipal.Controls.Add(this.Clientes);
            this.tbcPrincipal.Location = new System.Drawing.Point(0, 42);
            this.tbcPrincipal.Name = "tbcPrincipal";
            this.tbcPrincipal.SelectedIndex = 0;
            this.tbcPrincipal.Size = new System.Drawing.Size(800, 403);
            this.tbcPrincipal.TabIndex = 0;
            // 
            // Venta
            // 
            this.Venta.Controls.Add(this.tbcSecVenta);
            this.Venta.Location = new System.Drawing.Point(4, 26);
            this.Venta.Name = "Venta";
            this.Venta.Padding = new System.Windows.Forms.Padding(3);
            this.Venta.Size = new System.Drawing.Size(792, 373);
            this.Venta.TabIndex = 0;
            this.Venta.Text = "Ventas";
            this.Venta.UseVisualStyleBackColor = true;
            // 
            // tbcSecVenta
            // 
            this.tbcSecVenta.Controls.Add(this.Registro);
            this.tbcSecVenta.Controls.Add(this.Mostrar);
            this.tbcSecVenta.Controls.Add(this.Consultas);
            this.tbcSecVenta.Location = new System.Drawing.Point(0, 0);
            this.tbcSecVenta.Name = "tbcSecVenta";
            this.tbcSecVenta.SelectedIndex = 0;
            this.tbcSecVenta.Size = new System.Drawing.Size(789, 373);
            this.tbcSecVenta.TabIndex = 0;
            this.tbcSecVenta.SelectedIndexChanged += new System.EventHandler(this.tbcSecVenta_SelectedIndexChanged);
            // 
            // Registro
            // 
            this.Registro.BackColor = System.Drawing.Color.RosyBrown;
            this.Registro.Controls.Add(this.btnVcancelar);
            this.Registro.Controls.Add(this.btnVaceptar);
            this.Registro.Controls.Add(this.lblVFecha);
            this.Registro.Controls.Add(this.dtpVfecha);
            this.Registro.Controls.Add(this.txtVcant);
            this.Registro.Controls.Add(this.txtVcostPro);
            this.Registro.Controls.Add(this.lblVCant);
            this.Registro.Controls.Add(this.txtVnomPro);
            this.Registro.Controls.Add(this.lblVcostoPro);
            this.Registro.Controls.Add(this.txtVnomC);
            this.Registro.Controls.Add(this.lblVnomPro);
            this.Registro.Controls.Add(this.txtVidC);
            this.Registro.Controls.Add(this.lblVidVentas);
            this.Registro.Controls.Add(this.lblVidV);
            this.Registro.Controls.Add(this.lblVnomC);
            this.Registro.Controls.Add(this.lblVIdC);
            this.Registro.Location = new System.Drawing.Point(4, 26);
            this.Registro.Name = "Registro";
            this.Registro.Padding = new System.Windows.Forms.Padding(3);
            this.Registro.Size = new System.Drawing.Size(781, 343);
            this.Registro.TabIndex = 0;
            this.Registro.Text = "Registro de Venta";
            // 
            // txtVcant
            // 
            this.txtVcant.Location = new System.Drawing.Point(354, 190);
            this.txtVcant.Name = "txtVcant";
            this.txtVcant.Size = new System.Drawing.Size(100, 22);
            this.txtVcant.TabIndex = 5;
            // 
            // txtVcostPro
            // 
            this.txtVcostPro.Location = new System.Drawing.Point(175, 190);
            this.txtVcostPro.Name = "txtVcostPro";
            this.txtVcostPro.Size = new System.Drawing.Size(100, 22);
            this.txtVcostPro.TabIndex = 4;
            // 
            // lblVCant
            // 
            this.lblVCant.AutoSize = true;
            this.lblVCant.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVCant.Location = new System.Drawing.Point(283, 192);
            this.lblVCant.Name = "lblVCant";
            this.lblVCant.Size = new System.Drawing.Size(64, 17);
            this.lblVCant.TabIndex = 0;
            this.lblVCant.Text = "Cantidad";
            // 
            // txtVnomPro
            // 
            this.txtVnomPro.Location = new System.Drawing.Point(175, 163);
            this.txtVnomPro.Name = "txtVnomPro";
            this.txtVnomPro.Size = new System.Drawing.Size(279, 22);
            this.txtVnomPro.TabIndex = 3;
            this.txtVnomPro.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblVcostoPro
            // 
            this.lblVcostoPro.AutoSize = true;
            this.lblVcostoPro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVcostoPro.Location = new System.Drawing.Point(33, 193);
            this.lblVcostoPro.Name = "lblVcostoPro";
            this.lblVcostoPro.Size = new System.Drawing.Size(127, 17);
            this.lblVcostoPro.TabIndex = 0;
            this.lblVcostoPro.Text = "Costro del Producto";
            // 
            // txtVnomC
            // 
            this.txtVnomC.Location = new System.Drawing.Point(104, 135);
            this.txtVnomC.Name = "txtVnomC";
            this.txtVnomC.Size = new System.Drawing.Size(314, 22);
            this.txtVnomC.TabIndex = 2;
            // 
            // lblVnomPro
            // 
            this.lblVnomPro.AutoSize = true;
            this.lblVnomPro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVnomPro.Location = new System.Drawing.Point(33, 165);
            this.lblVnomPro.Name = "lblVnomPro";
            this.lblVnomPro.Size = new System.Drawing.Size(136, 17);
            this.lblVnomPro.TabIndex = 0;
            this.lblVnomPro.Text = "Nombre del Producto";
            // 
            // txtVidC
            // 
            this.txtVidC.Location = new System.Drawing.Point(104, 107);
            this.txtVidC.Name = "txtVidC";
            this.txtVidC.Size = new System.Drawing.Size(100, 22);
            this.txtVidC.TabIndex = 1;
            // 
            // lblVidVentas
            // 
            this.lblVidVentas.AutoSize = true;
            this.lblVidVentas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVidVentas.Location = new System.Drawing.Point(708, 78);
            this.lblVidVentas.Name = "lblVidVentas";
            this.lblVidVentas.Size = new System.Drawing.Size(43, 17);
            this.lblVidVentas.TabIndex = 0;
            this.lblVidVentas.Text = "00000";
            // 
            // lblVidV
            // 
            this.lblVidV.AutoSize = true;
            this.lblVidV.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVidV.Location = new System.Drawing.Point(637, 78);
            this.lblVidV.Name = "lblVidV";
            this.lblVidV.Size = new System.Drawing.Size(64, 17);
            this.lblVidV.TabIndex = 0;
            this.lblVidV.Text = "Id Ventas";
            // 
            // lblVnomC
            // 
            this.lblVnomC.AutoSize = true;
            this.lblVnomC.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVnomC.Location = new System.Drawing.Point(33, 137);
            this.lblVnomC.Name = "lblVnomC";
            this.lblVnomC.Size = new System.Drawing.Size(56, 17);
            this.lblVnomC.TabIndex = 0;
            this.lblVnomC.Text = "Nombre";
            // 
            // lblVIdC
            // 
            this.lblVIdC.AutoSize = true;
            this.lblVIdC.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVIdC.Location = new System.Drawing.Point(33, 109);
            this.lblVIdC.Name = "lblVIdC";
            this.lblVIdC.Size = new System.Drawing.Size(65, 17);
            this.lblVIdC.TabIndex = 0;
            this.lblVIdC.Text = "Id Cliente";
            // 
            // Mostrar
            // 
            this.Mostrar.BackColor = System.Drawing.Color.RosyBrown;
            this.Mostrar.Controls.Add(this.dgvVentas);
            this.Mostrar.Location = new System.Drawing.Point(4, 26);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Padding = new System.Windows.Forms.Padding(3);
            this.Mostrar.Size = new System.Drawing.Size(781, 343);
            this.Mostrar.TabIndex = 1;
            this.Mostrar.Text = "Mostrar todas las ventas";
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVentas.Location = new System.Drawing.Point(3, 3);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowTemplate.Height = 25;
            this.dgvVentas.Size = new System.Drawing.Size(775, 337);
            this.dgvVentas.TabIndex = 0;
            // 
            // Clientes
            // 
            this.Clientes.Controls.Add(this.tabControl1);
            this.Clientes.Location = new System.Drawing.Point(4, 26);
            this.Clientes.Name = "Clientes";
            this.Clientes.Padding = new System.Windows.Forms.Padding(3);
            this.Clientes.Size = new System.Drawing.Size(792, 373);
            this.Clientes.TabIndex = 1;
            this.Clientes.Text = "Clientes";
            this.Clientes.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.RegistroCliente);
            this.tabControl1.Controls.Add(this.MostrarClientes);
            this.tabControl1.Controls.Add(this.ModificarCliente);
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(789, 373);
            this.tabControl1.TabIndex = 1;
            // 
            // RegistroCliente
            // 
            this.RegistroCliente.BackColor = System.Drawing.Color.RosyBrown;
            this.RegistroCliente.Controls.Add(this.lblDireccion);
            this.RegistroCliente.Controls.Add(this.lblEmail);
            this.RegistroCliente.Controls.Add(this.lblNombre);
            this.RegistroCliente.Controls.Add(this.tbnCcancelar);
            this.RegistroCliente.Controls.Add(this.btnCagregar);
            this.RegistroCliente.Controls.Add(this.txtDireccion);
            this.RegistroCliente.Controls.Add(this.txtEmail);
            this.RegistroCliente.Controls.Add(this.txtNombre);
            this.RegistroCliente.Controls.Add(this.lblIDC);
            this.RegistroCliente.Controls.Add(this.lblIdCliente);
            this.RegistroCliente.Location = new System.Drawing.Point(4, 26);
            this.RegistroCliente.Name = "RegistroCliente";
            this.RegistroCliente.Padding = new System.Windows.Forms.Padding(3);
            this.RegistroCliente.Size = new System.Drawing.Size(781, 343);
            this.RegistroCliente.TabIndex = 0;
            this.RegistroCliente.Text = "Registro de Cliente";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDireccion.Location = new System.Drawing.Point(137, 187);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(87, 19);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(137, 126);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 19);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(137, 66);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 19);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // tbnCcancelar
            // 
            this.tbnCcancelar.BackColor = System.Drawing.Color.Firebrick;
            this.tbnCcancelar.FlatAppearance.BorderSize = 0;
            this.tbnCcancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.tbnCcancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.tbnCcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbnCcancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbnCcancelar.Image = global::VISTA.Properties.Resources.Cancelar;
            this.tbnCcancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbnCcancelar.Location = new System.Drawing.Point(541, 269);
            this.tbnCcancelar.Name = "tbnCcancelar";
            this.tbnCcancelar.Size = new System.Drawing.Size(130, 40);
            this.tbnCcancelar.TabIndex = 5;
            this.tbnCcancelar.Text = "Cancelar";
            this.tbnCcancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tbnCcancelar.UseVisualStyleBackColor = false;
            // 
            // btnCagregar
            // 
            this.btnCagregar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCagregar.FlatAppearance.BorderSize = 0;
            this.btnCagregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnCagregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnCagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCagregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCagregar.Image = global::VISTA.Properties.Resources.Correcto;
            this.btnCagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCagregar.Location = new System.Drawing.Point(355, 269);
            this.btnCagregar.Name = "btnCagregar";
            this.btnCagregar.Size = new System.Drawing.Size(130, 40);
            this.btnCagregar.TabIndex = 4;
            this.btnCagregar.Text = "Agregar";
            this.btnCagregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCagregar.UseVisualStyleBackColor = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.RosyBrown;
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDireccion.ForeColor = System.Drawing.Color.White;
            this.txtDireccion.Location = new System.Drawing.Point(127, 202);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(373, 27);
            this.txtDireccion.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.RosyBrown;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(127, 142);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(373, 27);
            this.txtEmail.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.RosyBrown;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(127, 82);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(373, 27);
            this.txtNombre.TabIndex = 1;
            // 
            // lblIDC
            // 
            this.lblIDC.AutoSize = true;
            this.lblIDC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIDC.Location = new System.Drawing.Point(169, 28);
            this.lblIDC.Name = "lblIDC";
            this.lblIDC.Size = new System.Drawing.Size(0, 19);
            this.lblIDC.TabIndex = 0;
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdCliente.Location = new System.Drawing.Point(54, 28);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(86, 19);
            this.lblIdCliente.TabIndex = 0;
            this.lblIdCliente.Text = "Id Cliente:";
            // 
            // MostrarClientes
            // 
            this.MostrarClientes.BackColor = System.Drawing.Color.RosyBrown;
            this.MostrarClientes.Controls.Add(this.dgvClientes);
            this.MostrarClientes.Location = new System.Drawing.Point(4, 24);
            this.MostrarClientes.Name = "MostrarClientes";
            this.MostrarClientes.Padding = new System.Windows.Forms.Padding(3);
            this.MostrarClientes.Size = new System.Drawing.Size(781, 345);
            this.MostrarClientes.TabIndex = 1;
            this.MostrarClientes.Text = "Mostrar todas los clientes";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.Location = new System.Drawing.Point(3, 3);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowTemplate.Height = 25;
            this.dgvClientes.Size = new System.Drawing.Size(775, 339);
            this.dgvClientes.TabIndex = 0;
            // 
            // ModificarCliente
            // 
            this.ModificarCliente.BackColor = System.Drawing.Color.RosyBrown;
            this.ModificarCliente.Controls.Add(this.txtMidcliente);
            this.ModificarCliente.Controls.Add(this.lblMdireccion);
            this.ModificarCliente.Controls.Add(this.lblNemail);
            this.ModificarCliente.Controls.Add(this.lblMnombre);
            this.ModificarCliente.Controls.Add(this.btnCMcancelar);
            this.ModificarCliente.Controls.Add(this.btnCconfirmar);
            this.ModificarCliente.Controls.Add(this.txtMdireccion);
            this.ModificarCliente.Controls.Add(this.txtMemail);
            this.ModificarCliente.Controls.Add(this.txtMnombre);
            this.ModificarCliente.Controls.Add(this.lblMidcliente);
            this.ModificarCliente.Location = new System.Drawing.Point(4, 26);
            this.ModificarCliente.Name = "ModificarCliente";
            this.ModificarCliente.Padding = new System.Windows.Forms.Padding(3);
            this.ModificarCliente.Size = new System.Drawing.Size(781, 343);
            this.ModificarCliente.TabIndex = 3;
            this.ModificarCliente.Text = "Modificar Cliente";
            // 
            // txtMidcliente
            // 
            this.txtMidcliente.BackColor = System.Drawing.Color.RosyBrown;
            this.txtMidcliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMidcliente.ForeColor = System.Drawing.Color.White;
            this.txtMidcliente.Location = new System.Drawing.Point(170, 28);
            this.txtMidcliente.Name = "txtMidcliente";
            this.txtMidcliente.Size = new System.Drawing.Size(82, 27);
            this.txtMidcliente.TabIndex = 16;
            // 
            // lblMdireccion
            // 
            this.lblMdireccion.AutoSize = true;
            this.lblMdireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMdireccion.Location = new System.Drawing.Point(165, 190);
            this.lblMdireccion.Name = "lblMdireccion";
            this.lblMdireccion.Size = new System.Drawing.Size(87, 19);
            this.lblMdireccion.TabIndex = 12;
            this.lblMdireccion.Text = "Dirección:";
            // 
            // lblNemail
            // 
            this.lblNemail.AutoSize = true;
            this.lblNemail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNemail.Location = new System.Drawing.Point(165, 129);
            this.lblNemail.Name = "lblNemail";
            this.lblNemail.Size = new System.Drawing.Size(56, 19);
            this.lblNemail.TabIndex = 6;
            this.lblNemail.Text = "Email:";
            // 
            // lblMnombre
            // 
            this.lblMnombre.AutoSize = true;
            this.lblMnombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMnombre.Location = new System.Drawing.Point(165, 69);
            this.lblMnombre.Name = "lblMnombre";
            this.lblMnombre.Size = new System.Drawing.Size(77, 19);
            this.lblMnombre.TabIndex = 7;
            this.lblMnombre.Text = "Nombre:";
            // 
            // btnCMcancelar
            // 
            this.btnCMcancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCMcancelar.FlatAppearance.BorderSize = 0;
            this.btnCMcancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnCMcancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnCMcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCMcancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCMcancelar.Image = global::VISTA.Properties.Resources.Cancelar;
            this.btnCMcancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCMcancelar.Location = new System.Drawing.Point(569, 272);
            this.btnCMcancelar.Name = "btnCMcancelar";
            this.btnCMcancelar.Size = new System.Drawing.Size(130, 40);
            this.btnCMcancelar.TabIndex = 15;
            this.btnCMcancelar.Text = "Cancelar";
            this.btnCMcancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCMcancelar.UseVisualStyleBackColor = false;
            // 
            // btnCconfirmar
            // 
            this.btnCconfirmar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCconfirmar.FlatAppearance.BorderSize = 0;
            this.btnCconfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnCconfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnCconfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCconfirmar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCconfirmar.Image = global::VISTA.Properties.Resources.Correcto;
            this.btnCconfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCconfirmar.Location = new System.Drawing.Point(383, 272);
            this.btnCconfirmar.Name = "btnCconfirmar";
            this.btnCconfirmar.Size = new System.Drawing.Size(130, 40);
            this.btnCconfirmar.TabIndex = 14;
            this.btnCconfirmar.Text = "Confirmar";
            this.btnCconfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCconfirmar.UseVisualStyleBackColor = false;
            // 
            // txtMdireccion
            // 
            this.txtMdireccion.BackColor = System.Drawing.Color.RosyBrown;
            this.txtMdireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMdireccion.ForeColor = System.Drawing.Color.White;
            this.txtMdireccion.Location = new System.Drawing.Point(155, 205);
            this.txtMdireccion.Name = "txtMdireccion";
            this.txtMdireccion.Size = new System.Drawing.Size(373, 27);
            this.txtMdireccion.TabIndex = 13;
            // 
            // txtMemail
            // 
            this.txtMemail.BackColor = System.Drawing.Color.RosyBrown;
            this.txtMemail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMemail.ForeColor = System.Drawing.Color.White;
            this.txtMemail.Location = new System.Drawing.Point(155, 145);
            this.txtMemail.Name = "txtMemail";
            this.txtMemail.Size = new System.Drawing.Size(373, 27);
            this.txtMemail.TabIndex = 11;
            // 
            // txtMnombre
            // 
            this.txtMnombre.BackColor = System.Drawing.Color.RosyBrown;
            this.txtMnombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMnombre.ForeColor = System.Drawing.Color.White;
            this.txtMnombre.Location = new System.Drawing.Point(155, 85);
            this.txtMnombre.Name = "txtMnombre";
            this.txtMnombre.Size = new System.Drawing.Size(373, 27);
            this.txtMnombre.TabIndex = 10;
            // 
            // lblMidcliente
            // 
            this.lblMidcliente.AutoSize = true;
            this.lblMidcliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMidcliente.Location = new System.Drawing.Point(82, 31);
            this.lblMidcliente.Name = "lblMidcliente";
            this.lblMidcliente.Size = new System.Drawing.Size(86, 19);
            this.lblMidcliente.TabIndex = 9;
            this.lblMidcliente.Text = "Id Cliente:";
            // 
            // Menú
            // 
            this.Menú.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSplitButton2,
            this.toolStripSplitButton3,
            this.toolStripSplitButton4,
            this.toolStripButton1});
            this.Menú.Location = new System.Drawing.Point(0, 0);
            this.Menú.Name = "Menú";
            this.Menú.Size = new System.Drawing.Size(800, 39);
            this.Menú.TabIndex = 1;
            this.Menú.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.toolStripSplitButton1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripSplitButton1.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripSplitButton1.Image = global::VISTA.Properties.Resources.Info;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(56, 36);
            this.toolStripSplitButton1.Text = "Inicio";
            this.toolStripSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeVentasToolStripMenuItem,
            this.mostrarTodoToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.toolStripSplitButton2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripSplitButton2.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(62, 36);
            this.toolStripSplitButton2.Text = "Ventas";
            this.toolStripSplitButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // registroDeVentasToolStripMenuItem
            // 
            this.registroDeVentasToolStripMenuItem.Name = "registroDeVentasToolStripMenuItem";
            this.registroDeVentasToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.registroDeVentasToolStripMenuItem.Text = "Registro de Ventas";
            // 
            // mostrarTodoToolStripMenuItem
            // 
            this.mostrarTodoToolStripMenuItem.Name = "mostrarTodoToolStripMenuItem";
            this.mostrarTodoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.mostrarTodoToolStripMenuItem.Text = "Mostrar todo";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeClienteToolStripMenuItem,
            this.mostrarTodoToolStripMenuItem1,
            this.modificarClienteToolStripMenuItem,
            this.eliminarClienteToolStripMenuItem});
            this.toolStripSplitButton3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripSplitButton3.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripSplitButton3.Image = global::VISTA.Properties.Resources.TodosBaseDatos;
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(69, 36);
            this.toolStripSplitButton3.Text = "Clientes";
            this.toolStripSplitButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // registroDeClienteToolStripMenuItem
            // 
            this.registroDeClienteToolStripMenuItem.Name = "registroDeClienteToolStripMenuItem";
            this.registroDeClienteToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.registroDeClienteToolStripMenuItem.Text = "Registro de Cliente";
            // 
            // mostrarTodoToolStripMenuItem1
            // 
            this.mostrarTodoToolStripMenuItem1.Name = "mostrarTodoToolStripMenuItem1";
            this.mostrarTodoToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.mostrarTodoToolStripMenuItem1.Text = "Mostrar todo";
            // 
            // modificarClienteToolStripMenuItem
            // 
            this.modificarClienteToolStripMenuItem.Name = "modificarClienteToolStripMenuItem";
            this.modificarClienteToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.modificarClienteToolStripMenuItem.Text = "Modificar Cliente";
            // 
            // eliminarClienteToolStripMenuItem
            // 
            this.eliminarClienteToolStripMenuItem.Name = "eliminarClienteToolStripMenuItem";
            this.eliminarClienteToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.eliminarClienteToolStripMenuItem.Text = "Eliminar Cliente";
            // 
            // toolStripSplitButton4
            // 
            this.toolStripSplitButton4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripSplitButton4.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripSplitButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton4.Image")));
            this.toolStripSplitButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton4.Name = "toolStripSplitButton4";
            this.toolStripSplitButton4.Size = new System.Drawing.Size(134, 36);
            this.toolStripSplitButton4.Text = "toolStripSplitButton4";
            this.toolStripSplitButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripButton1.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripButton1.Image = global::VISTA.Properties.Resources.Salir;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(58, 36);
            this.toolStripButton1.Text = "SALIR";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dtpVfecha
            // 
            this.dtpVfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVfecha.Location = new System.Drawing.Point(647, 32);
            this.dtpVfecha.Name = "dtpVfecha";
            this.dtpVfecha.Size = new System.Drawing.Size(95, 22);
            this.dtpVfecha.TabIndex = 6;
            // 
            // lblVFecha
            // 
            this.lblVFecha.AutoSize = true;
            this.lblVFecha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVFecha.Location = new System.Drawing.Point(666, 12);
            this.lblVFecha.Name = "lblVFecha";
            this.lblVFecha.Size = new System.Drawing.Size(45, 17);
            this.lblVFecha.TabIndex = 7;
            this.lblVFecha.Text = "Fecha";
            // 
            // btnVcancelar
            // 
            this.btnVcancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnVcancelar.FlatAppearance.BorderSize = 0;
            this.btnVcancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnVcancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnVcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVcancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVcancelar.Image = global::VISTA.Properties.Resources.Cancelar;
            this.btnVcancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVcancelar.Location = new System.Drawing.Point(508, 252);
            this.btnVcancelar.Name = "btnVcancelar";
            this.btnVcancelar.Size = new System.Drawing.Size(130, 40);
            this.btnVcancelar.TabIndex = 9;
            this.btnVcancelar.Text = "Cancelar";
            this.btnVcancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVcancelar.UseVisualStyleBackColor = false;
            // 
            // btnVaceptar
            // 
            this.btnVaceptar.BackColor = System.Drawing.Color.Firebrick;
            this.btnVaceptar.FlatAppearance.BorderSize = 0;
            this.btnVaceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnVaceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnVaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVaceptar.Image = global::VISTA.Properties.Resources.Correcto;
            this.btnVaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVaceptar.Location = new System.Drawing.Point(322, 252);
            this.btnVaceptar.Name = "btnVaceptar";
            this.btnVaceptar.Size = new System.Drawing.Size(130, 40);
            this.btnVaceptar.TabIndex = 8;
            this.btnVaceptar.Text = "Agregar";
            this.btnVaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVaceptar.UseVisualStyleBackColor = false;
            // 
            // Consultas
            // 
            this.Consultas.BackColor = System.Drawing.Color.RosyBrown;
            this.Consultas.Controls.Add(this.btnVconsultar);
            this.Consultas.Controls.Add(this.listView1);
            this.Consultas.Controls.Add(this.gbOpciones);
            this.Consultas.Location = new System.Drawing.Point(4, 26);
            this.Consultas.Name = "Consultas";
            this.Consultas.Padding = new System.Windows.Forms.Padding(3);
            this.Consultas.Size = new System.Drawing.Size(781, 343);
            this.Consultas.TabIndex = 2;
            this.Consultas.Text = "Consultas";
            // 
            // gbOpciones
            // 
            this.gbOpciones.Location = new System.Drawing.Point(16, 30);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(217, 233);
            this.gbOpciones.TabIndex = 0;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Buscar por";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(253, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(532, 343);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnVconsultar
            // 
            this.btnVconsultar.BackColor = System.Drawing.Color.Firebrick;
            this.btnVconsultar.FlatAppearance.BorderSize = 0;
            this.btnVconsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnVconsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnVconsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVconsultar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVconsultar.Image = global::VISTA.Properties.Resources.ConsultarIcon;
            this.btnVconsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVconsultar.Location = new System.Drawing.Point(58, 278);
            this.btnVconsultar.Name = "btnVconsultar";
            this.btnVconsultar.Size = new System.Drawing.Size(130, 40);
            this.btnVconsultar.TabIndex = 15;
            this.btnVconsultar.Text = "Consultar";
            this.btnVconsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVconsultar.UseVisualStyleBackColor = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 443);
            this.Controls.Add(this.tbcPrincipal);
            this.Controls.Add(this.Menú);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Principal";
            this.Text = "Principal";
            this.tbcPrincipal.ResumeLayout(false);
            this.Venta.ResumeLayout(false);
            this.tbcSecVenta.ResumeLayout(false);
            this.Registro.ResumeLayout(false);
            this.Registro.PerformLayout();
            this.Mostrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.Clientes.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.RegistroCliente.ResumeLayout(false);
            this.RegistroCliente.PerformLayout();
            this.MostrarClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ModificarCliente.ResumeLayout(false);
            this.ModificarCliente.PerformLayout();
            this.Menú.ResumeLayout(false);
            this.Menú.PerformLayout();
            this.Consultas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tbcPrincipal;
        private TabPage Venta;
        private TabPage Clientes;
        private ToolStrip Menú;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripSplitButton toolStripSplitButton2;
        private ToolStripSplitButton toolStripSplitButton3;
        private ToolStripSplitButton toolStripSplitButton4;
        private ToolStripButton toolStripButton1;
        private TabControl tbcSecVenta;
        private TabPage Registro;
        private TabPage Mostrar;
        private DataGridView dgvVentas;
        private TabControl tabControl1;
        private TabPage RegistroCliente;
        private TabPage MostrarClientes;
        private TabPage ModificarCliente;
        private ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem registroDeVentasToolStripMenuItem;
        private ToolStripMenuItem mostrarTodoToolStripMenuItem;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripMenuItem registroDeClienteToolStripMenuItem;
        private ToolStripMenuItem mostrarTodoToolStripMenuItem1;
        private ToolStripMenuItem modificarClienteToolStripMenuItem;
        private ToolStripMenuItem eliminarClienteToolStripMenuItem;
        private Label lblDireccion;
        private Label lblEmail;
        private Label lblNombre;
        private Button tbnCcancelar;
        private Button btnCagregar;
        private TextBox txtDireccion;
        private TextBox txtEmail;
        private TextBox txtNombre;
        private Label lblIDC;
        private Label lblIdCliente;
        private DataGridView dgvClientes;
        private Label lblMdireccion;
        private Label lblNemail;
        private Label lblMnombre;
        private Button btnCMcancelar;
        private Button btnCconfirmar;
        private TextBox txtMdireccion;
        private TextBox txtMemail;
        private TextBox txtMnombre;
        private Label lblMidcliente;
        private TextBox txtMidcliente;
        private TextBox txtVcant;
        private TextBox txtVcostPro;
        private Label lblVCant;
        private TextBox txtVnomPro;
        private Label lblVcostoPro;
        private TextBox txtVnomC;
        private Label lblVnomPro;
        private TextBox txtVidC;
        private Label lblVidVentas;
        private Label lblVidV;
        private Label lblVnomC;
        private Label lblVIdC;
        private DateTimePicker dtpVfecha;
        private Label lblVFecha;
        private Button btnVcancelar;
        private Button btnVaceptar;
        private TabPage Consultas;
        private GroupBox gbOpciones;
        private Button btnVconsultar;
        private ListView listView1;
    }
}