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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "1", "Pedidos Ya S.A", "Tomas Lekerman", "01/02/2024", "Preparado" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "2", "Zerf S.A", "David Schupauk", "13/12/2024", "Preparado" }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "3", "SimCorp", "Juan Cuneo", "29/06/2024", "Preparado" }, -1);
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
            label1.Location = new Point(30, 7);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 0;
            label1.Text = "Pedidos Preparados";
            // 
            // pedidosPreparadosListView
            // 
            pedidosPreparadosListView.Columns.AddRange(new ColumnHeader[] { idColumna, clienteColumna, transportistaColumna, fechaDeEntregaColumna, estadoColumna });
            pedidosPreparadosListView.FullRowSelect = true;
            listViewItem1.Tag = "";
            pedidosPreparadosListView.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            pedidosPreparadosListView.LabelWrap = false;
            pedidosPreparadosListView.Location = new Point(29, 24);
            pedidosPreparadosListView.Margin = new Padding(3, 2, 3, 2);
            pedidosPreparadosListView.Name = "pedidosPreparadosListView";
            pedidosPreparadosListView.Size = new Size(628, 112);
            pedidosPreparadosListView.TabIndex = 1;
            pedidosPreparadosListView.UseCompatibleStateImageBehavior = false;
            pedidosPreparadosListView.View = View.Details;
            // 
            // idColumna
            // 
            idColumna.Text = "Orden";
            idColumna.Width = 47;
            // 
            // clienteColumna
            // 
            clienteColumna.Text = "Cliente";
            clienteColumna.Width = 90;
            // 
            // transportistaColumna
            // 
            transportistaColumna.Text = "Transportista";
            transportistaColumna.Width = 102;
            // 
            // fechaDeEntregaColumna
            // 
            fechaDeEntregaColumna.Text = "Fecha de entrega";
            fechaDeEntregaColumna.Width = 102;
            // 
            // estadoColumna
            // 
            estadoColumna.Text = "Estado";
            estadoColumna.Width = 283;
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