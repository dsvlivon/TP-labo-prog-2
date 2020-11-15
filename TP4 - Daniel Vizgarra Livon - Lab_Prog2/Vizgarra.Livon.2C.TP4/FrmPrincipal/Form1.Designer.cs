namespace FrmPrincipal
{
    partial class Form1
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
            this.btnCrearArticulo = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnBorrarArtículo = new System.Windows.Forms.Button();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.grbGestionProd = new System.Windows.Forms.GroupBox();
            this.grbModifDelete = new System.Windows.Forms.GroupBox();
            this.txtDescripcionArticulo2 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grbVentas = new System.Windows.Forms.GroupBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.grbArticuloVentas = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripcionArticulo = new System.Windows.Forms.TextBox();
            this.cmbArticulo = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.grbFactura = new System.Windows.Forms.GroupBox();
            this.btnGenerarFc = new System.Windows.Forms.Button();
            this.rtbFactura = new System.Windows.Forms.RichTextBox();
            this.txtNombreApellido = new System.Windows.Forms.TextBox();
            this.cmbNumeroCliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnReporteStock = new System.Windows.Forms.Button();
            this.grbGestionProd.SuspendLayout();
            this.grbModifDelete.SuspendLayout();
            this.grbVentas.SuspendLayout();
            this.grbArticuloVentas.SuspendLayout();
            this.grbFactura.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrearArticulo
            // 
            this.btnCrearArticulo.Location = new System.Drawing.Point(15, 19);
            this.btnCrearArticulo.Name = "btnCrearArticulo";
            this.btnCrearArticulo.Size = new System.Drawing.Size(170, 23);
            this.btnCrearArticulo.TabIndex = 1;
            this.btnCrearArticulo.Text = "CREAR";
            this.btnCrearArticulo.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnBorrarArtículo
            // 
            this.btnBorrarArtículo.Location = new System.Drawing.Point(7, 120);
            this.btnBorrarArtículo.Name = "btnBorrarArtículo";
            this.btnBorrarArtículo.Size = new System.Drawing.Size(169, 23);
            this.btnBorrarArtículo.TabIndex = 3;
            this.btnBorrarArtículo.Text = "BORRAR";
            this.btnBorrarArtículo.UseVisualStyleBackColor = true;
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.Location = new System.Drawing.Point(6, 86);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(170, 23);
            this.btnModificarArticulo.TabIndex = 4;
            this.btnModificarArticulo.Text = "MODIFICAR";
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            // 
            // grbGestionProd
            // 
            this.grbGestionProd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grbGestionProd.Controls.Add(this.grbModifDelete);
            this.grbGestionProd.Controls.Add(this.btnCrearArticulo);
            this.grbGestionProd.Location = new System.Drawing.Point(413, 41);
            this.grbGestionProd.Name = "grbGestionProd";
            this.grbGestionProd.Size = new System.Drawing.Size(200, 208);
            this.grbGestionProd.TabIndex = 5;
            this.grbGestionProd.TabStop = false;
            this.grbGestionProd.Text = "GESTION DE PRODUCTOS";
            // 
            // grbModifDelete
            // 
            this.grbModifDelete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grbModifDelete.Controls.Add(this.txtDescripcionArticulo2);
            this.grbModifDelete.Controls.Add(this.comboBox3);
            this.grbModifDelete.Controls.Add(this.btnModificarArticulo);
            this.grbModifDelete.Controls.Add(this.label4);
            this.grbModifDelete.Controls.Add(this.btnBorrarArtículo);
            this.grbModifDelete.Location = new System.Drawing.Point(6, 48);
            this.grbModifDelete.Name = "grbModifDelete";
            this.grbModifDelete.Size = new System.Drawing.Size(188, 151);
            this.grbModifDelete.TabIndex = 14;
            this.grbModifDelete.TabStop = false;
            // 
            // txtDescripcionArticulo2
            // 
            this.txtDescripcionArticulo2.Location = new System.Drawing.Point(7, 53);
            this.txtDescripcionArticulo2.Name = "txtDescripcionArticulo2";
            this.txtDescripcionArticulo2.Size = new System.Drawing.Size(169, 20);
            this.txtDescripcionArticulo2.TabIndex = 16;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(55, 17);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Artíclulo:";
            // 
            // grbVentas
            // 
            this.grbVentas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbVentas.Controls.Add(this.lblTelefono);
            this.grbVentas.Controls.Add(this.label8);
            this.grbVentas.Controls.Add(this.lblDireccion);
            this.grbVentas.Controls.Add(this.lblDni);
            this.grbVentas.Controls.Add(this.lblArticulo);
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
            this.grbVentas.Location = new System.Drawing.Point(9, 6);
            this.grbVentas.Name = "grbVentas";
            this.grbVentas.Size = new System.Drawing.Size(398, 291);
            this.grbVentas.TabIndex = 7;
            this.grbVentas.TabStop = false;
            this.grbVentas.Text = "VENTAS";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(6, 146);
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
            this.lblDireccion.Location = new System.Drawing.Point(6, 117);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 16;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(6, 87);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 16;
            this.lblDni.Text = "Dni.:";
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Location = new System.Drawing.Point(6, 56);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(47, 13);
            this.lblArticulo.TabIndex = 15;
            this.lblArticulo.Text = "Artículo:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(106, 247);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(78, 23);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(63, 141);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(127, 20);
            this.txtDireccion.TabIndex = 14;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(63, 112);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(127, 20);
            this.txtTelefono.TabIndex = 13;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(63, 83);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(127, 20);
            this.txtDni.TabIndex = 9;
            // 
            // grbArticuloVentas
            // 
            this.grbArticuloVentas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grbArticuloVentas.Controls.Add(this.label1);
            this.grbArticuloVentas.Controls.Add(this.label5);
            this.grbArticuloVentas.Controls.Add(this.txtPrecio);
            this.grbArticuloVentas.Controls.Add(this.txtDescripcionArticulo);
            this.grbArticuloVentas.Controls.Add(this.cmbArticulo);
            this.grbArticuloVentas.Controls.Add(this.lblCantidad);
            this.grbArticuloVentas.Controls.Add(this.txtCantidad);
            this.grbArticuloVentas.Location = new System.Drawing.Point(4, 173);
            this.grbArticuloVentas.Name = "grbArticuloVentas";
            this.grbArticuloVentas.Size = new System.Drawing.Size(186, 110);
            this.grbArticuloVentas.TabIndex = 12;
            this.grbArticuloVentas.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Artículo:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(129, 44);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(51, 20);
            this.txtPrecio.TabIndex = 14;
            // 
            // txtDescripcionArticulo
            // 
            this.txtDescripcionArticulo.Location = new System.Drawing.Point(5, 44);
            this.txtDescripcionArticulo.Name = "txtDescripcionArticulo";
            this.txtDescripcionArticulo.Size = new System.Drawing.Size(105, 20);
            this.txtDescripcionArticulo.TabIndex = 14;
            // 
            // cmbArticulo
            // 
            this.cmbArticulo.FormattingEnabled = true;
            this.cmbArticulo.Location = new System.Drawing.Point(61, 13);
            this.cmbArticulo.Name = "cmbArticulo";
            this.cmbArticulo.Size = new System.Drawing.Size(119, 21);
            this.cmbArticulo.TabIndex = 0;
            this.cmbArticulo.SelectedIndexChanged += new System.EventHandler(this.cmbArticulo_SelectedIndexChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(6, 78);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 8;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(59, 76);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(35, 20);
            this.txtCantidad.TabIndex = 0;
            // 
            // grbFactura
            // 
            this.grbFactura.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grbFactura.Controls.Add(this.btnGenerarFc);
            this.grbFactura.Controls.Add(this.rtbFactura);
            this.grbFactura.Location = new System.Drawing.Point(196, 19);
            this.grbFactura.Name = "grbFactura";
            this.grbFactura.Size = new System.Drawing.Size(196, 266);
            this.grbFactura.TabIndex = 12;
            this.grbFactura.TabStop = false;
            this.grbFactura.Text = "FACTURA";
            // 
            // btnGenerarFc
            // 
            this.btnGenerarFc.Location = new System.Drawing.Point(56, 234);
            this.btnGenerarFc.Name = "btnGenerarFc";
            this.btnGenerarFc.Size = new System.Drawing.Size(78, 23);
            this.btnGenerarFc.TabIndex = 15;
            this.btnGenerarFc.Text = "GENERAR";
            this.btnGenerarFc.UseVisualStyleBackColor = true;
            // 
            // rtbFactura
            // 
            this.rtbFactura.Location = new System.Drawing.Point(6, 19);
            this.rtbFactura.Name = "rtbFactura";
            this.rtbFactura.Size = new System.Drawing.Size(184, 205);
            this.rtbFactura.TabIndex = 0;
            this.rtbFactura.Text = "";
            // 
            // txtNombreApellido
            // 
            this.txtNombreApellido.Location = new System.Drawing.Point(63, 53);
            this.txtNombreApellido.Name = "txtNombreApellido";
            this.txtNombreApellido.Size = new System.Drawing.Size(127, 20);
            this.txtNombreApellido.TabIndex = 11;
            this.txtNombreApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbNumeroCliente
            // 
            this.cmbNumeroCliente.FormattingEnabled = true;
            this.cmbNumeroCliente.Location = new System.Drawing.Point(64, 23);
            this.cmbNumeroCliente.Name = "cmbNumeroCliente";
            this.cmbNumeroCliente.Size = new System.Drawing.Size(76, 21);
            this.cmbNumeroCliente.TabIndex = 9;
            this.cmbNumeroCliente.SelectedIndexChanged += new System.EventHandler(this.cmbNumeroCliente_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "N° Cliente:";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(418, 15);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(33, 13);
            this.lblTimer.TabIndex = 8;
            this.lblTimer.Text = "Timer";
            // 
            // btnReporteStock
            // 
            this.btnReporteStock.Location = new System.Drawing.Point(426, 262);
            this.btnReporteStock.Name = "btnReporteStock";
            this.btnReporteStock.Size = new System.Drawing.Size(170, 23);
            this.btnReporteStock.TabIndex = 13;
            this.btnReporteStock.Text = "REPORTE STOCK";
            this.btnReporteStock.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 301);
            this.Controls.Add(this.btnReporteStock);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.grbVentas);
            this.Controls.Add(this.grbGestionProd);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbGestionProd.ResumeLayout(false);
            this.grbModifDelete.ResumeLayout(false);
            this.grbModifDelete.PerformLayout();
            this.grbVentas.ResumeLayout(false);
            this.grbVentas.PerformLayout();
            this.grbArticuloVentas.ResumeLayout(false);
            this.grbArticuloVentas.PerformLayout();
            this.grbFactura.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCrearArticulo;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnBorrarArtículo;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.GroupBox grbGestionProd;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.RichTextBox rtbFactura;
        private System.Windows.Forms.Button btnGenerarFc;
        private System.Windows.Forms.TextBox txtDescripcionArticulo2;
        private System.Windows.Forms.TextBox txtDescripcionArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblArticulo;
    }
}

