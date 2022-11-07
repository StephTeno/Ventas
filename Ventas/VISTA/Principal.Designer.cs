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
            this.Clientes = new System.Windows.Forms.TabPage();
            this.Menú = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSplitButton4 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tbcSecVenta = new System.Windows.Forms.TabControl();
            this.Registro = new System.Windows.Forms.TabPage();
            this.Mostrar = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.RegistroCliente = new System.Windows.Forms.TabPage();
            this.MostrarClientes = new System.Windows.Forms.TabPage();
            this.ModificarCliente = new System.Windows.Forms.TabPage();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTodoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblIDC = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMdireccion = new System.Windows.Forms.Label();
            this.lblNemail = new System.Windows.Forms.Label();
            this.lblMnombre = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtMdireccion = new System.Windows.Forms.TextBox();
            this.txtMemail = new System.Windows.Forms.TextBox();
            this.txtMnombre = new System.Windows.Forms.TextBox();
            this.lblMid = new System.Windows.Forms.Label();
            this.tbcPrincipal.SuspendLayout();
            this.Venta.SuspendLayout();
            this.Clientes.SuspendLayout();
            this.Menú.SuspendLayout();
            this.tbcSecVenta.SuspendLayout();
            this.Mostrar.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.RegistroCliente.SuspendLayout();
            this.MostrarClientes.SuspendLayout();
            this.ModificarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
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
            // tbcSecVenta
            // 
            this.tbcSecVenta.Controls.Add(this.Registro);
            this.tbcSecVenta.Controls.Add(this.Mostrar);
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
            this.Registro.Location = new System.Drawing.Point(4, 26);
            this.Registro.Name = "Registro";
            this.Registro.Padding = new System.Windows.Forms.Padding(3);
            this.Registro.Size = new System.Drawing.Size(781, 343);
            this.Registro.TabIndex = 0;
            this.Registro.Text = "Registro de Venta";
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
            this.RegistroCliente.Controls.Add(this.button1);
            this.RegistroCliente.Controls.Add(this.btnAgregar);
            this.RegistroCliente.Controls.Add(this.txtDireccion);
            this.RegistroCliente.Controls.Add(this.txtEmail);
            this.RegistroCliente.Controls.Add(this.txtNombre);
            this.RegistroCliente.Controls.Add(this.lblIDC);
            this.RegistroCliente.Controls.Add(this.lblId);
            this.RegistroCliente.Location = new System.Drawing.Point(4, 26);
            this.RegistroCliente.Name = "RegistroCliente";
            this.RegistroCliente.Padding = new System.Windows.Forms.Padding(3);
            this.RegistroCliente.Size = new System.Drawing.Size(781, 343);
            this.RegistroCliente.TabIndex = 0;
            this.RegistroCliente.Text = "Registro de Cliente";
            // 
            // MostrarClientes
            // 
            this.MostrarClientes.BackColor = System.Drawing.Color.RosyBrown;
            this.MostrarClientes.Controls.Add(this.dgvClientes);
            this.MostrarClientes.Location = new System.Drawing.Point(4, 26);
            this.MostrarClientes.Name = "MostrarClientes";
            this.MostrarClientes.Padding = new System.Windows.Forms.Padding(3);
            this.MostrarClientes.Size = new System.Drawing.Size(781, 343);
            this.MostrarClientes.TabIndex = 1;
            this.MostrarClientes.Text = "Mostrar todas los clientes";
            // 
            // ModificarCliente
            // 
            this.ModificarCliente.BackColor = System.Drawing.Color.RosyBrown;
            this.ModificarCliente.Controls.Add(this.lblMdireccion);
            this.ModificarCliente.Controls.Add(this.lblNemail);
            this.ModificarCliente.Controls.Add(this.lblMnombre);
            this.ModificarCliente.Controls.Add(this.button2);
            this.ModificarCliente.Controls.Add(this.btnConfirmar);
            this.ModificarCliente.Controls.Add(this.txtMdireccion);
            this.ModificarCliente.Controls.Add(this.txtMemail);
            this.ModificarCliente.Controls.Add(this.txtMnombre);
            this.ModificarCliente.Controls.Add(this.lblMid);
            this.ModificarCliente.Location = new System.Drawing.Point(4, 26);
            this.ModificarCliente.Name = "ModificarCliente";
            this.ModificarCliente.Padding = new System.Windows.Forms.Padding(3);
            this.ModificarCliente.Size = new System.Drawing.Size(781, 343);
            this.ModificarCliente.TabIndex = 3;
            this.ModificarCliente.Text = "Modificar Cliente";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
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
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.Location = new System.Drawing.Point(3, 3);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowTemplate.Height = 25;
            this.dgvClientes.Size = new System.Drawing.Size(775, 337);
            this.dgvClientes.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblId.Location = new System.Drawing.Point(54, 28);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(86, 19);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id Cliente:";
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
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Firebrick;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Image = global::VISTA.Properties.Resources.Correcto;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(355, 269);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(130, 40);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = global::VISTA.Properties.Resources.Cancelar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(541, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancelar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = global::VISTA.Properties.Resources.Cancelar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(569, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 40);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancelar";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Firebrick;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.Image = global::VISTA.Properties.Resources.Correcto;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(383, 272);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(130, 40);
            this.btnConfirmar.TabIndex = 14;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmar.UseVisualStyleBackColor = false;
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
            // lblMid
            // 
            this.lblMid.AutoSize = true;
            this.lblMid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMid.Location = new System.Drawing.Point(82, 31);
            this.lblMid.Name = "lblMid";
            this.lblMid.Size = new System.Drawing.Size(86, 19);
            this.lblMid.TabIndex = 9;
            this.lblMid.Text = "Id Cliente:";
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
            this.Clientes.ResumeLayout(false);
            this.Menú.ResumeLayout(false);
            this.Menú.PerformLayout();
            this.tbcSecVenta.ResumeLayout(false);
            this.Mostrar.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.RegistroCliente.ResumeLayout(false);
            this.RegistroCliente.PerformLayout();
            this.MostrarClientes.ResumeLayout(false);
            this.ModificarCliente.ResumeLayout(false);
            this.ModificarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
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
        private Button button1;
        private Button btnAgregar;
        private TextBox txtDireccion;
        private TextBox txtEmail;
        private TextBox txtNombre;
        private Label lblIDC;
        private Label lblId;
        private DataGridView dgvClientes;
        private Label lblMdireccion;
        private Label lblNemail;
        private Label lblMnombre;
        private Button button2;
        private Button btnConfirmar;
        private TextBox txtMdireccion;
        private TextBox txtMemail;
        private TextBox txtMnombre;
        private Label lblMid;
    }
}