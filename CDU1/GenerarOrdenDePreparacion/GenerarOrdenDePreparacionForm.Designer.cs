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
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 30);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(317, 32);
            label1.TabIndex = 0;
            label1.Text = "ID ORDEN DE PREPARACION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 88);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 32);
            label2.TabIndex = 1;
            label2.Text = "Cliente";
            // 
            // IDTextBox
            // 
            IDTextBox.Enabled = false;
            IDTextBox.Location = new Point(384, 26);
            IDTextBox.Margin = new Padding(5, 5, 5, 5);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.ReadOnly = true;
            IDTextBox.Size = new Size(201, 39);
            IDTextBox.TabIndex = 2;
            // 
            // IDClienteTextBox
            // 
            IDClienteTextBox.Enabled = false;
            IDClienteTextBox.Location = new Point(384, 83);
            IDClienteTextBox.Margin = new Padding(5, 5, 5, 5);
            IDClienteTextBox.Name = "IDClienteTextBox";
            IDClienteTextBox.ReadOnly = true;
            IDClienteTextBox.Size = new Size(201, 39);
            IDClienteTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(873, 21);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(149, 32);
            label3.TabIndex = 4;
            label3.Text = "Transportista";
            // 
            // TransportistaTextBox
            // 
            TransportistaTextBox.Location = new Point(1061, 16);
            TransportistaTextBox.Margin = new Padding(5, 5, 5, 5);
            TransportistaTextBox.Name = "TransportistaTextBox";
            TransportistaTextBox.Size = new Size(201, 39);
            TransportistaTextBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(873, 88);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 32);
            label4.TabIndex = 6;
            label4.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1061, 88);
            dateTimePicker1.Margin = new Padding(5, 5, 5, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(201, 39);
            dateTimePicker1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 203);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(242, 32);
            label5.TabIndex = 8;
            label5.Text = "Productos del Cliente";
            // 
            // ProductosClienteListView
            // 
            ProductosClienteListView.FullRowSelect = true; // Habilitar selección completa de la fila
            ProductosClienteListView.Columns.AddRange(new ColumnHeader[] { IDCliente, CodigoDelProducto, Descripcion, Posicion, Cantidad });
            ProductosClienteListView.Location = new Point(55, 264);
            ProductosClienteListView.Margin = new Padding(5, 5, 5, 5);
            ProductosClienteListView.MultiSelect = false;
            ProductosClienteListView.Name = "ProductosClienteListView";
            ProductosClienteListView.Size = new Size(574, 164);
            ProductosClienteListView.TabIndex = 9;
            ProductosClienteListView.UseCompatibleStateImageBehavior = false;
            ProductosClienteListView.View = View.Details;
            ProductosClienteListView.SelectedIndexChanged += ProductosClienteListView_SelectedIndexChanged; // Evento correcto
            // 
            // CodigoDelProducto
            // 
            CodigoDelProducto.DisplayIndex = 0;
            CodigoDelProducto.Text = "Codigo del Producto";
            // 
            // Descripcion
            // 
            Descripcion.DisplayIndex = 1;
            Descripcion.Text = "Descripcion";
            // 
            // Posicion
            // 
            Posicion.DisplayIndex = 2;
            Posicion.Text = "Posicion";
            // 
            // Cantidad
            // 
            Cantidad.DisplayIndex = 3;
            Cantidad.Text = "Cantidad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(666, 203);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(400, 32);
            label6.TabIndex = 10;
            label6.Text = "Productos Seleccionados del Cliente";
            // 
            // ProductosSeleccionadosListView
            // 
            ProductosSeleccionadosListView.FullRowSelect = true; // Habilitar selección completa de la fila
            ProductosSeleccionadosListView.Columns.AddRange(new ColumnHeader[] { Codigo, DescripcionHeader2, PosicionHeader3, CantidadHeader4 });
            ProductosSeleccionadosListView.Location = new Point(666, 264);
            ProductosSeleccionadosListView.Margin = new Padding(5, 5, 5, 5);
            ProductosSeleccionadosListView.MultiSelect = false;
            ProductosSeleccionadosListView.Name = "ProductosSeleccionadosListView";
            ProductosSeleccionadosListView.Size = new Size(574, 164);
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
            AgregarButton.Location = new Point(341, 451);
            AgregarButton.Margin = new Padding(5, 5, 5, 5);
            AgregarButton.Name = "AgregarButton";
            AgregarButton.Size = new Size(153, 118);
            AgregarButton.TabIndex = 12;
            AgregarButton.Text = "Agregar";
            AgregarButton.UseVisualStyleBackColor = true;
            AgregarButton.Click += AgregarButton_Click;
            // 
            // QuitarButton
            // 
            QuitarButton.Location = new Point(689, 451);
            QuitarButton.Margin = new Padding(5, 5, 5, 5);
            QuitarButton.Name = "QuitarButton";
            QuitarButton.Size = new Size(174, 118);
            QuitarButton.TabIndex = 13;
            QuitarButton.Text = "Quitar Producto Seleccionado";
            QuitarButton.UseVisualStyleBackColor = true;
            QuitarButton.Click += QuitarButton_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(156, 491);
            numericUpDown1.Margin = new Padding(5, 5, 5, 5);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(143, 39);
            numericUpDown1.TabIndex = 14;
            // 
            // ConfirmarButton
            // 
            ConfirmarButton.Location = new Point(873, 451);
            ConfirmarButton.Margin = new Padding(5, 5, 5, 5);
            ConfirmarButton.Name = "ConfirmarButton";
            ConfirmarButton.Size = new Size(156, 118);
            ConfirmarButton.TabIndex = 15;
            ConfirmarButton.Text = "Confirmar Orden de Preparacion";
            ConfirmarButton.UseVisualStyleBackColor = true;
            ConfirmarButton.Click += ConfirmarButton_Click;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(1038, 451);
            CancelarButton.Margin = new Padding(5, 5, 5, 5);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(153, 118);
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
            // GenerarOrdenDePreparacionForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 720);
            Controls.Add(CancelarButton);
            Controls.Add(ConfirmarButton);
            Controls.Add(numericUpDown1);
            Controls.Add(QuitarButton);
            Controls.Add(AgregarButton);
            Controls.Add(ProductosSeleccionadosListView);
            Controls.Add(label6);
            Controls.Add(ProductosClienteListView);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(TransportistaTextBox);
            Controls.Add(label3);
            Controls.Add(IDClienteTextBox);
            Controls.Add(IDTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 5, 5, 5);
            Name = "GenerarOrdenDePreparacionForm";
            Text = "Generar Orden De Preparacion";
            Load += GenerarOrdenDePreparacionForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}
