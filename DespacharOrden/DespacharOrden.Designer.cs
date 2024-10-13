namespace GrupoC.Tp3.DespacharOrden
{
    partial class Despachar
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
            OrdenesPorDespacharlistView = new ListView();
            NroOrden = new ColumnHeader();
            Cliente = new ColumnHeader();
            Transportista = new ColumnHeader();
            codtransportista = new ColumnHeader();
            label1 = new Label();
            datosTrasportistas = new ListView();
            transportistaCod = new ColumnHeader();
            dni_id = new ColumnHeader();
            nombre_transportista = new ColumnHeader();
            apellidoTrasnportista = new ColumnHeader();
            label2 = new Label();
            SeleccionarOrdenbutton = new Button();
            ConfirmarTransportistabutton = new Button();
            OrdenesDespachoAprobadolistView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            ConfirmarDespachobutton = new Button();
            label3 = new Label();
            cancelar_confirmacion = new Button();
            SuspendLayout();
            // 
            // OrdenesPorDespacharlistView
            // 
            OrdenesPorDespacharlistView.BackColor = SystemColors.ScrollBar;
            OrdenesPorDespacharlistView.Columns.AddRange(new ColumnHeader[] { NroOrden, Cliente, Transportista, codtransportista });
            OrdenesPorDespacharlistView.FullRowSelect = true;
            OrdenesPorDespacharlistView.Location = new Point(14, 39);
            OrdenesPorDespacharlistView.Margin = new Padding(3, 4, 3, 4);
            OrdenesPorDespacharlistView.Name = "OrdenesPorDespacharlistView";
            OrdenesPorDespacharlistView.Size = new Size(431, 397);
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
            // codtransportista
            // 
            codtransportista.Text = "Cod. Transportista";
            codtransportista.Width = 180;
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
            // datosTrasportistas
            // 
            datosTrasportistas.BackColor = SystemColors.ScrollBar;
            datosTrasportistas.Columns.AddRange(new ColumnHeader[] { transportistaCod, dni_id, nombre_transportista, apellidoTrasnportista });
            datosTrasportistas.FullRowSelect = true;
            datosTrasportistas.Location = new Point(514, 39);
            datosTrasportistas.Margin = new Padding(3, 4, 3, 4);
            datosTrasportistas.Name = "datosTrasportistas";
            datosTrasportistas.Size = new Size(673, 397);
            datosTrasportistas.TabIndex = 2;
            datosTrasportistas.UseCompatibleStateImageBehavior = false;
            datosTrasportistas.View = View.Details;
            // 
            // transportistaCod
            // 
            transportistaCod.Text = "Cod. Transportista";
            transportistaCod.Width = 180;
            // 
            // dni_id
            // 
            dni_id.Text = "DNI";
            dni_id.Width = 180;
            // 
            // nombre_transportista
            // 
            nombre_transportista.Text = "Nombre";
            nombre_transportista.Width = 180;
            // 
            // apellidoTrasnportista
            // 
            apellidoTrasnportista.Text = "Apellido";
            apellidoTrasnportista.Width = 180;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(514, 15);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 3;
            label2.Text = "Datos transportista";
            // 
            // SeleccionarOrdenbutton
            // 
            SeleccionarOrdenbutton.Location = new Point(294, 444);
            SeleccionarOrdenbutton.Margin = new Padding(3, 4, 3, 4);
            SeleccionarOrdenbutton.Name = "SeleccionarOrdenbutton";
            SeleccionarOrdenbutton.Size = new Size(151, 32);
            SeleccionarOrdenbutton.TabIndex = 4;
            SeleccionarOrdenbutton.Text = "Seleccionar";
            SeleccionarOrdenbutton.UseVisualStyleBackColor = true;
            SeleccionarOrdenbutton.Click += SeleccionarOrdenbutton_Click;
            // 
            // ConfirmarTransportistabutton
            // 
            ConfirmarTransportistabutton.Location = new Point(1014, 445);
            ConfirmarTransportistabutton.Margin = new Padding(3, 4, 3, 4);
            ConfirmarTransportistabutton.Name = "ConfirmarTransportistabutton";
            ConfirmarTransportistabutton.Size = new Size(173, 31);
            ConfirmarTransportistabutton.TabIndex = 5;
            ConfirmarTransportistabutton.Text = "Confirmar transportista";
            ConfirmarTransportistabutton.UseVisualStyleBackColor = true;
            ConfirmarTransportistabutton.Click += ConfirmarTransportistabutton_Click;
            // 
            // OrdenesDespachoAprobadolistView
            // 
            OrdenesDespachoAprobadolistView.Activation = ItemActivation.OneClick;
            OrdenesDespachoAprobadolistView.BackColor = SystemColors.ScrollBar;
            OrdenesDespachoAprobadolistView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            OrdenesDespachoAprobadolistView.Location = new Point(14, 499);
            OrdenesDespachoAprobadolistView.Margin = new Padding(3, 4, 3, 4);
            OrdenesDespachoAprobadolistView.Name = "OrdenesDespachoAprobadolistView";
            OrdenesDespachoAprobadolistView.Size = new Size(431, 185);
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
            // columnHeader4
            // 
            columnHeader4.Text = "Cod. Transportista";
            columnHeader4.Width = 150;
            // 
            // ConfirmarDespachobutton
            // 
            ConfirmarDespachobutton.Location = new Point(294, 692);
            ConfirmarDespachobutton.Margin = new Padding(3, 4, 3, 4);
            ConfirmarDespachobutton.Name = "ConfirmarDespachobutton";
            ConfirmarDespachobutton.Size = new Size(151, 31);
            ConfirmarDespachobutton.TabIndex = 7;
            ConfirmarDespachobutton.Text = "Confirmar despacho";
            ConfirmarDespachobutton.UseVisualStyleBackColor = true;
            ConfirmarDespachobutton.Click += ConfirmarDespachobutton_Click;
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
            // cancelar_confirmacion
            // 
            cancelar_confirmacion.Location = new Point(835, 447);
            cancelar_confirmacion.Name = "cancelar_confirmacion";
            cancelar_confirmacion.Size = new Size(173, 29);
            cancelar_confirmacion.TabIndex = 9;
            cancelar_confirmacion.Text = "Cancelar";
            cancelar_confirmacion.UseVisualStyleBackColor = true;
            cancelar_confirmacion.Click += cancelar_confirmacion_Click;
            // 
            // Despachar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 760);
            Controls.Add(cancelar_confirmacion);
            Controls.Add(label3);
            Controls.Add(ConfirmarDespachobutton);
            Controls.Add(OrdenesDespachoAprobadolistView);
            Controls.Add(ConfirmarTransportistabutton);
            Controls.Add(SeleccionarOrdenbutton);
            Controls.Add(label2);
            Controls.Add(datosTrasportistas);
            Controls.Add(label1);
            Controls.Add(OrdenesPorDespacharlistView);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Despachar";
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
        private ListView datosTrasportistas;
        private Label label2;
        private Button SeleccionarOrdenbutton;
        private Button ConfirmarTransportistabutton;
        private ListView OrdenesDespachoAprobadolistView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button ConfirmarDespachobutton;
        private Label label3;
        private ColumnHeader codtransportista;
        private ColumnHeader transportistaCod;
        private ColumnHeader dni_id;
        private ColumnHeader nombre_transportista;
        private ColumnHeader apellidoTrasnportista;
        private ColumnHeader columnHeader4;
        private Button cancelar_confirmacion;
    }
}