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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(449, 22);
            label1.Name = "label1";
            label1.Size = new Size(182, 20);
            label1.TabIndex = 0;
            label1.Text = "ORDEN DE SELECCIÓN N°";
            // 
            // IDOSTextBox
            // 
            IDOSTextBox.Location = new Point(637, 19);
            IDOSTextBox.Name = "IDOSTextBox";
            IDOSTextBox.Size = new Size(125, 27);
            IDOSTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ReiniciarFiltroButton);
            groupBox1.Controls.Add(FiltrarButton);
            groupBox1.Controls.Add(IDOPTextBox);
            groupBox1.Controls.Add(IDClienteTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(33, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(729, 121);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtrar Por:";
            // 
            // ReiniciarFiltroButton
            // 
            ReiniciarFiltroButton.Location = new Point(461, 62);
            ReiniciarFiltroButton.Name = "ReiniciarFiltroButton";
            ReiniciarFiltroButton.Size = new Size(123, 29);
            ReiniciarFiltroButton.TabIndex = 7;
            ReiniciarFiltroButton.Text = "Reiniciar Filtro";
            ReiniciarFiltroButton.UseVisualStyleBackColor = true;
            ReiniciarFiltroButton.Click += ReiniciarFiltroButton_Click;
            // 
            // FiltrarButton
            // 
            FiltrarButton.Location = new Point(461, 18);
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
            IDClienteTextBox.Location = new Point(273, 26);
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
            label2.Location = new Point(94, 26);
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
            OrdenDeSeleccionListView.Size = new Size(729, 197);
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
            GenerarOrdenButton.Location = new Point(178, 444);
            GenerarOrdenButton.Name = "GenerarOrdenButton";
            GenerarOrdenButton.Size = new Size(123, 29);
            GenerarOrdenButton.TabIndex = 6;
            GenerarOrdenButton.Text = "Generar Orden";
            GenerarOrdenButton.UseVisualStyleBackColor = true;
            GenerarOrdenButton.Click += GenerarOrdenButton_Click;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(494, 444);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(108, 29);
            CancelarButton.TabIndex = 7;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            CancelarButton.Click += CancelarButton_Click;
            // 
            // GenerarOrdenDeSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
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
    }
}
