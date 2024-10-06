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
            label1.Location = new Point(43, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(170, 25);
            label1.TabIndex = 0;
            label1.Text = "Pedidos Preparados";
            // 
            // pedidosPreparadosListView
            // 
            pedidosPreparadosListView.Columns.AddRange(new ColumnHeader[] { Orden, Cliente, Transportista, Fecha, Estado });
            pedidosPreparadosListView.FullRowSelect = true;
            pedidosPreparadosListView.LabelWrap = false;
            pedidosPreparadosListView.Location = new Point(41, 40);
            pedidosPreparadosListView.Margin = new Padding(4, 3, 4, 3);
            pedidosPreparadosListView.MultiSelect = false;
            pedidosPreparadosListView.Name = "pedidosPreparadosListView";
            pedidosPreparadosListView.Size = new Size(895, 295);
            pedidosPreparadosListView.TabIndex = 1;
            pedidosPreparadosListView.UseCompatibleStateImageBehavior = false;
            pedidosPreparadosListView.View = View.Details;
            pedidosPreparadosListView.SelectedIndexChanged += pedidosPreparadosListView_SelectedIndexChanged;
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
            generarBoton.Location = new Point(510, 341);
            generarBoton.Margin = new Padding(4, 3, 4, 3);
            generarBoton.Name = "generarBoton";
            generarBoton.Size = new Size(210, 57);
            generarBoton.TabIndex = 2;
            generarBoton.Text = "Generar documento";
            generarBoton.UseVisualStyleBackColor = true;
            generarBoton.Click += generarBoton_Click;
            // 
            // confirmarBoton
            // 
            confirmarBoton.Enabled = false;
            confirmarBoton.Location = new Point(726, 343);
            confirmarBoton.Margin = new Padding(4, 3, 4, 3);
            confirmarBoton.Name = "confirmarBoton";
            confirmarBoton.Size = new Size(210, 55);
            confirmarBoton.TabIndex = 3;
            confirmarBoton.Text = "Confirmar Entrega";
            confirmarBoton.UseVisualStyleBackColor = true;
            confirmarBoton.Click += confirmarBoton_Click;
            // 
            // GenerarDocumentos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 420);
            Controls.Add(confirmarBoton);
            Controls.Add(generarBoton);
            Controls.Add(pedidosPreparadosListView);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
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