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
            label2 = new Label();
            IDTextBox = new TextBox();
            IDClienteTextBox = new TextBox();
            label3 = new Label();
            TransportistaTextBox = new TextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            ProductosClienteListView = new ListView();
            CodigoDelProducto = new ColumnHeader();
            Descripcion = new ColumnHeader();
            Posicion = new ColumnHeader();
            Cantidad = new ColumnHeader();
            label6 = new Label();
            ProductosSeleccionadosListView = new ListView();
            Codigo = new ColumnHeader();
            DescripcionHeader2 = new ColumnHeader();
            PosicionHeader3 = new ColumnHeader();
            CantidadHeader4 = new ColumnHeader();
            AgregarButton = new Button();
            QuitarButton = new Button();
            numericUpDown1 = new NumericUpDown();
            ConfirmarButton = new Button();
            CancelarButton = new Button();
            IDCliente = new ColumnHeader();
            groupBox1 = new GroupBox();
            button1 = new Button();
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 41);
            label1.Name = "label1";
            label1.Size = new Size(201, 20);
            label1.TabIndex = 0;
            label1.Text = "ID ORDEN DE PREPARACION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 77);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 1;
            label2.Text = "Cliente";
            // 
            // IDTextBox
            // 
            IDTextBox.Enabled = false;
            IDTextBox.Location = new Point(236, 38);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.ReadOnly = true;
            IDTextBox.Size = new Size(125, 27);
            IDTextBox.TabIndex = 2;
            // 
            // IDClienteTextBox
            // 
            IDClienteTextBox.Enabled = false;
            IDClienteTextBox.Location = new Point(236, 74);
            IDClienteTextBox.Name = "IDClienteTextBox";
            IDClienteTextBox.ReadOnly = true;
            IDClienteTextBox.Size = new Size(125, 27);
            IDClienteTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(537, 35);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 4;
            label3.Text = "Transportista";
            // 
            // TransportistaTextBox
            // 
            TransportistaTextBox.Location = new Point(653, 32);
            TransportistaTextBox.Name = "TransportistaTextBox";
            TransportistaTextBox.Size = new Size(125, 27);
            TransportistaTextBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(537, 77);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 6;
            label4.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(653, 77);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(125, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 149);
            label5.Name = "label5";
            label5.Size = new Size(150, 20);
            label5.TabIndex = 8;
            label5.Text = "Productos del Cliente";
            // 
            // ProductosClienteListView
            // 
            ProductosClienteListView.Columns.AddRange(new ColumnHeader[] { CodigoDelProducto, Descripcion, Posicion, Cantidad });
            ProductosClienteListView.FullRowSelect = true;
            ProductosClienteListView.Location = new Point(34, 187);
            ProductosClienteListView.MultiSelect = false;
            ProductosClienteListView.Name = "ProductosClienteListView";
            ProductosClienteListView.Size = new Size(355, 104);
            ProductosClienteListView.TabIndex = 9;
            ProductosClienteListView.UseCompatibleStateImageBehavior = false;
            ProductosClienteListView.View = View.Details;
            ProductosClienteListView.SelectedIndexChanged += ProductosClienteListView_SelectedIndexChanged;
            // 
            // CodigoDelProducto
            // 
            CodigoDelProducto.Text = "Codigo del Producto";
            // 
            // Descripcion
            // 
            Descripcion.Text = "Descripcion";
            // 
            // Posicion
            // 
            Posicion.Text = "Posicion";
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(410, 149);
            label6.Name = "label6";
            label6.Size = new Size(249, 20);
            label6.TabIndex = 10;
            label6.Text = "Productos Seleccionados del Cliente";
            // 
            // ProductosSeleccionadosListView
            // 
            ProductosSeleccionadosListView.Columns.AddRange(new ColumnHeader[] { Codigo, DescripcionHeader2, PosicionHeader3, CantidadHeader4 });
            ProductosSeleccionadosListView.FullRowSelect = true;
            ProductosSeleccionadosListView.Location = new Point(410, 187);
            ProductosSeleccionadosListView.MultiSelect = false;
            ProductosSeleccionadosListView.Name = "ProductosSeleccionadosListView";
            ProductosSeleccionadosListView.Size = new Size(355, 104);
            ProductosSeleccionadosListView.TabIndex = 11;
            ProductosSeleccionadosListView.UseCompatibleStateImageBehavior = false;
            ProductosSeleccionadosListView.View = View.Details;
            // 
            // Codigo
            // 
            Codigo.Text = "Codigo Del Producto";
            // 
            // DescripcionHeader2
            // 
            DescripcionHeader2.Text = "Descripcion";
            // 
            // PosicionHeader3
            // 
            PosicionHeader3.Text = "Posicion";
            // 
            // CantidadHeader4
            // 
            CantidadHeader4.Text = "Cantidad";
            // 
            // AgregarButton
            // 
            AgregarButton.Location = new Point(210, 304);
            AgregarButton.Name = "AgregarButton";
            AgregarButton.Size = new Size(94, 74);
            AgregarButton.TabIndex = 12;
            AgregarButton.Text = "Agregar";
            AgregarButton.UseVisualStyleBackColor = true;
            AgregarButton.Click += AgregarButton_Click;
            // 
            // QuitarButton
            // 
            QuitarButton.Location = new Point(424, 304);
            QuitarButton.Name = "QuitarButton";
            QuitarButton.Size = new Size(107, 74);
            QuitarButton.TabIndex = 13;
            QuitarButton.Text = "Quitar Producto Seleccionado";
            QuitarButton.UseVisualStyleBackColor = true;
            QuitarButton.Click += QuitarButton_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(96, 329);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(88, 27);
            numericUpDown1.TabIndex = 14;
            // 
            // ConfirmarButton
            // 
            ConfirmarButton.Location = new Point(537, 304);
            ConfirmarButton.Name = "ConfirmarButton";
            ConfirmarButton.Size = new Size(96, 74);
            ConfirmarButton.TabIndex = 15;
            ConfirmarButton.Text = "Confirmar Orden de Preparacion";
            ConfirmarButton.UseVisualStyleBackColor = true;
            ConfirmarButton.Click += ConfirmarButton_Click;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(639, 304);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(94, 74);
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
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(CancelarButton);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(ConfirmarButton);
            groupBox1.Controls.Add(IDTextBox);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(IDClienteTextBox);
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
            groupBox1.Location = new Point(50, 396);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1180, 399);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            button1.Location = new Point(899, 331);
            button1.Name = "button1";
            button1.Size = new Size(221, 29);
            button1.TabIndex = 24;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SeleccionarButton
            // 
            SeleccionarButton.Location = new Point(662, 331);
            SeleccionarButton.Name = "SeleccionarButton";
            SeleccionarButton.Size = new Size(221, 29);
            SeleccionarButton.TabIndex = 23;
            SeleccionarButton.Text = "Seleccionar";
            SeleccionarButton.UseVisualStyleBackColor = true;
            // 
            // ClientesListView
            // 
            ClientesListView.Columns.AddRange(new ColumnHeader[] { ID, RZ, CUIT, Direccion, Telefono, Email });
            ClientesListView.FullRowSelect = true;
            ClientesListView.Location = new Point(40, 151);
            ClientesListView.MultiSelect = false;
            ClientesListView.Name = "ClientesListView";
            ClientesListView.Size = new Size(1095, 174);
            ClientesListView.TabIndex = 22;
            ClientesListView.UseCompatibleStateImageBehavior = false;
            ClientesListView.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID cliente";
            // 
            // RZ
            // 
            RZ.Text = "Razon Social";
            // 
            // CUIT
            // 
            CUIT.Text = "CUIT";
            // 
            // Direccion
            // 
            Direccion.Text = "Direccion";
            // 
            // Telefono
            // 
            Telefono.Text = "Telefono";
            // 
            // Email
            // 
            Email.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 114);
            label7.Name = "label7";
            label7.Size = new Size(134, 20);
            label7.TabIndex = 21;
            label7.Text = "Listado de Clientes";
            // 
            // CuitTextBox
            // 
            CuitTextBox.Location = new Point(38, 63);
            CuitTextBox.Name = "CuitTextBox";
            CuitTextBox.Size = new Size(125, 27);
            CuitTextBox.TabIndex = 20;
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(182, 63);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(107, 29);
            BuscarButton.TabIndex = 19;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 37);
            label8.Name = "label8";
            label8.Size = new Size(40, 20);
            label8.TabIndex = 18;
            label8.Text = "CUIT";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(BuscarButton);
            groupBox2.Controls.Add(SeleccionarButton);
            groupBox2.Controls.Add(CuitTextBox);
            groupBox2.Controls.Add(ClientesListView);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(50, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1180, 366);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // GenerarOrdenDePreparacionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1376, 821);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
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
        private Label label2;
        private TextBox IDTextBox;
        private TextBox IDClienteTextBox;
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
        private ColumnHeader Cantidad;
        private ColumnHeader Codigo;
        private ColumnHeader DescripcionHeader2;
        private ColumnHeader PosicionHeader3;
        private ColumnHeader CantidadHeader4;
        private GroupBox groupBox1;
        private Button button1;
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
    }
}
