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
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "1", "Tomi", "juanpi", "13/12", "Preparado" }, -1);
            label1 = new Label();
            pedidosPreparadosListView = new ListView();
            idColumna = new ColumnHeader();
            clienteColumna = new ColumnHeader();
            transportistaColumna = new ColumnHeader();
            fechaDeEntregaColumna = new ColumnHeader();
            estadoColumna = new ColumnHeader();
            generarBoton = new Button();
            confirmarBoton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 9);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 0;
            label1.Text = "Pedidos Preparados";
            // 
            // pedidosPreparadosListView
            // 
            pedidosPreparadosListView.Columns.AddRange(new ColumnHeader[] { idColumna, clienteColumna, transportistaColumna, fechaDeEntregaColumna, estadoColumna });
            listViewItem2.Tag = "";
            pedidosPreparadosListView.Items.AddRange(new ListViewItem[] { listViewItem2 });
            pedidosPreparadosListView.Location = new Point(34, 45);
            pedidosPreparadosListView.Name = "pedidosPreparadosListView";
            pedidosPreparadosListView.Size = new Size(717, 148);
            pedidosPreparadosListView.TabIndex = 1;
            pedidosPreparadosListView.UseCompatibleStateImageBehavior = false;
            pedidosPreparadosListView.View = View.Details;
            // 
            // idColumna
            // 
            idColumna.Text = "Orden";
            // 
            // clienteColumna
            // 
            clienteColumna.Text = "Cliente";
            // 
            // transportistaColumna
            // 
            transportistaColumna.Text = "Transportista";
            // 
            // fechaDeEntregaColumna
            // 
            fechaDeEntregaColumna.Text = "Fecha de entrega";
            // 
            // estadoColumna
            // 
            estadoColumna.Text = "Estado";
            // 
            // generarBoton
            // 
            generarBoton.Location = new Point(583, 216);
            generarBoton.Name = "generarBoton";
            generarBoton.Size = new Size(168, 46);
            generarBoton.TabIndex = 2;
            generarBoton.Text = "Generar documento";
            generarBoton.UseVisualStyleBackColor = true;
            generarBoton.Click += generarBoton_Click;
            // 
            // confirmarBoton
            // 
            confirmarBoton.Enabled = false;
            confirmarBoton.Location = new Point(583, 268);
            confirmarBoton.Name = "confirmarBoton";
            confirmarBoton.Size = new Size(168, 44);
            confirmarBoton.TabIndex = 3;
            confirmarBoton.Text = "Confirmar Entrega";
            confirmarBoton.UseVisualStyleBackColor = true;
            // 
            // GenerarDocumentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 472);
            Controls.Add(confirmarBoton);
            Controls.Add(generarBoton);
            Controls.Add(pedidosPreparadosListView);
            Controls.Add(label1);
            Name = "GenerarDocumentos";
            Text = "GenerarDocumentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView pedidosPreparadosListView;
        private ColumnHeader idColumna;
        private ColumnHeader clienteColumna;
        private ColumnHeader transportistaColumna;
        private ColumnHeader fechaDeEntregaColumna;
        private Button generarBoton;
        private ColumnHeader estadoColumna;
        private Button confirmarBoton;
    }
}