namespace GrupoC.Tp3.DespacharOrden
{
    partial class DespacharOrden
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "101", "Axioma", "Juan Pablo" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "Juan", "Cuneo", "999999", "623" }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "100", "Qontigo", "Tomas" }, -1);
            OrdenesPorDespacharlistView = new ListView();
            NroOrden = new ColumnHeader();
            Cliente = new ColumnHeader();
            Transportista = new ColumnHeader();
            label1 = new Label();
            listView1 = new ListView();
            Nombre = new ColumnHeader();
            Apellido = new ColumnHeader();
            DNI = new ColumnHeader();
            CodigoTransportista = new ColumnHeader();
            label2 = new Label();
            SeleccionarOrdenbutton = new Button();
            ConfirmarTransportistabutton = new Button();
            OrdenesDespachoAprobadolistView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            ConfirmarDespachobutton = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // OrdenesPorDespacharlistView
            // 
            OrdenesPorDespacharlistView.Columns.AddRange(new ColumnHeader[] { NroOrden, Cliente, Transportista });
            OrdenesPorDespacharlistView.Items.AddRange(new ListViewItem[] { listViewItem1 });
            OrdenesPorDespacharlistView.Location = new Point(14, 39);
            OrdenesPorDespacharlistView.Margin = new Padding(3, 4, 3, 4);
            OrdenesPorDespacharlistView.Name = "OrdenesPorDespacharlistView";
            OrdenesPorDespacharlistView.Size = new Size(362, 397);
            OrdenesPorDespacharlistView.TabIndex = 0;
            OrdenesPorDespacharlistView.UseCompatibleStateImageBehavior = false;
            OrdenesPorDespacharlistView.View = View.Details;
            // 
            // NroOrden
            // 
            NroOrden.Text = "Nro Orden";
            NroOrden.Width = 100;
            // 
            // Cliente
            // 
            Cliente.Text = "Cliente";
            Cliente.Width = 100;
            // 
            // Transportista
            // 
            Transportista.Text = "Transportista";
            Transportista.Width = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 15);
            label1.Name = "label1";
            label1.Size = new Size(163, 20);
            label1.TabIndex = 1;
            label1.Text = "Ordenes por despachar";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Nombre, Apellido, DNI, CodigoTransportista });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem2 });
            listView1.Location = new Point(423, 39);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(673, 397);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Nombre
            // 
            Nombre.Text = "Nombre";
            Nombre.Width = 100;
            // 
            // Apellido
            // 
            Apellido.Text = "Apellido";
            Apellido.Width = 100;
            // 
            // DNI
            // 
            DNI.Text = "DNI";
            DNI.Width = 100;
            // 
            // CodigoTransportista
            // 
            CodigoTransportista.Text = "Codigo Transportista";
            CodigoTransportista.Width = 130;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(423, 15);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 3;
            label2.Text = "Datos transportista";
            label2.Click += label2_Click;
            // 
            // SeleccionarOrdenbutton
            // 
            SeleccionarOrdenbutton.Location = new Point(290, 445);
            SeleccionarOrdenbutton.Margin = new Padding(3, 4, 3, 4);
            SeleccionarOrdenbutton.Name = "SeleccionarOrdenbutton";
            SeleccionarOrdenbutton.Size = new Size(86, 31);
            SeleccionarOrdenbutton.TabIndex = 4;
            SeleccionarOrdenbutton.Text = "Seleccionar";
            SeleccionarOrdenbutton.UseVisualStyleBackColor = true;
            // 
            // ConfirmarTransportistabutton
            // 
            ConfirmarTransportistabutton.Location = new Point(928, 445);
            ConfirmarTransportistabutton.Margin = new Padding(3, 4, 3, 4);
            ConfirmarTransportistabutton.Name = "ConfirmarTransportistabutton";
            ConfirmarTransportistabutton.Size = new Size(168, 31);
            ConfirmarTransportistabutton.TabIndex = 5;
            ConfirmarTransportistabutton.Text = "Confirmar transportista";
            ConfirmarTransportistabutton.UseVisualStyleBackColor = true;
            // 
            // OrdenesDespachoAprobadolistView
            // 
            OrdenesDespachoAprobadolistView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            OrdenesDespachoAprobadolistView.Items.AddRange(new ListViewItem[] { listViewItem3 });
            OrdenesDespachoAprobadolistView.Location = new Point(14, 499);
            OrdenesDespachoAprobadolistView.Margin = new Padding(3, 4, 3, 4);
            OrdenesDespachoAprobadolistView.Name = "OrdenesDespachoAprobadolistView";
            OrdenesDespachoAprobadolistView.Size = new Size(362, 185);
            OrdenesDespachoAprobadolistView.TabIndex = 6;
            OrdenesDespachoAprobadolistView.UseCompatibleStateImageBehavior = false;
            OrdenesDespachoAprobadolistView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nro Orden";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Cliente";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Transportista";
            columnHeader3.Width = 100;
            // 
            // ConfirmarDespachobutton
            // 
            ConfirmarDespachobutton.Location = new Point(225, 693);
            ConfirmarDespachobutton.Margin = new Padding(3, 4, 3, 4);
            ConfirmarDespachobutton.Name = "ConfirmarDespachobutton";
            ConfirmarDespachobutton.Size = new Size(151, 31);
            ConfirmarDespachobutton.TabIndex = 7;
            ConfirmarDespachobutton.Text = "Confirmar despacho";
            ConfirmarDespachobutton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 475);
            label3.Name = "label3";
            label3.Size = new Size(260, 20);
            label3.TabIndex = 8;
            label3.Text = "Ordenes con transportista confirmado";
            // 
            // DespacharOrden
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 747);
            Controls.Add(label3);
            Controls.Add(ConfirmarDespachobutton);
            Controls.Add(OrdenesDespachoAprobadolistView);
            Controls.Add(ConfirmarTransportistabutton);
            Controls.Add(SeleccionarOrdenbutton);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(label1);
            Controls.Add(OrdenesPorDespacharlistView);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DespacharOrden";
            Text = "DespacharOrden";
            Load += DespacharOrden_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView OrdenesPorDespacharlistView;
        private ColumnHeader NroOrden;
        private ColumnHeader Cliente;
        private ColumnHeader Transportista;
        private Label label1;
        private ListView listView1;
        private Label label2;
        private Button SeleccionarOrdenbutton;
        private Button ConfirmarTransportistabutton;
        private ColumnHeader Nombre;
        private ColumnHeader Apellido;
        private ColumnHeader DNI;
        private ColumnHeader CodigoTransportista;
        private ListView OrdenesDespachoAprobadolistView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button ConfirmarDespachobutton;
        private Label label3;
    }
}