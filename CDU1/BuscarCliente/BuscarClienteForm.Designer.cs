namespace GrupoC.Tp3.CDU1
{
    partial class BuscarClienteForm
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
            BuscarButton = new Button();
            CuitTextBox = new TextBox();
            label2 = new Label();
            ClientesListView = new ListView();
            ID = new ColumnHeader();
            RZ = new ColumnHeader();
            CUIT = new ColumnHeader();
            Direccion = new ColumnHeader();
            Telefono = new ColumnHeader();
            Email = new ColumnHeader();
            SeleccionarButton = new Button();
            CancelarButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 38);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 0;
            label1.Text = "CUIT";
            // 
            // BuscarButton
            // 
            BuscarButton.Location = new Point(183, 64);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(107, 29);
            BuscarButton.TabIndex = 1;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            BuscarButton.Click += BuscarButton_Click;
            // 
            // CuitTextBox
            // 
            CuitTextBox.Location = new Point(39, 64);
            CuitTextBox.Name = "CuitTextBox";
            CuitTextBox.Size = new Size(125, 27);
            CuitTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 125);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 3;
            label2.Text = "Listado de Clientes";
            // 
            // ClientesListView
            // 
            ClientesListView.Columns.AddRange(new ColumnHeader[] { ID, RZ, CUIT, Direccion, Telefono, Email });
            ClientesListView.FullRowSelect = true;
            ClientesListView.Location = new Point(39, 158);
            ClientesListView.MultiSelect = false;
            ClientesListView.Name = "ClientesListView";
            ClientesListView.Size = new Size(721, 174);
            ClientesListView.TabIndex = 4;
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
            // SeleccionarButton
            // 
            SeleccionarButton.Location = new Point(126, 384);
            SeleccionarButton.Name = "SeleccionarButton";
            SeleccionarButton.Size = new Size(229, 29);
            SeleccionarButton.TabIndex = 5;
            SeleccionarButton.Text = "Seleccionar";
            SeleccionarButton.UseVisualStyleBackColor = true;
            SeleccionarButton.Click += SeleccionarButton_Click;
            // 
            // CancelarButton
            // 
            CancelarButton.Location = new Point(426, 384);
            CancelarButton.Name = "CancelarButton";
            CancelarButton.Size = new Size(222, 29);
            CancelarButton.TabIndex = 6;
            CancelarButton.Text = "Cancelar";
            CancelarButton.UseVisualStyleBackColor = true;
            CancelarButton.Click += CancelarButton_Click;
            // 
            // BuscarClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CancelarButton);
            Controls.Add(SeleccionarButton);
            Controls.Add(ClientesListView);
            Controls.Add(label2);
            Controls.Add(CuitTextBox);
            Controls.Add(BuscarButton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "BuscarClienteForm";
            Text = "Buscar Cliente";
            Load += BuscarClienteForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BuscarButton;
        private TextBox CuitTextBox;
        private Label label2;
        private ListView ClientesListView;
        private ColumnHeader ID;
        private ColumnHeader RZ;
        private ColumnHeader CUIT;
        private ColumnHeader Direccion;
        private Button SeleccionarButton;
        private Button CancelarButton;
        private ColumnHeader Telefono;
        private ColumnHeader Email;
    }
}