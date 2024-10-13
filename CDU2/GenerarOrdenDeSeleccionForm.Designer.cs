namespace GrupoC.Tp3.CDU2
{
    partial class GenerarOrdenDeSeleccionForm
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
            label1 = new Label();
            IDOSTextBox = new TextBox();
            groupBox1 = new GroupBox();
            PrioridadComboBox = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            ReiniciarFiltroButton = new Button();
            FiltrarButton = new Button();
            IDOPTextBox = new TextBox();
            IDClienteTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            OrdenDeSeleccionListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            GenerarOrdenButton = new Button();
            CancelarButton = new Button();
            AgregarTodasButton = new Button();
            AgregarSeleccionadasButton = new Button();
            QuitarSeleccionadasButton = new Button();
            QuitarTodasButton = new Button();
            OrdenDeSeleccion2ListView = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(831, 17);
            label1.Name = "label1";
            label1.Size = new Size(182, 20);
            label1.TabIndex = 0;
            label1.Text = "ORDEN DE SELECCIÓN N°";
            // 
            // IDOSTextBox
            // 
            IDOSTextBox.Location = new Point(1018, 15);
            IDOSTextBox.Name = "IDOSTextBox";
            IDOSTextBox.Size = new Size(125, 27);
            IDOSTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(PrioridadComboBox);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(ReiniciarFiltroButton);
            groupBox1.Controls.Add(FiltrarButton);
            groupBox1.Controls.Add(IDOPTextBox);
            groupBox1.Controls.Add(IDClienteTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(33, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1111, 121);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtrar Por:";
            // 
            // PrioridadComboBox
            // 
            PrioridadComboBox.FormattingEnabled = true;
            PrioridadComboBox.Items.AddRange(new object[] { "Alta", "Media", "Baja" });
            PrioridadComboBox.Location = new Point(569, 64);
            PrioridadComboBox.Name = "PrioridadComboBox";
            PrioridadComboBox.Size = new Size(114, 28);
            PrioridadComboBox.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(569, 22);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(114, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(431, 64);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 11;
            label5.Text = "Prioridad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(431, 27);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 10;
            label4.Text = "Fecha de Entrega";
            // 
            // ReiniciarFiltroButton
            // 
            ReiniciarFiltroButton.Location = new Point(939, 60);
            ReiniciarFiltroButton.Name = "ReiniciarFiltroButton";
            ReiniciarFiltroButton.Size = new Size(123, 29);
            ReiniciarFiltroButton.TabIndex = 7;
            ReiniciarFiltroButton.Text = "Reiniciar Filtro";
            ReiniciarFiltroButton.UseVisualStyleBackColor = true;
            ReiniciarFiltroButton.Click += ReiniciarFiltroButton_Click;
            // 
            // FiltrarButton
            // 
            FiltrarButton.Location = new Point(939, 17);
            FiltrarButton.Name = "FiltrarButton";
            FiltrarButton.Size = new Size(123, 29);
            FiltrarButton.TabIndex = 6;
            FiltrarButton.Text = "Filtrar";
            FiltrarButton.UseVisualStyleBackColor = true;
            FiltrarButton.Click += FiltrarButton_Click;
            // 
            // IDOPTextBox
            // 
            IDOPTextBox.Location = new Point(273, 64);
            IDOPTextBox.Name = "IDOPTextBox";
            IDOPTextBox.Size = new Size(125, 27);
            IDOPTextBox.TabIndex = 5;
            // 
            // IDClienteTextBox
            // 
            IDClienteTextBox.Location = new Point(273, 27);
            IDClienteTextBox.Name = "IDClienteTextBox";
            IDClienteTextBox.Size = new Size(125, 27);
            IDClienteTextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 64);
            label3.Name = "label3";
            label3.Size = new Size(173, 20);
            label3.TabIndex = 1;
            label3.Text = "ID Orden de Preparación";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 27);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 0;
            label2.Text = "ID Cliente";
            // 
            // OrdenDeSeleccionListView
            // 
            OrdenDeSeleccionListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            OrdenDeSeleccionListView.FullRowSelect = true;
            OrdenDeSeleccionListView.Location = new Point(33, 204);
            OrdenDeSeleccionListView.Name = "OrdenDeSeleccionListView";
            OrdenDeSeleccionListView.Size = new Size(1110, 197);
            OrdenDeSeleccionListView.TabIndex = 5;
            OrdenDeSeleccionListView.UseCompatibleStateImageBehavior = false;
            OrdenDeSeleccionListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "N° Orden de Preparación";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "ID Cliente";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Fecha de entrega";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Transportista";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Prioridad";
            // 
            // GenerarOrdenButton
            // 
            GenerarOrdenButton.Location = new Point(906, 753);
            GenerarOrdenButton.Name = "GenerarOrdenButton";
            GenerarOrdenButton.Size = new Size(123, 29);
            GenerarOrdenButton.TabIndex = 6;
            GenerarOrdenButton.Text = "Generar Orden";
            GenerarOrdenButton.UseVisualStyleBackColor = true;
            GenerarOrdenButton.Click += GenerarOrdenButton_Click;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(1037, 753);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(107, 29);
            CancelarButton.TabIndex = 7;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            CancelarButton.Click += CancelarButton_Click;
            // 
            // AgregarTodasButton
            // 
            AgregarTodasButton.Location = new Point(730, 409);
            AgregarTodasButton.Margin = new Padding(3, 4, 3, 4);
            AgregarTodasButton.Name = "AgregarTodasButton";
            AgregarTodasButton.Size = new Size(213, 31);
            AgregarTodasButton.TabIndex = 9;
            AgregarTodasButton.Text = "Agregar todas las listadas";
            AgregarTodasButton.UseVisualStyleBackColor = true;
            AgregarTodasButton.Click += AgregarTodasButton_Click;
            // 
            // AgregarSeleccionadasButton
            // 
            AgregarSeleccionadasButton.Location = new Point(950, 409);
            AgregarSeleccionadasButton.Margin = new Padding(3, 4, 3, 4);
            AgregarSeleccionadasButton.Name = "AgregarSeleccionadasButton";
            AgregarSeleccionadasButton.Size = new Size(194, 31);
            AgregarSeleccionadasButton.TabIndex = 10;
            AgregarSeleccionadasButton.Text = "Agregar las seleccionadas";
            AgregarSeleccionadasButton.UseVisualStyleBackColor = true;
            AgregarSeleccionadasButton.Click += AgregarSeleccionadasButton_Click;
            // 
            // QuitarSeleccionadasButton
            // 
            QuitarSeleccionadasButton.Location = new Point(950, 671);
            QuitarSeleccionadasButton.Margin = new Padding(3, 4, 3, 4);
            QuitarSeleccionadasButton.Name = "QuitarSeleccionadasButton";
            QuitarSeleccionadasButton.Size = new Size(194, 31);
            QuitarSeleccionadasButton.TabIndex = 11;
            QuitarSeleccionadasButton.Text = "Quitar las seleccionadas";
            QuitarSeleccionadasButton.UseVisualStyleBackColor = true;
            QuitarSeleccionadasButton.Click += QuitarSeleccionadasButton_Click;
            // 
            // QuitarTodasButton
            // 
            QuitarTodasButton.Location = new Point(730, 671);
            QuitarTodasButton.Margin = new Padding(3, 4, 3, 4);
            QuitarTodasButton.Name = "QuitarTodasButton";
            QuitarTodasButton.Size = new Size(213, 31);
            QuitarTodasButton.TabIndex = 12;
            QuitarTodasButton.Text = "Quitar todas las listadas";
            QuitarTodasButton.UseVisualStyleBackColor = true;
            QuitarTodasButton.Click += QuitarTodasButton_Click;
            // 
            // OrdenDeSeleccion2ListView
            // 
            OrdenDeSeleccion2ListView.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            OrdenDeSeleccion2ListView.FullRowSelect = true;
            OrdenDeSeleccion2ListView.Location = new Point(34, 447);
            OrdenDeSeleccion2ListView.Name = "OrdenDeSeleccion2ListView";
            OrdenDeSeleccion2ListView.Size = new Size(1110, 197);
            OrdenDeSeleccion2ListView.TabIndex = 13;
            OrdenDeSeleccion2ListView.UseCompatibleStateImageBehavior = false;
            OrdenDeSeleccion2ListView.View = View.Details;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "N° Orden de Preparación";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "ID Cliente";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Fecha de entrega";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Transportista";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Prioridad";
            // 
            // GenerarOrdenDeSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 797);
            Controls.Add(OrdenDeSeleccion2ListView);
            Controls.Add(QuitarTodasButton);
            Controls.Add(QuitarSeleccionadasButton);
            Controls.Add(AgregarSeleccionadasButton);
            Controls.Add(AgregarTodasButton);
            Controls.Add(CancelarButton);
            Controls.Add(GenerarOrdenButton);
            Controls.Add(OrdenDeSeleccionListView);
            Controls.Add(IDOSTextBox);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "GenerarOrdenDeSeleccionForm";
            Text = "Generar Orden de Selección";
            Load += GenerarOrdenDeSeleccionForm_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox IDOSTextBox;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Button ReiniciarFiltroButton;
        private Button FiltrarButton;
        private TextBox IDOPTextBox;
        private TextBox IDClienteTextBox;
        private ListView OrdenDeSeleccionListView;
        private Button GenerarOrdenButton;
        private Button CancelarButton;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button AgregarTodasButton;
        private Button AgregarSeleccionadasButton;
        private Button QuitarSeleccionadasButton;
        private Button QuitarTodasButton;
        private Label label5;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private ComboBox PrioridadComboBox;
        private ListView OrdenDeSeleccion2ListView;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
    }
}
