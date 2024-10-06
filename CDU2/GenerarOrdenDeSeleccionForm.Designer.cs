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
            FechaDateTimePicker = new DateTimePicker();
            FiltrarButton = new Button();
            label2 = new Label();
            ListadoOPListView = new ListView();
            IDHeader1 = new ColumnHeader();
            ClienteHeader2 = new ColumnHeader();
            FechaHeader3 = new ColumnHeader();
            TransportistaHeader4 = new ColumnHeader();
            EstadoHeader5 = new ColumnHeader();
            GenerarButton = new Button();
            CancelarButton = new Button();
            label3 = new Label();
            IDOSTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 20);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha ";
            // 
            // FechaDateTimePicker
            // 
            FechaDateTimePicker.Location = new Point(28, 46);
            FechaDateTimePicker.Margin = new Padding(3, 2, 3, 2);
            FechaDateTimePicker.Name = "FechaDateTimePicker";
            FechaDateTimePicker.Size = new Size(219, 23);
            FechaDateTimePicker.TabIndex = 1;
            // 
            // FiltrarButton
            // 
            FiltrarButton.Location = new Point(265, 45);
            FiltrarButton.Margin = new Padding(3, 2, 3, 2);
            FiltrarButton.Name = "FiltrarButton";
            FiltrarButton.Size = new Size(82, 22);
            FiltrarButton.TabIndex = 2;
            FiltrarButton.Text = "Filtrar";
            FiltrarButton.UseVisualStyleBackColor = true;
            FiltrarButton.Click += FiltrarButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 100);
            label2.Name = "label2";
            label2.Size = new Size(190, 15);
            label2.TabIndex = 3;
            label2.Text = "Listado de Ordenes de Preparacion";
            // 
            // ListadoOPListView
            // 
            ListadoOPListView.Columns.AddRange(new ColumnHeader[] { IDHeader1, ClienteHeader2, FechaHeader3, TransportistaHeader4, EstadoHeader5 });
            ListadoOPListView.FullRowSelect = true;
            ListadoOPListView.Location = new Point(29, 128);
            ListadoOPListView.Margin = new Padding(3, 2, 3, 2);
            ListadoOPListView.Name = "ListadoOPListView";
            ListadoOPListView.Size = new Size(629, 104);
            ListadoOPListView.TabIndex = 4;
            ListadoOPListView.UseCompatibleStateImageBehavior = false;
            ListadoOPListView.View = View.Details;
            ListadoOPListView.MouseClick += ListadoOPListView_MouseClick;
            // 
            // IDHeader1
            // 
            IDHeader1.Text = "ID Cliente";
            // 
            // ClienteHeader2
            // 
            ClienteHeader2.Text = "Nombre del Cliente";
            // 
            // FechaHeader3
            // 
            FechaHeader3.Text = "Fecha";
            // 
            // TransportistaHeader4
            // 
            TransportistaHeader4.Text = "Transportista";
            // 
            // EstadoHeader5
            // 
            EstadoHeader5.Text = "Estado";
            // 
            // GenerarButton
            // 
            GenerarButton.Location = new Point(201, 256);
            GenerarButton.Margin = new Padding(3, 2, 3, 2);
            GenerarButton.Name = "GenerarButton";
            GenerarButton.Size = new Size(82, 22);
            GenerarButton.TabIndex = 5;
            GenerarButton.Text = "Generar";
            GenerarButton.UseVisualStyleBackColor = true;
            GenerarButton.Click += GenerarButton_Click;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(453, 256);
            CancelarButton.Margin = new Padding(3, 2, 3, 2);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(82, 22);
            CancelarButton.TabIndex = 6;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            CancelarButton.Click += CancelarButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(378, 20);
            label3.Name = "label3";
            label3.Size = new Size(141, 15);
            label3.TabIndex = 7;
            label3.Text = "ID ORDEN DE SELECCION";
            // 
            // IDOSTextBox
            // 
            IDOSTextBox.Enabled = false;
            IDOSTextBox.Location = new Point(548, 18);
            IDOSTextBox.Margin = new Padding(3, 2, 3, 2);
            IDOSTextBox.Name = "IDOSTextBox";
            IDOSTextBox.ReadOnly = true;
            IDOSTextBox.Size = new Size(110, 23);
            IDOSTextBox.TabIndex = 9;
            // 
            // GenerarOrdenDeSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(IDOSTextBox);
            Controls.Add(label3);
            Controls.Add(CancelarButton);
            Controls.Add(GenerarButton);
            Controls.Add(ListadoOPListView);
            Controls.Add(label2);
            Controls.Add(FiltrarButton);
            Controls.Add(FechaDateTimePicker);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            Name = "GenerarOrdenDeSeleccionForm";
            Text = "Generar Orden de Selección";
            Load += GenerarOrdenDeSeleccionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker FechaDateTimePicker;
        private Button FiltrarButton;
        private Label label2;
        private ListView ListadoOPListView;
        private Button GenerarButton;
        private Button CancelarButton;
        private ColumnHeader IDHeader1;
        private ColumnHeader ClienteHeader2;
        private ColumnHeader FechaHeader3;
        private ColumnHeader TransportistaHeader4;
        private ColumnHeader EstadoHeader5;
        private Label label3;
        private TextBox IDOSTextBox;
    }
}
