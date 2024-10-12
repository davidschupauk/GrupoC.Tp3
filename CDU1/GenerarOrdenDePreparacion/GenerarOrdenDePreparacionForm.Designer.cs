namespace GrupoC.Tp3.CDU1
{
    partial class GenerarOrdenDePreparacionForm
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            IDTextBox = new TextBox();
            label3 = new Label();
            TransportistaTextBox = new TextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            ProductosClienteListView = new ListView();
            CodigoDelProducto = new ColumnHeader();
            Descripcion = new ColumnHeader();
            Posicion = new ColumnHeader();
            label6 = new Label();
            ProductosSeleccionadosListView = new ListView();
            Codigo = new ColumnHeader();
            DescripcionHeader2 = new ColumnHeader();
            PosicionHeader3 = new ColumnHeader();
            AgregarButton = new Button();
            QuitarButton = new Button();
            numericUpDown1 = new NumericUpDown();
            ConfirmarButton = new Button();
            CancelarButton = new Button();
            IDCliente = new ColumnHeader();
            groupBox1 = new GroupBox();
            CantidadLabel = new Label();
            SeleccionarButton = new Button();
            ClientesListView = new ListView();
            ID = new ColumnHeader();
            RZ = new ColumnHeader();
            CUIT = new ColumnHeader();
            Direccion = new ColumnHeader();
            Telefono = new ColumnHeader();
            Email = new ColumnHeader();
            label7 = new Label();
            CuitTextBox = new TextBox();
            BuscarButton = new Button();
            label8 = new Label();
            groupBox2 = new GroupBox();
            LimpiarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 30);
            label1.Name = "label1";
            label1.Size = new Size(158, 15);
            label1.TabIndex = 0;
            label1.Text = "ID ORDEN DE PREPARACION";
            // 
            // IDTextBox
            // 
            IDTextBox.Enabled = false;
            IDTextBox.Location = new Point(223, 27);
            IDTextBox.Margin = new Padding(3, 2, 3, 2);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.ReadOnly = true;
            IDTextBox.Size = new Size(110, 23);
            IDTextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(414, 29);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 4;
            label3.Text = "Transportista";
            // 
            // TransportistaTextBox
            // 
            TransportistaTextBox.Location = new Point(515, 27);
            TransportistaTextBox.Margin = new Padding(3, 2, 3, 2);
            TransportistaTextBox.Name = "TransportistaTextBox";
            TransportistaTextBox.Size = new Size(110, 23);
            TransportistaTextBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(689, 30);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 6;
            label4.Text = "Fecha de Entrega";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(816, 27);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(164, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 68);
            label5.Name = "label5";
            label5.Size = new Size(120, 15);
            label5.TabIndex = 8;
            label5.Text = "Productos del Cliente";
            // 
            // ProductosClienteListView
            // 
            ProductosClienteListView.Columns.AddRange(new ColumnHeader[] { CodigoDelProducto, Descripcion, Posicion });
            ProductosClienteListView.FullRowSelect = true;
            ProductosClienteListView.Location = new Point(33, 85);
            ProductosClienteListView.Margin = new Padding(3, 2, 3, 2);
            ProductosClienteListView.MultiSelect = false;
            ProductosClienteListView.Name = "ProductosClienteListView";
            ProductosClienteListView.Size = new Size(431, 165);
            ProductosClienteListView.TabIndex = 9;
            ProductosClienteListView.UseCompatibleStateImageBehavior = false;
            ProductosClienteListView.View = View.Details;
            ProductosClienteListView.SelectedIndexChanged += ProductosClienteListView_SelectedIndexChanged;
            // 
            // CodigoDelProducto
            // 
            CodigoDelProducto.Text = "Codigo";
            CodigoDelProducto.Width = 122;
            // 
            // Descripcion
            // 
            Descripcion.Text = "Descripcion del Producto";
            Descripcion.Width = 74;
            // 
            // Posicion
            // 
            Posicion.Text = "Posicion";
            Posicion.Width = 57;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(579, 68);
            label6.Name = "label6";
            label6.Size = new Size(198, 15);
            label6.TabIndex = 10;
            label6.Text = "Productos Seleccionados del Cliente";
            // 
            // ProductosSeleccionadosListView
            // 
            ProductosSeleccionadosListView.Columns.AddRange(new ColumnHeader[] { Codigo, DescripcionHeader2, PosicionHeader3 });
            ProductosSeleccionadosListView.FullRowSelect = true;
            ProductosSeleccionadosListView.Location = new Point(579, 85);
            ProductosSeleccionadosListView.Margin = new Padding(3, 2, 3, 2);
            ProductosSeleccionadosListView.MultiSelect = false;
            ProductosSeleccionadosListView.Name = "ProductosSeleccionadosListView";
            ProductosSeleccionadosListView.Size = new Size(401, 165);
            ProductosSeleccionadosListView.TabIndex = 11;
            ProductosSeleccionadosListView.UseCompatibleStateImageBehavior = false;
            ProductosSeleccionadosListView.View = View.Details;
            // 
            // Codigo
            // 
            Codigo.Text = "Codigo";
            Codigo.Width = 123;
            // 
            // DescripcionHeader2
            // 
            DescripcionHeader2.Text = "Descripcion del Producto";
            DescripcionHeader2.Width = 74;
            // 
            // PosicionHeader3
            // 
            PosicionHeader3.Text = "Posicion";
            PosicionHeader3.Width = 57;
            // 
            // AgregarButton
            // 
            AgregarButton.Location = new Point(482, 159);
            AgregarButton.Margin = new Padding(3, 2, 3, 2);
            AgregarButton.Name = "AgregarButton";
            AgregarButton.Size = new Size(81, 30);
            AgregarButton.TabIndex = 12;
            AgregarButton.Text = "Agregar";
            AgregarButton.UseVisualStyleBackColor = true;
            AgregarButton.Click += AgregarButton_Click;
            // 
            // QuitarButton
            // 
            QuitarButton.Location = new Point(482, 193);
            QuitarButton.Margin = new Padding(3, 2, 3, 2);
            QuitarButton.Name = "QuitarButton";
            QuitarButton.Size = new Size(81, 30);
            QuitarButton.TabIndex = 13;
            QuitarButton.Text = "Quitar";
            QuitarButton.UseVisualStyleBackColor = true;
            QuitarButton.Click += QuitarButton_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(482, 132);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(81, 23);
            numericUpDown1.TabIndex = 14;
            // 
            // ConfirmarButton
            // 
            ConfirmarButton.Location = new Point(713, 254);
            ConfirmarButton.Margin = new Padding(3, 2, 3, 2);
            ConfirmarButton.Name = "ConfirmarButton";
            ConfirmarButton.Size = new Size(191, 30);
            ConfirmarButton.TabIndex = 15;
            ConfirmarButton.Text = "Confirmar Orden de Preparacion";
            ConfirmarButton.UseVisualStyleBackColor = true;
            ConfirmarButton.Click += ConfirmarButton_Click;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(910, 254);
            CancelarButton.Margin = new Padding(3, 2, 3, 2);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(70, 30);
            CancelarButton.TabIndex = 16;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            CancelarButton.Click += CancelarButton_Click;
            // 
            // IDCliente
            // 
            IDCliente.DisplayIndex = 4;
            IDCliente.Text = "ID Cliente";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CantidadLabel);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(CancelarButton);
            groupBox1.Controls.Add(ConfirmarButton);
            groupBox1.Controls.Add(IDTextBox);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(QuitarButton);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(AgregarButton);
            groupBox1.Controls.Add(TransportistaTextBox);
            groupBox1.Controls.Add(ProductosSeleccionadosListView);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(ProductosClienteListView);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(44, 297);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1032, 299);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generar Orden de Preparación";
            // 
            // CantidadLabel
            // 
            CantidadLabel.AutoSize = true;
            CantidadLabel.Location = new Point(493, 115);
            CantidadLabel.Name = "CantidadLabel";
            CantidadLabel.Size = new Size(55, 15);
            CantidadLabel.TabIndex = 17;
            CantidadLabel.Text = "Cantidad";
            // 
            // SeleccionarButton
            // 
            SeleccionarButton.Location = new Point(787, 248);
            SeleccionarButton.Margin = new Padding(3, 2, 3, 2);
            SeleccionarButton.Name = "SeleccionarButton";
            SeleccionarButton.Size = new Size(193, 22);
            SeleccionarButton.TabIndex = 23;
            SeleccionarButton.Text = "Seleccionar";
            SeleccionarButton.UseVisualStyleBackColor = true;
            SeleccionarButton.Click += SeleccionarButton_Click;
            // 
            // ClientesListView
            // 
            ClientesListView.Columns.AddRange(new ColumnHeader[] { ID, RZ, CUIT, Direccion, Telefono, Email });
            ClientesListView.FullRowSelect = true;
            ClientesListView.Location = new Point(35, 113);
            ClientesListView.Margin = new Padding(3, 2, 3, 2);
            ClientesListView.MultiSelect = false;
            ClientesListView.Name = "ClientesListView";
            ClientesListView.Size = new Size(945, 132);
            ClientesListView.TabIndex = 22;
            ClientesListView.UseCompatibleStateImageBehavior = false;
            ClientesListView.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID cliente";
            ID.Width = 61;
            // 
            // RZ
            // 
            RZ.Text = "Razon Social";
            RZ.Width = 78;
            // 
            // CUIT
            // 
            CUIT.Text = "CUIT";
            CUIT.Width = 37;
            // 
            // Direccion
            // 
            Direccion.Text = "Direccion";
            Direccion.Width = 62;
            // 
            // Telefono
            // 
            Telefono.Text = "Telefono";
            Telefono.Width = 58;
            // 
            // Email
            // 
            Email.Text = "Email";
            Email.Width = 645;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 86);
            label7.Name = "label7";
            label7.Size = new Size(106, 15);
            label7.TabIndex = 21;
            label7.Text = "Listado de Clientes";
            // 
            // CuitTextBox
            // 
            CuitTextBox.Location = new Point(33, 47);
            CuitTextBox.Margin = new Padding(3, 2, 3, 2);
            CuitTextBox.Name = "CuitTextBox";
            CuitTextBox.Size = new Size(110, 23);
            CuitTextBox.TabIndex = 20;
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(159, 47);
            BuscarButton.Margin = new Padding(3, 2, 3, 2);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(94, 22);
            BuscarButton.TabIndex = 19;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            BuscarButton.Click += BuscarButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 28);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 18;
            label8.Text = "CUIT";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(LimpiarButton);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(BuscarButton);
            groupBox2.Controls.Add(SeleccionarButton);
            groupBox2.Controls.Add(CuitTextBox);
            groupBox2.Controls.Add(ClientesListView);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(44, 18);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(1032, 274);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar Cliente";
            // 
            // LimpiarButton
            // 
            LimpiarButton.Location = new Point(259, 47);
            LimpiarButton.Name = "LimpiarButton";
            LimpiarButton.Size = new Size(75, 23);
            LimpiarButton.TabIndex = 25;
            LimpiarButton.Text = "Limpiar";
            LimpiarButton.UseVisualStyleBackColor = true;
            LimpiarButton.Click += LimpiarButton_Click;
            // 
            // GenerarOrdenDePreparacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 616);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            Name = "GenerarOrdenDePreparacionForm";
            Text = "Generar Orden De Preparacion";
            Load += GenerarOrdenDePreparacionForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox IDTextBox;
        private Label label3;
        private TextBox TransportistaTextBox;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private ListView ProductosClienteListView;
        private Label label6;
        private ListView ProductosSeleccionadosListView;
        private Button AgregarButton;
        private Button QuitarButton;
        private NumericUpDown numericUpDown1;
        private Button ConfirmarButton;
        private Button CancelarButton;
        private ColumnHeader IDCliente;
        private ColumnHeader CodigoDelProducto;
        private ColumnHeader Descripcion;
        private ColumnHeader Posicion;
        private ColumnHeader Codigo;
        private ColumnHeader DescripcionHeader2;
        private ColumnHeader PosicionHeader3;
        private GroupBox groupBox1;
        private Button SeleccionarButton;
        private ListView ClientesListView;
        private ColumnHeader ID;
        private ColumnHeader RZ;
        private ColumnHeader CUIT;
        private ColumnHeader Direccion;
        private ColumnHeader Telefono;
        private ColumnHeader Email;
        private Label label7;
        private TextBox CuitTextBox;
        private Button BuscarButton;
        private Label label8;
        private GroupBox groupBox2;
        private Label CantidadLabel;
        private Button LimpiarButton;
    }
}
