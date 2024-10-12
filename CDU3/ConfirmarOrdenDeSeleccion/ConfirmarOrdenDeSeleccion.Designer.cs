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
            IdOrden = new ColumnHeader();
            IdCliente = new ColumnHeader();
            fecha_entrega = new ColumnHeader();
            Estado = new ColumnHeader();
            confirmarOrdenSeleccionada_button = new Button();
            cancelar_button = new Button();
            titulo_tabla_pendiente = new Label();
            buscar = new Button();
            id_orden = new Label();
            id_cliente = new Label();
            orden_id = new TextBox();
            cliente_id = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            reiniciar_filtro = new Button();
            SuspendLayout();
            // 
            // confirmarOrdenDeSeleccionlistView
            // 
            confirmarOrdenDeSeleccionlistView.BackColor = SystemColors.ScrollBar;
            confirmarOrdenDeSeleccionlistView.Columns.AddRange(new ColumnHeader[] { IdOrden, IdCliente, fecha_entrega, Estado });
            confirmarOrdenDeSeleccionlistView.FullRowSelect = true;
            confirmarOrdenDeSeleccionlistView.Location = new Point(55, 201);
            confirmarOrdenDeSeleccionlistView.Margin = new Padding(3, 4, 3, 4);
            confirmarOrdenDeSeleccionlistView.Name = "confirmarOrdenDeSeleccionlistView";
            confirmarOrdenDeSeleccionlistView.Size = new Size(549, 170);
            confirmarOrdenDeSeleccionlistView.TabIndex = 0;
            confirmarOrdenDeSeleccionlistView.UseCompatibleStateImageBehavior = false;
            confirmarOrdenDeSeleccionlistView.View = View.Details;
            confirmarOrdenDeSeleccionlistView.SelectedIndexChanged += confirmarOrdenDeSeleccionlistView_SelectedIndexChanged;
            // 
            // IdOrden
            // 
            IdOrden.Text = "ID Orden";
            IdOrden.Width = 100;
            // 
            // IdCliente
            // 
            IdCliente.Text = "ID Cliente";
            IdCliente.Width = 120;
            // 
            // fecha_entrega
            // 
            fecha_entrega.Text = "Fecha Entrega";
            fecha_entrega.Width = 120;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 100;
            // 
            // confirmarOrdenSeleccionada_button
            // 
            confirmarOrdenSeleccionada_button.Location = new Point(228, 393);
            confirmarOrdenSeleccionada_button.Name = "confirmarOrdenSeleccionada_button";
            confirmarOrdenSeleccionada_button.Size = new Size(185, 40);
            confirmarOrdenSeleccionada_button.TabIndex = 1;
            confirmarOrdenSeleccionada_button.Text = "Confirmar Orden";
            confirmarOrdenSeleccionada_button.UseVisualStyleBackColor = true;
            confirmarOrdenSeleccionada_button.Click += ConsultarButton_Click;
            // 
            // cancelar_button
            // 
            cancelar_button.Location = new Point(419, 393);
            cancelar_button.Name = "cancelar_button";
            cancelar_button.Size = new Size(185, 40);
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
            // buscar
            // 
            buscar.Location = new Point(114, 152);
            buscar.Name = "buscar";
            buscar.Size = new Size(90, 29);
            buscar.TabIndex = 4;
            buscar.Text = "Buscar";
            buscar.UseVisualStyleBackColor = true;
            buscar.Click += buscar_Click;
            // 
            // id_orden
            // 
            id_orden.AutoSize = true;
            id_orden.Location = new Point(74, 64);
            id_orden.Name = "id_orden";
            id_orden.Size = new Size(69, 20);
            id_orden.TabIndex = 6;
            id_orden.Text = "ID Orden";
            // 
            // id_cliente
            // 
            id_cliente.AutoSize = true;
            id_cliente.Location = new Point(74, 111);
            id_cliente.Name = "id_cliente";
            id_cliente.Size = new Size(74, 20);
            id_cliente.TabIndex = 7;
            id_cliente.Text = "ID Cliente";
            // 
            // orden_id
            // 
            orden_id.Location = new Point(178, 64);
            orden_id.Name = "orden_id";
            orden_id.Size = new Size(146, 27);
            orden_id.TabIndex = 8;
            // 
            // cliente_id
            // 
            cliente_id.Location = new Point(178, 104);
            cliente_id.Name = "cliente_id";
            cliente_id.Size = new Size(146, 27);
            cliente_id.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // reiniciar_filtro
            // 
            reiniciar_filtro.Location = new Point(210, 152);
            reiniciar_filtro.Name = "reiniciar_filtro";
            reiniciar_filtro.Size = new Size(114, 29);
            reiniciar_filtro.TabIndex = 10;
            reiniciar_filtro.Text = "Reiniciar Filtro";
            reiniciar_filtro.UseVisualStyleBackColor = true;
            reiniciar_filtro.Click += reiniciar_filtro_Click;
            // 
            // ConfirmarOrdenDeSeleccion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 531);
            Controls.Add(reiniciar_filtro);
            Controls.Add(cliente_id);
            Controls.Add(orden_id);
            Controls.Add(id_cliente);
            Controls.Add(id_orden);
            Controls.Add(buscar);
            Controls.Add(titulo_tabla_pendiente);
            Controls.Add(cancelar_button);
            Controls.Add(confirmarOrdenSeleccionada_button);
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
        private ColumnHeader IdOrden;
        private ColumnHeader IdCliente;
        private ColumnHeader Estado;
        private Button confirmarOrdenSeleccionada_button;
        private Button cancelar_button;
        private Label titulo_tabla_pendiente;
        private ColumnHeader fecha_entrega;
        private Button buscar;
        private Label id_orden;
        private Label id_cliente;
        private TextBox orden_id;
        private TextBox cliente_id;
        private OpenFileDialog openFileDialog1;
        private Button reiniciar_filtro;
    }
}