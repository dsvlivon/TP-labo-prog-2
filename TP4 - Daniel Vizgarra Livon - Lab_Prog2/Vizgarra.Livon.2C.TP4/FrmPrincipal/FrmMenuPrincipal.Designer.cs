namespace FrmPrincipal
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.btnCrearArticulo = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.grbGestionProd = new System.Windows.Forms.GroupBox();
            this.grbModifDelete = new System.Windows.Forms.GroupBox();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.btnBorrarArticulo = new System.Windows.Forms.Button();
            this.grbVentas = new System.Windows.Forms.GroupBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblnombreApellido = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.grbArticuloVentas = new System.Windows.Forms.GroupBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtArt = new System.Windows.Forms.Label();
            this.lblSignoPesos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmbArticulo = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.grbFactura = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGenerarFc = new System.Windows.Forms.Button();
            this.rtbOrdenDeCompra = new System.Windows.Forms.RichTextBox();
            this.lblTotalAcumulado = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtNombreApellido = new System.Windows.Forms.TextBox();
            this.cmbNumeroCliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnReporteStock = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.grbGestionProd.SuspendLayout();
            this.grbModifDelete.SuspendLayout();
            this.grbVentas.SuspendLayout();
            this.grbArticuloVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.grbFactura.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrearArticulo
            // 
            this.btnCrearArticulo.Location = new System.Drawing.Point(27, 15);
            this.btnCrearArticulo.Name = "btnCrearArticulo";
            this.btnCrearArticulo.Size = new System.Drawing.Size(138, 41);
            this.btnCrearArticulo.TabIndex = 1;
            this.btnCrearArticulo.Text = "CREAR ARTICULO";
            this.btnCrearArticulo.UseVisualStyleBackColor = true;
            this.btnCrearArticulo.Click += new System.EventHandler(this.btnCrearArticulo_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // grbGestionProd
            // 
            this.grbGestionProd.BackColor = System.Drawing.Color.SteelBlue;
            this.grbGestionProd.Controls.Add(this.grbModifDelete);
            this.grbGestionProd.Location = new System.Drawing.Point(596, 70);
            this.grbGestionProd.Name = "grbGestionProd";
            this.grbGestionProd.Size = new System.Drawing.Size(200, 197);
            this.grbGestionProd.TabIndex = 5;
            this.grbGestionProd.TabStop = false;
            this.grbGestionProd.Text = "GESTION DE PRODUCTOS";
            // 
            // grbModifDelete
            // 
            this.grbModifDelete.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grbModifDelete.Controls.Add(this.btnModificarArticulo);
            this.grbModifDelete.Controls.Add(this.btnBorrarArticulo);
            this.grbModifDelete.Controls.Add(this.btnCrearArticulo);
            this.grbModifDelete.Location = new System.Drawing.Point(6, 19);
            this.grbModifDelete.Name = "grbModifDelete";
            this.grbModifDelete.Size = new System.Drawing.Size(188, 172);
            this.grbModifDelete.TabIndex = 14;
            this.grbModifDelete.TabStop = false;
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.Location = new System.Drawing.Point(27, 69);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(138, 41);
            this.btnModificarArticulo.TabIndex = 4;
            this.btnModificarArticulo.Text = "MODIFICAR";
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // btnBorrarArticulo
            // 
            this.btnBorrarArticulo.Location = new System.Drawing.Point(27, 123);
            this.btnBorrarArticulo.Name = "btnBorrarArticulo";
            this.btnBorrarArticulo.Size = new System.Drawing.Size(138, 41);
            this.btnBorrarArticulo.TabIndex = 4;
            this.btnBorrarArticulo.Text = "BORRAR";
            this.btnBorrarArticulo.UseVisualStyleBackColor = true;
            this.btnBorrarArticulo.Click += new System.EventHandler(this.btnBorrarArticulo_Click);
            // 
            // grbVentas
            // 
            this.grbVentas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbVentas.Controls.Add(this.lblTelefono);
            this.grbVentas.Controls.Add(this.label8);
            this.grbVentas.Controls.Add(this.lblDireccion);
            this.grbVentas.Controls.Add(this.lblDni);
            this.grbVentas.Controls.Add(this.lblnombreApellido);
            this.grbVentas.Controls.Add(this.btnAgregar);
            this.grbVentas.Controls.Add(this.txtDireccion);
            this.grbVentas.Controls.Add(this.txtTelefono);
            this.grbVentas.Controls.Add(this.txtDni);
            this.grbVentas.Controls.Add(this.grbArticuloVentas);
            this.grbVentas.Controls.Add(this.grbFactura);
            this.grbVentas.Controls.Add(this.txtNombreApellido);
            this.grbVentas.Controls.Add(this.cmbNumeroCliente);
            this.grbVentas.Controls.Add(this.label3);
            this.grbVentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grbVentas.Location = new System.Drawing.Point(13, 14);
            this.grbVentas.Name = "grbVentas";
            this.grbVentas.Size = new System.Drawing.Size(498, 291);
            this.grbVentas.TabIndex = 7;
            this.grbVentas.TabStop = false;
            this.grbVentas.Text = "VENTAS";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(8, 146);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 16;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Artículo:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(8, 117);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 16;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(8, 87);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 16;
            this.lblDni.Text = "Dni.:";
            // 
            // lblnombreApellido
            // 
            this.lblnombreApellido.AutoSize = true;
            this.lblnombreApellido.Location = new System.Drawing.Point(8, 56);
            this.lblnombreApellido.Name = "lblnombreApellido";
            this.lblnombreApellido.Size = new System.Drawing.Size(47, 13);
            this.lblnombreApellido.TabIndex = 15;
            this.lblnombreApellido.Text = "Nombre:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(151, 250);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(78, 23);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(72, 141);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(165, 20);
            this.txtDireccion.TabIndex = 14;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(72, 112);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(165, 20);
            this.txtTelefono.TabIndex = 13;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(72, 83);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(165, 20);
            this.txtDni.TabIndex = 9;
            this.txtDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grbArticuloVentas
            // 
            this.grbArticuloVentas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grbArticuloVentas.Controls.Add(this.nudCantidad);
            this.grbArticuloVentas.Controls.Add(this.txtStock);
            this.grbArticuloVentas.Controls.Add(this.lblStock);
            this.grbArticuloVentas.Controls.Add(this.txtArt);
            this.grbArticuloVentas.Controls.Add(this.lblSignoPesos);
            this.grbArticuloVentas.Controls.Add(this.label5);
            this.grbArticuloVentas.Controls.Add(this.txtPrecio);
            this.grbArticuloVentas.Controls.Add(this.txtCodigo);
            this.grbArticuloVentas.Controls.Add(this.cmbArticulo);
            this.grbArticuloVentas.Controls.Add(this.lblCantidad);
            this.grbArticuloVentas.Location = new System.Drawing.Point(8, 175);
            this.grbArticuloVentas.Name = "grbArticuloVentas";
            this.grbArticuloVentas.Size = new System.Drawing.Size(229, 110);
            this.grbArticuloVentas.TabIndex = 12;
            this.grbArticuloVentas.TabStop = false;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(55, 77);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(50, 20);
            this.nudCantidad.TabIndex = 16;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(55, 44);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(50, 20);
            this.txtStock.TabIndex = 15;
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(2, 47);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(38, 13);
            this.lblStock.TabIndex = 9;
            this.lblStock.Text = "Stock:";
            // 
            // txtArt
            // 
            this.txtArt.AutoSize = true;
            this.txtArt.Location = new System.Drawing.Point(144, 17);
            this.txtArt.Name = "txtArt";
            this.txtArt.Size = new System.Drawing.Size(43, 13);
            this.txtArt.TabIndex = 9;
            this.txtArt.Text = "Codigo:";
            // 
            // lblSignoPesos
            // 
            this.lblSignoPesos.AutoSize = true;
            this.lblSignoPesos.Location = new System.Drawing.Point(118, 47);
            this.lblSignoPesos.Name = "lblSignoPesos";
            this.lblSignoPesos.Size = new System.Drawing.Size(49, 13);
            this.lblSignoPesos.TabIndex = 9;
            this.lblSignoPesos.Text = "Precio: $";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Artículo:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(170, 44);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(51, 20);
            this.txtPrecio.TabIndex = 14;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(187, 14);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(35, 20);
            this.txtCodigo.TabIndex = 14;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbArticulo
            // 
            this.cmbArticulo.FormattingEnabled = true;
            this.cmbArticulo.Location = new System.Drawing.Point(55, 13);
            this.cmbArticulo.Name = "cmbArticulo";
            this.cmbArticulo.Size = new System.Drawing.Size(86, 21);
            this.cmbArticulo.TabIndex = 0;
            this.cmbArticulo.SelectedIndexChanged += new System.EventHandler(this.cmbArticulo_SelectedIndexChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(6, 80);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 8;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // grbFactura
            // 
            this.grbFactura.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grbFactura.Controls.Add(this.btnBorrar);
            this.grbFactura.Controls.Add(this.btnGenerarFc);
            this.grbFactura.Controls.Add(this.rtbOrdenDeCompra);
            this.grbFactura.Controls.Add(this.lblTotalAcumulado);
            this.grbFactura.Controls.Add(this.lblTotal);
            this.grbFactura.Location = new System.Drawing.Point(248, 10);
            this.grbFactura.Name = "grbFactura";
            this.grbFactura.Size = new System.Drawing.Size(246, 275);
            this.grbFactura.TabIndex = 12;
            this.grbFactura.TabStop = false;
            this.grbFactura.Text = "ORDEN DE COMPRA";
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Red;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBorrar.Location = new System.Drawing.Point(131, 249);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(67, 23);
            this.btnBorrar.TabIndex = 15;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnGenerarFc
            // 
            this.btnGenerarFc.BackColor = System.Drawing.Color.Lime;
            this.btnGenerarFc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarFc.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGenerarFc.Location = new System.Drawing.Point(204, 249);
            this.btnGenerarFc.Name = "btnGenerarFc";
            this.btnGenerarFc.Size = new System.Drawing.Size(36, 23);
            this.btnGenerarFc.TabIndex = 15;
            this.btnGenerarFc.Text = "OK";
            this.btnGenerarFc.UseVisualStyleBackColor = false;
            this.btnGenerarFc.Click += new System.EventHandler(this.btnGenerarFc_Click);
            // 
            // rtbOrdenDeCompra
            // 
            this.rtbOrdenDeCompra.Location = new System.Drawing.Point(6, 19);
            this.rtbOrdenDeCompra.Name = "rtbOrdenDeCompra";
            this.rtbOrdenDeCompra.Size = new System.Drawing.Size(234, 224);
            this.rtbOrdenDeCompra.TabIndex = 0;
            this.rtbOrdenDeCompra.Text = "";
            // 
            // lblTotalAcumulado
            // 
            this.lblTotalAcumulado.AutoSize = true;
            this.lblTotalAcumulado.Location = new System.Drawing.Point(43, 254);
            this.lblTotalAcumulado.Name = "lblTotalAcumulado";
            this.lblTotalAcumulado.Size = new System.Drawing.Size(13, 13);
            this.lblTotalAcumulado.TabIndex = 8;
            this.lblTotalAcumulado.Text = "--";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(4, 254);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total:";
            // 
            // txtNombreApellido
            // 
            this.txtNombreApellido.Location = new System.Drawing.Point(73, 53);
            this.txtNombreApellido.Name = "txtNombreApellido";
            this.txtNombreApellido.Size = new System.Drawing.Size(164, 20);
            this.txtNombreApellido.TabIndex = 11;
            this.txtNombreApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbNumeroCliente
            // 
            this.cmbNumeroCliente.FormattingEnabled = true;
            this.cmbNumeroCliente.Location = new System.Drawing.Point(73, 23);
            this.cmbNumeroCliente.Name = "cmbNumeroCliente";
            this.cmbNumeroCliente.Size = new System.Drawing.Size(76, 21);
            this.cmbNumeroCliente.TabIndex = 9;
            this.cmbNumeroCliente.SelectedIndexChanged += new System.EventHandler(this.cmbNumeroCliente_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "N° Cliente:";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTimer.Location = new System.Drawing.Point(9, 8);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(55, 20);
            this.lblTimer.TabIndex = 8;
            this.lblTimer.Text = "--:--:--";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnReporteStock
            // 
            this.btnReporteStock.Location = new System.Drawing.Point(609, 277);
            this.btnReporteStock.Name = "btnReporteStock";
            this.btnReporteStock.Size = new System.Drawing.Size(170, 23);
            this.btnReporteStock.TabIndex = 13;
            this.btnReporteStock.Text = "REPORTE STOCK";
            this.btnReporteStock.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.lblTimer);
            this.groupBox1.Location = new System.Drawing.Point(596, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 28);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(806, 315);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReporteStock);
            this.Controls.Add(this.grbVentas);
            this.Controls.Add(this.grbGestionProd);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP4 - Sistema de Venta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbGestionProd.ResumeLayout(false);
            this.grbModifDelete.ResumeLayout(false);
            this.grbVentas.ResumeLayout(false);
            this.grbVentas.PerformLayout();
            this.grbArticuloVentas.ResumeLayout(false);
            this.grbArticuloVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.grbFactura.ResumeLayout(false);
            this.grbFactura.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCrearArticulo;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox grbGestionProd;
        private System.Windows.Forms.GroupBox grbVentas;
        private System.Windows.Forms.ComboBox cmbNumeroCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbModifDelete;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.GroupBox grbFactura;
        private System.Windows.Forms.TextBox txtNombreApellido;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnReporteStock;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox grbArticuloVentas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbArticulo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.RichTextBox rtbOrdenDeCompra;
        private System.Windows.Forms.Button btnGenerarFc;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblSignoPesos;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblnombreApellido;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalAcumulado;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label txtArt;
        private System.Windows.Forms.Button btnBorrarArticulo;
        private System.Windows.Forms.Button btnModificarArticulo;
    }
}

