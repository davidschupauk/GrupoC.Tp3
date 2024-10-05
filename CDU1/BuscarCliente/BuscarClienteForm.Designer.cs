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
            button1 = new Button();
            CuitTextBox = new TextBox();
            label2 = new Label();
            ClientesListView = new ListView();
            CodigoHeader = new ColumnHeader();
            RZHeader = new ColumnHeader();
            CUITHeader = new ColumnHeader();
            DomicilioHeader = new ColumnHeader();
            SeleccionarButton = new Button();
            Cancelar = new Button();
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
            // button1
            // 
            button1.Location = new Point(183, 64);
            button1.Name = "button1";
            button1.Size = new Size(107, 29);
            button1.TabIndex = 1;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
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
            ClientesListView.Columns.AddRange(new ColumnHeader[] { CodigoHeader, RZHeader, CUITHeader, DomicilioHeader });
            ClientesListView.Location = new Point(39, 158);
            ClientesListView.Name = "ClientesListView";
            ClientesListView.Size = new Size(721, 174);
            ClientesListView.TabIndex = 4;
            ClientesListView.UseCompatibleStateImageBehavior = false;
            // 
            // CodigoHeader
            // 
            CodigoHeader.Text = "Codigo del cliente";
            // 
            // RZHeader
            // 
            RZHeader.Text = "Razon Social";
            // 
            // CUITHeader
            // 
            CUITHeader.Text = "CUIT";
            // 
            // DomicilioHeader
            // 
            DomicilioHeader.Text = "Domicilio";
            // 
            // SeleccionarButton
            // 
            SeleccionarButton.Location = new Point(126, 384);
            SeleccionarButton.Name = "SeleccionarButton";
            SeleccionarButton.Size = new Size(229, 29);
            SeleccionarButton.TabIndex = 5;
            SeleccionarButton.Text = "Seleccionar";
            SeleccionarButton.UseVisualStyleBackColor = true;
            // 
            // Cancelar
            // 
            Cancelar.Location = new Point(426, 384);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(222, 29);
            Cancelar.TabIndex = 6;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            // 
            // BuscarClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Cancelar);
            Controls.Add(SeleccionarButton);
            Controls.Add(ClientesListView);
            Controls.Add(label2);
            Controls.Add(CuitTextBox);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "BuscarClienteForm";
            Text = "Buscar Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox CuitTextBox;
        private Label label2;
        private ListView ClientesListView;
        private ColumnHeader CodigoHeader;
        private ColumnHeader RZHeader;
        private ColumnHeader CUITHeader;
        private ColumnHeader DomicilioHeader;
        private Button SeleccionarButton;
        private Button Cancelar;
    }
}