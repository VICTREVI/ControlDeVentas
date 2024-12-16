namespace ControlDeVentas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtCliente = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblFecha = new Label();
            lblHora = new Label();
            groupBox2 = new GroupBox();
            txtCantidad = new TextBox();
            label8 = new Label();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            lblPrecio = new Label();
            label6 = new Label();
            cobProducto = new ComboBox();
            label5 = new Label();
            lvRegistro = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label7 = new Label();
            lblTotalNeto = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(105, 40);
            label1.Name = "label1";
            label1.Size = new Size(340, 21);
            label1.TabIndex = 0;
            label1.Text = "CONTROL DE VENTA DE PRODUCTOS";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCliente);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(418, 122);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Cliente";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(13, 50);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(394, 23);
            txtCliente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 23);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 0;
            label2.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(469, 112);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(600, 112);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 3;
            label4.Text = "Hora";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(469, 139);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(51, 15);
            lblFecha.TabIndex = 4;
            lblFecha.Text = "lblFecha";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Location = new Point(600, 139);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(46, 15);
            lblHora.TabIndex = 5;
            lblHora.Text = "lblHora";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtCantidad);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(btnRegistrar);
            groupBox2.Controls.Add(btnCancelar);
            groupBox2.Controls.Add(lblPrecio);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cobProducto);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(18, 229);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(770, 97);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos de la Venta";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(347, 50);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(103, 23);
            txtCantidad.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(372, 25);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 11;
            label8.Text = "Cantidad";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(568, 53);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(95, 32);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(568, 16);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 30);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(480, 53);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(53, 15);
            lblPrecio.TabIndex = 7;
            lblPrecio.Text = "lblPrecio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(480, 24);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 7;
            label6.Text = "Precio";
            // 
            // cobProducto
            // 
            cobProducto.FormattingEnabled = true;
            cobProducto.Location = new Point(8, 53);
            cobProducto.Name = "cobProducto";
            cobProducto.Size = new Size(291, 23);
            cobProducto.TabIndex = 8;
            cobProducto.SelectedIndexChanged += cobProducto_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 31);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 7;
            label5.Text = "Producto";
            // 
            // lvRegistro
            // 
            lvRegistro.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lvRegistro.Location = new Point(20, 336);
            lvRegistro.Name = "lvRegistro";
            lvRegistro.Size = new Size(768, 246);
            lvRegistro.TabIndex = 7;
            lvRegistro.UseCompatibleStateImageBehavior = false;
            lvRegistro.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Producto";
            columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Cantidad";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Precio";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "SubTotal";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Descuento";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Neto";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 70;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(600, 596);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 11;
            label7.Text = "Total Neto";
            // 
            // lblTotalNeto
            // 
            lblTotalNeto.AutoSize = true;
            lblTotalNeto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalNeto.Location = new Point(682, 591);
            lblTotalNeto.Name = "lblTotalNeto";
            lblTotalNeto.Size = new Size(106, 21);
            lblTotalNeto.TabIndex = 11;
            lblTotalNeto.Text = "lblTotalNeto";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(476, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 629);
            Controls.Add(pictureBox1);
            Controls.Add(lblTotalNeto);
            Controls.Add(label7);
            Controls.Add(lvRegistro);
            Controls.Add(groupBox2);
            Controls.Add(lblHora);
            Controls.Add(lblFecha);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Control de Ventas de Productos";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtCliente;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblFecha;
        private Label lblHora;
        private GroupBox groupBox2;
        private Label label6;
        private ComboBox cobProducto;
        private Label label5;
        private Button btnRegistrar;
        private Button btnCancelar;
        private Label lblPrecio;
        private ListView lvRegistro;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label7;
        private Label lblTotalNeto;
        private TextBox txtCantidad;
        private Label label8;
        private PictureBox pictureBox1;
    }
}
