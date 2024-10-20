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
            codtransportista = new ColumnHeader();
            label1 = new Label();
            datosTrasportistas = new ListView();
            transportistaCod = new ColumnHeader();
            dni_id = new ColumnHeader();
            nombre_transportista = new ColumnHeader();
            apellidoTrasnportista = new ColumnHeader();
            label2 = new Label();
            ConfirmarTransportistabutton = new Button();
            ConfirmarDespachobutton = new Button();
            cancelar_confirmacion = new Button();
            dniTransportistatextBox = new TextBox();
            label4 = new Label();
            buscarDniTransportistabutton = new Button();
            SuspendLayout();
            // 
            // OrdenesPorDespacharlistView
            // 
            OrdenesPorDespacharlistView.BackColor = SystemColors.ScrollBar;
            OrdenesPorDespacharlistView.Columns.AddRange(new ColumnHeader[] { NroOrden, Cliente, codtransportista });
            OrdenesPorDespacharlistView.FullRowSelect = true;
            OrdenesPorDespacharlistView.Location = new Point(736, 92);
            OrdenesPorDespacharlistView.Name = "OrdenesPorDespacharlistView";
            OrdenesPorDespacharlistView.Size = new Size(416, 299);
            OrdenesPorDespacharlistView.TabIndex = 0;
            OrdenesPorDespacharlistView.UseCompatibleStateImageBehavior = false;
            OrdenesPorDespacharlistView.View = View.Details;
            OrdenesPorDespacharlistView.SelectedIndexChanged += OrdenesPorDespacharlistView_SelectedIndexChanged;
            // 
            // NroOrden
            // 
            NroOrden.DisplayIndex = 1;
            NroOrden.Text = "Nro Orden";
            NroOrden.Width = 100;
            // 
            // Cliente
            // 
            Cliente.DisplayIndex = 2;
            Cliente.Text = "Cliente";
            Cliente.Width = 100;
            // 
            // codtransportista
            // 
            codtransportista.DisplayIndex = 0;
            codtransportista.Text = "Cod. Transportista";
            codtransportista.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(736, 74);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 1;
            label1.Text = "Ordenes por despachar";
            // 
            // datosTrasportistas
            // 
            datosTrasportistas.BackColor = SystemColors.ScrollBar;
            datosTrasportistas.Columns.AddRange(new ColumnHeader[] { transportistaCod, dni_id, nombre_transportista, apellidoTrasnportista });
            datosTrasportistas.Enabled = false;
            datosTrasportistas.FullRowSelect = true;
            datosTrasportistas.Location = new Point(11, 92);
            datosTrasportistas.Name = "datosTrasportistas";
            datosTrasportistas.Size = new Size(627, 299);
            datosTrasportistas.TabIndex = 2;
            datosTrasportistas.UseCompatibleStateImageBehavior = false;
            datosTrasportistas.View = View.Details;
            // 
            // transportistaCod
            // 
            transportistaCod.Text = "Cod. Transportista";
            transportistaCod.Width = 120;
            // 
            // dni_id
            // 
            dni_id.Text = "DNI";
            dni_id.Width = 140;
            // 
            // nombre_transportista
            // 
            nombre_transportista.Text = "Nombre";
            nombre_transportista.Width = 140;
            // 
            // apellidoTrasnportista
            // 
            apellidoTrasnportista.Text = "Apellido";
            apellidoTrasnportista.Width = 140;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 74);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 3;
            label2.Text = "Datos transportista";
            // 
            // ConfirmarTransportistabutton
            // 
            ConfirmarTransportistabutton.Location = new Point(256, 395);
            ConfirmarTransportistabutton.Name = "ConfirmarTransportistabutton";
            ConfirmarTransportistabutton.Size = new Size(189, 23);
            ConfirmarTransportistabutton.TabIndex = 5;
            ConfirmarTransportistabutton.Text = "Confirmar transportista";
            ConfirmarTransportistabutton.UseVisualStyleBackColor = true;
            ConfirmarTransportistabutton.Click += ConfirmarTransportistabutton_Click;
            // 
            // ConfirmarDespachobutton
            // 
            ConfirmarDespachobutton.Location = new Point(1020, 395);
            ConfirmarDespachobutton.Name = "ConfirmarDespachobutton";
            ConfirmarDespachobutton.Size = new Size(132, 23);
            ConfirmarDespachobutton.TabIndex = 7;
            ConfirmarDespachobutton.Text = "Confirmar despacho";
            ConfirmarDespachobutton.UseVisualStyleBackColor = true;
            ConfirmarDespachobutton.Click += ConfirmarDespachobutton_Click;
            // 
            // cancelar_confirmacion
            // 
            cancelar_confirmacion.Location = new Point(449, 396);
            cancelar_confirmacion.Margin = new Padding(3, 2, 3, 2);
            cancelar_confirmacion.Name = "cancelar_confirmacion";
            cancelar_confirmacion.Size = new Size(189, 22);
            cancelar_confirmacion.TabIndex = 9;
            cancelar_confirmacion.Text = "Cancelar";
            cancelar_confirmacion.UseVisualStyleBackColor = true;
            cancelar_confirmacion.Click += cancelar_confirmacion_Click;
            // 
            // dniTransportistatextBox
            // 
            dniTransportistatextBox.Location = new Point(11, 34);
            dniTransportistatextBox.Name = "dniTransportistatextBox";
            dniTransportistatextBox.Size = new Size(185, 23);
            dniTransportistatextBox.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 16);
            label4.Name = "label4";
            label4.Size = new Size(156, 15);
            label4.TabIndex = 11;
            label4.Text = "Ingrese DNI de transportista ";
            // 
            // buscarDniTransportistabutton
            // 
            buscarDniTransportistabutton.Location = new Point(202, 34);
            buscarDniTransportistabutton.Name = "buscarDniTransportistabutton";
            buscarDniTransportistabutton.Size = new Size(75, 23);
            buscarDniTransportistabutton.TabIndex = 12;
            buscarDniTransportistabutton.Text = "Buscar";
            buscarDniTransportistabutton.UseVisualStyleBackColor = true;
            buscarDniTransportistabutton.Click += buscarDniTransportistabutton_Click;
            // 
            // Despachar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 666);
            Controls.Add(buscarDniTransportistabutton);
            Controls.Add(label4);
            Controls.Add(dniTransportistatextBox);
            Controls.Add(cancelar_confirmacion);
            Controls.Add(ConfirmarDespachobutton);
            Controls.Add(ConfirmarTransportistabutton);
            Controls.Add(label2);
            Controls.Add(datosTrasportistas);
            Controls.Add(label1);
            Controls.Add(OrdenesPorDespacharlistView);
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
        private Label label1;
        private ListView datosTrasportistas;
        private Label label2;
        private Button ConfirmarTransportistabutton;
        private Button ConfirmarDespachobutton;
        private ColumnHeader codtransportista;
        private ColumnHeader transportistaCod;
        private ColumnHeader dni_id;
        private ColumnHeader nombre_transportista;
        private ColumnHeader apellidoTrasnportista;
        private Button cancelar_confirmacion;
        private TextBox dniTransportistatextBox;
        private Label label4;
        private Button buscarDniTransportistabutton;
    }
}