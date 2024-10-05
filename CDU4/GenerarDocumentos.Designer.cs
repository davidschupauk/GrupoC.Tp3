namespace GrupoC.Tp3.CDU4
{
    partial class GenerarDocumentos
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
            pedidosPreparadosListView = new ListView();
            Orden = new ColumnHeader();
            Cliente = new ColumnHeader();
            Transportista = new ColumnHeader();
            Fecha = new ColumnHeader();
            Estado = new ColumnHeader();
            generarBoton = new Button();
            confirmarBoton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 7);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 0;
            label1.Text = "Pedidos Preparados";
            // 
            // pedidosPreparadosListView
            // 
            pedidosPreparadosListView.Columns.AddRange(new ColumnHeader[] { Orden, Cliente, Transportista, Fecha, Estado });
            pedidosPreparadosListView.FullRowSelect = true;
            pedidosPreparadosListView.LabelWrap = false;
            pedidosPreparadosListView.Location = new Point(29, 24);
            pedidosPreparadosListView.Margin = new Padding(3, 2, 3, 2);
            pedidosPreparadosListView.MultiSelect = false;
            pedidosPreparadosListView.Name = "pedidosPreparadosListView";
            pedidosPreparadosListView.Size = new Size(628, 112);
            pedidosPreparadosListView.TabIndex = 1;
            pedidosPreparadosListView.UseCompatibleStateImageBehavior = false;
            pedidosPreparadosListView.View = View.Details;
            // 
            // Orden
            // 
            Orden.Text = "Orden";
            // 
            // Cliente
            // 
            Cliente.Text = "Cliente";
            // 
            // Transportista
            // 
            Transportista.Text = "Transportista";
            // 
            // Fecha
            // 
            Fecha.Text = "Fecha";
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            // 
            // generarBoton
            // 
            generarBoton.Location = new Point(510, 140);
            generarBoton.Margin = new Padding(3, 2, 3, 2);
            generarBoton.Name = "generarBoton";
            generarBoton.Size = new Size(147, 34);
            generarBoton.TabIndex = 2;
            generarBoton.Text = "Generar documento";
            generarBoton.UseVisualStyleBackColor = true;
            generarBoton.Click += generarBoton_Click;
            // 
            // confirmarBoton
            // 
            confirmarBoton.Enabled = false;
            confirmarBoton.Location = new Point(510, 178);
            confirmarBoton.Margin = new Padding(3, 2, 3, 2);
            confirmarBoton.Name = "confirmarBoton";
            confirmarBoton.Size = new Size(147, 33);
            confirmarBoton.TabIndex = 3;
            confirmarBoton.Text = "Confirmar Entrega";
            confirmarBoton.UseVisualStyleBackColor = true;
            // 
            // GenerarDocumentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 577);
            Controls.Add(confirmarBoton);
            Controls.Add(generarBoton);
            Controls.Add(pedidosPreparadosListView);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "GenerarDocumentos";
            Text = "GenerarDocumentos";
            Load += GenerarDocumentos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView pedidosPreparadosListView;
        private Button generarBoton;
        private Button confirmarBoton;
        private ColumnHeader Orden;
        private ColumnHeader Cliente;
        private ColumnHeader Transportista;
        private ColumnHeader Fecha;
        private ColumnHeader Estado;
    }
}