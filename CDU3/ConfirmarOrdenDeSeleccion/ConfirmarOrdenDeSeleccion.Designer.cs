namespace GrupoC.Tp3.CDU3
{
    partial class ConfirmarOrdenDeSeleccion
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
            confirmarOrdenDeSeleccionlistView = new ListView();
            NroOrden = new ColumnHeader();
            Cliente = new ColumnHeader();
            Estado = new ColumnHeader();
            consultar_button = new Button();
            cancelar_button = new Button();
            titulo_tabla_pendiente = new Label();
            SuspendLayout();
            // 
            // confirmarOrdenDeSeleccionlistView
            // 
            confirmarOrdenDeSeleccionlistView.BackColor = SystemColors.ScrollBar;
            confirmarOrdenDeSeleccionlistView.Columns.AddRange(new ColumnHeader[] { NroOrden, Cliente, Estado });
            confirmarOrdenDeSeleccionlistView.FullRowSelect = true;
            confirmarOrdenDeSeleccionlistView.Location = new Point(55, 72);
            confirmarOrdenDeSeleccionlistView.Margin = new Padding(3, 4, 3, 4);
            confirmarOrdenDeSeleccionlistView.Name = "confirmarOrdenDeSeleccionlistView";
            confirmarOrdenDeSeleccionlistView.Size = new Size(501, 170);
            confirmarOrdenDeSeleccionlistView.TabIndex = 0;
            confirmarOrdenDeSeleccionlistView.UseCompatibleStateImageBehavior = false;
            confirmarOrdenDeSeleccionlistView.View = View.Details;
            confirmarOrdenDeSeleccionlistView.SelectedIndexChanged += confirmarOrdenDeSeleccionlistView_SelectedIndexChanged;
            // 
            // NroOrden
            // 
            NroOrden.Text = "Nro Orden";
            NroOrden.Width = 100;
            // 
            // Cliente
            // 
            Cliente.Text = "Cliente";
            Cliente.Width = 120;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 100;
            // 
            // consultar_button
            // 
            consultar_button.Location = new Point(172, 271);
            consultar_button.Name = "consultar_button";
            consultar_button.Size = new Size(122, 40);
            consultar_button.TabIndex = 1;
            consultar_button.Text = "Consultar ";
            consultar_button.UseVisualStyleBackColor = true;
            consultar_button.Click += ConsultarButton_Click;
            // 
            // cancelar_button
            // 
            cancelar_button.Location = new Point(312, 271);
            cancelar_button.Name = "cancelar_button";
            cancelar_button.Size = new Size(122, 40);
            cancelar_button.TabIndex = 2;
            cancelar_button.Text = "Cancelar";
            cancelar_button.UseVisualStyleBackColor = true;
            cancelar_button.Click += CancelarButton_Click;
            // 
            // titulo_tabla_pendiente
            // 
            titulo_tabla_pendiente.AutoSize = true;
            titulo_tabla_pendiente.Location = new Point(55, 24);
            titulo_tabla_pendiente.Name = "titulo_tabla_pendiente";
            titulo_tabla_pendiente.Size = new Size(288, 20);
            titulo_tabla_pendiente.TabIndex = 3;
            titulo_tabla_pendiente.Text = "Listado de Ordenes Pendiente a Confirmar";
            // 
            // ConfirmarOrdenDeSeleccion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 327);
            Controls.Add(titulo_tabla_pendiente);
            Controls.Add(cancelar_button);
            Controls.Add(consultar_button);
            Controls.Add(confirmarOrdenDeSeleccionlistView);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ConfirmarOrdenDeSeleccion";
            Text = "ConfirmarOrdenDeSeleccion";
            Load += ConfirmarOrdenDeSeleccion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView confirmarOrdenDeSeleccionlistView;
        private ColumnHeader NroOrden;
        private ColumnHeader Cliente;
        private ColumnHeader Estado;
        private Button consultar_button;
        private Button cancelar_button;
        private Label titulo_tabla_pendiente;
    }
}