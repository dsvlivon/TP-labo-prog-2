namespace FrmPrincipal
{
    partial class FrmFactura
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
            this.components = new System.ComponentModel.Container();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblCli = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.lblLeyendaIva = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblNumeroCliente = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblLeyendaNeto = new System.Windows.Forms.Label();
            this.rtbListadoOC = new System.Windows.Forms.RichTextBox();
            this.lblNetoGravado = new System.Windows.Forms.Label();
            this.lblleyendaTotal = new System.Windows.Forms.Label();
            this.lblIvaTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(8, 16);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(31, 13);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "--:--:--";
            // 
            // lblCli
            // 
            this.lblCli.AutoSize = true;
            this.lblCli.Location = new System.Drawing.Point(4, 93);
            this.lblCli.Name = "lblCli";
            this.lblCli.Size = new System.Drawing.Size(55, 13);
            this.lblCli.TabIndex = 0;
            this.lblCli.Text = "Cliente n°:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(4, 119);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(52, 13);
            this.lblTel.TabIndex = 0;
            this.lblTel.Text = "Telefono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 39);
            this.label6.TabIndex = 1;
            this.label6.Text = "X";
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(215, 119);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(55, 13);
            this.lblDir.TabIndex = 0;
            this.lblDir.Text = "Dirección:";
            // 
            // lblLeyendaIva
            // 
            this.lblLeyendaIva.AutoSize = true;
            this.lblLeyendaIva.Location = new System.Drawing.Point(169, 383);
            this.lblLeyendaIva.Name = "lblLeyendaIva";
            this.lblLeyendaIva.Size = new System.Drawing.Size(57, 13);
            this.lblLeyendaIva.TabIndex = 0;
            this.lblLeyendaIva.Text = "IVA. Total:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(1, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 40);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Factura";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(149, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Cliente n°:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.lblNumeroCliente);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblDireccion);
            this.groupBox1.Controls.Add(this.lblTelefono);
            this.groupBox1.Controls.Add(this.lblNombreCliente);
            this.groupBox1.Controls.Add(this.lblCli);
            this.groupBox1.Controls.Add(this.lblTel);
            this.groupBox1.Controls.Add(this.lblDir);
            this.groupBox1.Location = new System.Drawing.Point(3, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 140);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.lblTimer);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(130, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(292, 85);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tienda XXX";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(149, 168);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Cliente n°:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Artículos de Higiene y Limpieza";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(1, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(128, 53);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(149, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Cliente n°:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(215, 93);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Apellido y Nombre:";
            // 
            // lblNumeroCliente
            // 
            this.lblNumeroCliente.AutoSize = true;
            this.lblNumeroCliente.Location = new System.Drawing.Point(64, 93);
            this.lblNumeroCliente.Name = "lblNumeroCliente";
            this.lblNumeroCliente.Size = new System.Drawing.Size(22, 13);
            this.lblNumeroCliente.TabIndex = 0;
            this.lblNumeroCliente.Text = "xxx";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(317, 119);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(22, 13);
            this.lblDireccion.TabIndex = 0;
            this.lblDireccion.Text = "xxx";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(65, 119);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(22, 13);
            this.lblTelefono.TabIndex = 0;
            this.lblTelefono.Text = "xxx";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(317, 93);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(22, 13);
            this.lblNombreCliente.TabIndex = 0;
            this.lblNombreCliente.Text = "xxx";
            // 
            // lblLeyendaNeto
            // 
            this.lblLeyendaNeto.AutoSize = true;
            this.lblLeyendaNeto.Location = new System.Drawing.Point(7, 383);
            this.lblLeyendaNeto.Name = "lblLeyendaNeto";
            this.lblLeyendaNeto.Size = new System.Drawing.Size(77, 13);
            this.lblLeyendaNeto.TabIndex = 0;
            this.lblLeyendaNeto.Text = "Neto Gravado:";
            // 
            // rtbListadoOC
            // 
            this.rtbListadoOC.Location = new System.Drawing.Point(2, 140);
            this.rtbListadoOC.Name = "rtbListadoOC";
            this.rtbListadoOC.Size = new System.Drawing.Size(423, 237);
            this.rtbListadoOC.TabIndex = 3;
            this.rtbListadoOC.Text = "";
           
            // 
            // lblNetoGravado
            // 
            this.lblNetoGravado.AutoSize = true;
            this.lblNetoGravado.Location = new System.Drawing.Point(82, 383);
            this.lblNetoGravado.Name = "lblNetoGravado";
            this.lblNetoGravado.Size = new System.Drawing.Size(22, 13);
            this.lblNetoGravado.TabIndex = 0;
            this.lblNetoGravado.Text = "xxx";
            // 
            // lblleyendaTotal
            // 
            this.lblleyendaTotal.AutoSize = true;
            this.lblleyendaTotal.Location = new System.Drawing.Point(323, 383);
            this.lblleyendaTotal.Name = "lblleyendaTotal";
            this.lblleyendaTotal.Size = new System.Drawing.Size(45, 13);
            this.lblleyendaTotal.TabIndex = 0;
            this.lblleyendaTotal.Text = "TOTAL:";
            // 
            // lblIvaTotal
            // 
            this.lblIvaTotal.AutoSize = true;
            this.lblIvaTotal.Location = new System.Drawing.Point(224, 383);
            this.lblIvaTotal.Name = "lblIvaTotal";
            this.lblIvaTotal.Size = new System.Drawing.Size(22, 13);
            this.lblIvaTotal.TabIndex = 0;
            this.lblIvaTotal.Text = "xxx";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(366, 383);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(22, 13);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "xxx";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FrmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.rtbListadoOC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblleyendaTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblNetoGravado);
            this.Controls.Add(this.lblLeyendaIva);
            this.Controls.Add(this.lblIvaTotal);
            this.Controls.Add(this.lblLeyendaNeto);
            this.MaximizeBox = false;
            this.Name = "FrmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblCli;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Label lblLeyendaIva;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblLeyendaNeto;
        private System.Windows.Forms.Label lblNetoGravado;
        private System.Windows.Forms.Label lblleyendaTotal;
        private System.Windows.Forms.Label lblIvaTotal;
        private System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.RichTextBox rtbListadoOC;
        public System.Windows.Forms.Label lblNombreCliente;
        public System.Windows.Forms.Label lblNumeroCliente;
        public System.Windows.Forms.Label lblDireccion;
        public System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Timer timer;
    }
}