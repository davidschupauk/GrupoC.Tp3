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
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "101", "Axioma", "Juan Pablo" }, -1);
            ListViewItem listViewItem5 = new ListViewItem(new string[] { "Juan", "Cuneo", "999999", "623" }, -1);
            ListViewItem listViewItem6 = new ListViewItem(new string[] { "100", "Qontigo", "Tomas" }, -1);
            OrdenesPorDespacharlistView = new ListView();
            label1 = new Label();
            NroOrden = new ColumnHeader();
            Cliente = new ColumnHeader();
            Transportista = new ColumnHeader();
            listView1 = new ListView();
            label2 = new Label();
            SeleccionarOrdenbutton = new Button();
            ConfirmarTransportistabutton = new Button();
            Nombre = new ColumnHeader();
            Apellido = new ColumnHeader();
            DNI = new ColumnHeader();
            CodigoTransportista = new ColumnHeader();
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
            OrdenesPorDespacharlistView.Items.AddRange(new ListViewItem[] { listViewItem4 });
            OrdenesPorDespacharlistView.Location = new Point(12, 29);
            OrdenesPorDespacharlistView.Name = "OrdenesPorDespacharlistView";
            OrdenesPorDespacharlistView.Size = new Size(317, 299);
            OrdenesPorDespacharlistView.TabIndex = 0;
            OrdenesPorDespacharlistView.UseCompatibleStateImageBehavior = false;
            OrdenesPorDespacharlistView.View = View.Details;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 1;
            label1.Text = "Ordenes por despachar";
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
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Nombre, Apellido, DNI, CodigoTransportista });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem5 });
            listView1.Location = new Point(370, 29);
            listView1.Name = "listView1";
            listView1.Size = new Size(589, 299);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(370, 11);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 3;
            label2.Text = "Datos transportista";
            label2.Click += label2_Click;
            // 
            // SeleccionarOrdenbutton
            // 
            SeleccionarOrdenbutton.Location = new Point(254, 334);
            SeleccionarOrdenbutton.Name = "SeleccionarOrdenbutton";
            SeleccionarOrdenbutton.Size = new Size(75, 23);
            SeleccionarOrdenbutton.TabIndex = 4;
            SeleccionarOrdenbutton.Text = "Seleccionar";
            SeleccionarOrdenbutton.UseVisualStyleBackColor = true;
            // 
            // ConfirmarTransportistabutton
            // 
            ConfirmarTransportistabutton.Location = new Point(812, 334);
            ConfirmarTransportistabutton.Name = "ConfirmarTransportistabutton";
            ConfirmarTransportistabutton.Size = new Size(147, 23);
            ConfirmarTransportistabutton.TabIndex = 5;
            ConfirmarTransportistabutton.Text = "Confirmar transportista";
            ConfirmarTransportistabutton.UseVisualStyleBackColor = true;
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
            // OrdenesDespachoAprobadolistView
            // 
            OrdenesDespachoAprobadolistView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            OrdenesDespachoAprobadolistView.Items.AddRange(new ListViewItem[] { listViewItem6 });
            OrdenesDespachoAprobadolistView.Location = new Point(12, 374);
            OrdenesDespachoAprobadolistView.Name = "OrdenesDespachoAprobadolistView";
            OrdenesDespachoAprobadolistView.Size = new Size(317, 140);
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
            ConfirmarDespachobutton.Location = new Point(197, 520);
            ConfirmarDespachobutton.Name = "ConfirmarDespachobutton";
            ConfirmarDespachobutton.Size = new Size(132, 23);
            ConfirmarDespachobutton.TabIndex = 7;
            ConfirmarDespachobutton.Text = "Confirmar despacho";
            ConfirmarDespachobutton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 356);
            label3.Name = "label3";
            label3.Size = new Size(208, 15);
            label3.TabIndex = 8;
            label3.Text = "Ordenes con transportista confirmado";
            // 
            // DespacharOrden
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 560);
            Controls.Add(label3);
            Controls.Add(ConfirmarDespachobutton);
            Controls.Add(OrdenesDespachoAprobadolistView);
            Controls.Add(ConfirmarTransportistabutton);
            Controls.Add(SeleccionarOrdenbutton);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(label1);
            Controls.Add(OrdenesPorDespacharlistView);
            Name = "DespacharOrden";
            Text = "DespacharOrden";
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