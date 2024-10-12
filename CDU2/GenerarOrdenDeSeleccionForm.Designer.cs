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
            label5 = new Label();
            label4 = new Label();
            FechaTextBox = new TextBox();
            PrioridadTextBox = new TextBox();
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
            OrdenDeSeleccion2ListView = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            AgregarTodasButton = new Button();
            AgregarSeleccionadasButton = new Button();
            QuitarSeleccionadasButton = new Button();
            QuitarTodasButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(727, 13);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 0;
            label1.Text = "ORDEN DE SELECCIÓN N°";
            // 
            // IDOSTextBox
            // 
            IDOSTextBox.Location = new Point(891, 11);
            IDOSTextBox.Margin = new Padding(3, 2, 3, 2);
            IDOSTextBox.Name = "IDOSTextBox";
            IDOSTextBox.Size = new Size(110, 23);
            IDOSTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(FechaTextBox);
            groupBox1.Controls.Add(PrioridadTextBox);
            groupBox1.Controls.Add(ReiniciarFiltroButton);
            groupBox1.Controls.Add(FiltrarButton);
            groupBox1.Controls.Add(IDOPTextBox);
            groupBox1.Controls.Add(IDClienteTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(29, 46);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(972, 91);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtrar Por:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(377, 48);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 11;
            label5.Text = "Prioridad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(377, 20);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 10;
            label4.Text = "Fecha de Entrega";
            // 
            // FechaTextBox
            // 
            FechaTextBox.Location = new Point(498, 20);
            FechaTextBox.Name = "FechaTextBox";
            FechaTextBox.Size = new Size(100, 23);
            FechaTextBox.TabIndex = 9;
            // 
            // PrioridadTextBox
            // 
            PrioridadTextBox.Location = new Point(498, 48);
            PrioridadTextBox.Name = "PrioridadTextBox";
            PrioridadTextBox.Size = new Size(100, 23);
            PrioridadTextBox.TabIndex = 8;
            // 
            // ReiniciarFiltroButton
            // 
            ReiniciarFiltroButton.Location = new Point(822, 45);
            ReiniciarFiltroButton.Margin = new Padding(3, 2, 3, 2);
            ReiniciarFiltroButton.Name = "ReiniciarFiltroButton";
            ReiniciarFiltroButton.Size = new Size(108, 22);
            ReiniciarFiltroButton.TabIndex = 7;
            ReiniciarFiltroButton.Text = "Reiniciar Filtro";
            ReiniciarFiltroButton.UseVisualStyleBackColor = true;
            ReiniciarFiltroButton.Click += ReiniciarFiltroButton_Click;
            // 
            // FiltrarButton
            // 
            FiltrarButton.Location = new Point(822, 13);
            FiltrarButton.Margin = new Padding(3, 2, 3, 2);
            FiltrarButton.Name = "FiltrarButton";
            FiltrarButton.Size = new Size(108, 22);
            FiltrarButton.TabIndex = 6;
            FiltrarButton.Text = "Filtrar";
            FiltrarButton.UseVisualStyleBackColor = true;
            FiltrarButton.Click += FiltrarButton_Click;
            // 
            // IDOPTextBox
            // 
            IDOPTextBox.Location = new Point(239, 48);
            IDOPTextBox.Margin = new Padding(3, 2, 3, 2);
            IDOPTextBox.Name = "IDOPTextBox";
            IDOPTextBox.Size = new Size(110, 23);
            IDOPTextBox.TabIndex = 5;
            // 
            // IDClienteTextBox
            // 
            IDClienteTextBox.Location = new Point(239, 20);
            IDClienteTextBox.Margin = new Padding(3, 2, 3, 2);
            IDClienteTextBox.Name = "IDClienteTextBox";
            IDClienteTextBox.Size = new Size(110, 23);
            IDClienteTextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 48);
            label3.Name = "label3";
            label3.Size = new Size(136, 15);
            label3.TabIndex = 1;
            label3.Text = "ID Orden de Preparación";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 20);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 0;
            label2.Text = "ID Cliente";
            // 
            // OrdenDeSeleccionListView
            // 
            OrdenDeSeleccionListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            OrdenDeSeleccionListView.FullRowSelect = true;
            OrdenDeSeleccionListView.Location = new Point(29, 153);
            OrdenDeSeleccionListView.Margin = new Padding(3, 2, 3, 2);
            OrdenDeSeleccionListView.Name = "OrdenDeSeleccionListView";
            OrdenDeSeleccionListView.Size = new Size(972, 149);
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
            GenerarOrdenButton.Location = new Point(793, 565);
            GenerarOrdenButton.Margin = new Padding(3, 2, 3, 2);
            GenerarOrdenButton.Name = "GenerarOrdenButton";
            GenerarOrdenButton.Size = new Size(108, 22);
            GenerarOrdenButton.TabIndex = 6;
            GenerarOrdenButton.Text = "Generar Orden";
            GenerarOrdenButton.UseVisualStyleBackColor = true;
            GenerarOrdenButton.Click += GenerarOrdenButton_Click;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(907, 565);
            CancelarButton.Margin = new Padding(3, 2, 3, 2);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(94, 22);
            CancelarButton.TabIndex = 7;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            CancelarButton.Click += CancelarButton_Click;
            // 
            // OrdenDeSeleccion2ListView
            // 
            OrdenDeSeleccion2ListView.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            OrdenDeSeleccion2ListView.Location = new Point(29, 347);
            OrdenDeSeleccion2ListView.Name = "OrdenDeSeleccion2ListView";
            OrdenDeSeleccion2ListView.Size = new Size(972, 149);
            OrdenDeSeleccion2ListView.TabIndex = 8;
            OrdenDeSeleccion2ListView.UseCompatibleStateImageBehavior = false;
            OrdenDeSeleccion2ListView.View = View.Details;
            //
            // columnHeader6
            // 
            columnHeader6.DisplayIndex = 0;
            columnHeader6.Text = "N° Orden de Preparación";
            // 
            // columnHeader7
            // 
            columnHeader7.DisplayIndex = 1;
            columnHeader7.Text = "ID Cliente";
            // 
            // columnHeader8
            // 
            columnHeader8.DisplayIndex = 2;
            columnHeader8.Text = "Fecha de Entrega";
            // 
            // columnHeader9
            // 
            columnHeader9.DisplayIndex = 3;
            columnHeader9.Text = "Transportista";
            // 
            // columnHeader10
            // 
            columnHeader10.DisplayIndex = 4;
            columnHeader10.Text = "Prioridad";
            // 
            // AgregarTodasButton
            // 
            AgregarTodasButton.Location = new Point(639, 307);
            AgregarTodasButton.Name = "AgregarTodasButton";
            AgregarTodasButton.Size = new Size(186, 23);
            AgregarTodasButton.TabIndex = 9;
            AgregarTodasButton.Text = "Agregar todas las listadas";
            AgregarTodasButton.UseVisualStyleBackColor = true;
            // 
            // AgregarSeleccionadasButton
            // 
            AgregarSeleccionadasButton.Location = new Point(831, 307);
            AgregarSeleccionadasButton.Name = "AgregarSeleccionadasButton";
            AgregarSeleccionadasButton.Size = new Size(170, 23);
            AgregarSeleccionadasButton.TabIndex = 10;
            AgregarSeleccionadasButton.Text = "Agregar las seleccionadas";
            AgregarSeleccionadasButton.UseVisualStyleBackColor = true;
            // 
            // QuitarSeleccionadasButton
            // 
            QuitarSeleccionadasButton.Location = new Point(831, 503);
            QuitarSeleccionadasButton.Name = "QuitarSeleccionadasButton";
            QuitarSeleccionadasButton.Size = new Size(170, 23);
            QuitarSeleccionadasButton.TabIndex = 11;
            QuitarSeleccionadasButton.Text = "Quitar las seleccionadas";
            QuitarSeleccionadasButton.UseVisualStyleBackColor = true;
            // 
            // QuitarTodasButton
            // 
            QuitarTodasButton.Location = new Point(639, 503);
            QuitarTodasButton.Name = "QuitarTodasButton";
            QuitarTodasButton.Size = new Size(186, 23);
            QuitarTodasButton.TabIndex = 12;
            QuitarTodasButton.Text = "Quitar todas las listadas";
            QuitarTodasButton.UseVisualStyleBackColor = true;
            // 
            // GenerarOrdenDeSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 598);
            Controls.Add(QuitarTodasButton);
            Controls.Add(QuitarSeleccionadasButton);
            Controls.Add(AgregarSeleccionadasButton);
            Controls.Add(AgregarTodasButton);
            Controls.Add(OrdenDeSeleccion2ListView);
            Controls.Add(CancelarButton);
            Controls.Add(GenerarOrdenButton);
            Controls.Add(OrdenDeSeleccionListView);
            Controls.Add(IDOSTextBox);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
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
        private ListView OrdenDeSeleccion2ListView;
        private Button AgregarTodasButton;
        private Button AgregarSeleccionadasButton;
        private Button QuitarSeleccionadasButton;
        private Button QuitarTodasButton;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private Label label5;
        private Label label4;
        private TextBox FechaTextBox;
        private TextBox PrioridadTextBox;
    }
}
