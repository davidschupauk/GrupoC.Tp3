namespace GrupoC.Tp3.CDU6
{
    partial class Empaquetado
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
            orden_empaquetado = new Label();
            confirmar_empaquetado = new Button();
            cancelar = new Button();
            detalle_productos = new ListView();
            id_producto = new ColumnHeader();
            cantidad = new ColumnHeader();
            descripcion = new ColumnHeader();
            label1 = new Label();
            mostrar_detalle = new Button();
            confirmarEmpaquetados = new ListView();
            IdOrden = new ColumnHeader();
            IdCliente = new ColumnHeader();
            SuspendLayout();
            // 
            // orden_empaquetado
            // 
            orden_empaquetado.AutoSize = true;
            orden_empaquetado.Location = new Point(28, 17);
            orden_empaquetado.Name = "orden_empaquetado";
            orden_empaquetado.Size = new Size(139, 15);
            orden_empaquetado.TabIndex = 2;
            orden_empaquetado.Text = "Ordenes por Empaquetar";
            // 
            // confirmar_empaquetado
            // 
            confirmar_empaquetado.Location = new Point(28, 432);
            confirmar_empaquetado.Margin = new Padding(3, 2, 3, 2);
            confirmar_empaquetado.Name = "confirmar_empaquetado";
            confirmar_empaquetado.Size = new Size(154, 22);
            confirmar_empaquetado.TabIndex = 7;
            confirmar_empaquetado.Text = "Empaquetar";
            confirmar_empaquetado.UseVisualStyleBackColor = true;
            confirmar_empaquetado.Click += ConfirmarButton_Click;
            // 
            // cancelar
            // 
            cancelar.BackgroundImageLayout = ImageLayout.Stretch;
            cancelar.Location = new Point(28, 458);
            cancelar.Margin = new Padding(3, 2, 3, 2);
            cancelar.Name = "cancelar";
            cancelar.Size = new Size(154, 22);
            cancelar.TabIndex = 8;
            cancelar.Text = "Cerrar";
            cancelar.UseVisualStyleBackColor = true;
            cancelar.Click += CancelarButton_Click;
            // 
            // detalle_productos
            // 
            detalle_productos.BackColor = SystemColors.ScrollBar;
            detalle_productos.Columns.AddRange(new ColumnHeader[] { id_producto, descripcion, cantidad });
            detalle_productos.Location = new Point(392, 45);
            detalle_productos.Margin = new Padding(3, 2, 3, 2);
            detalle_productos.Name = "detalle_productos";
            detalle_productos.Size = new Size(406, 384);
            detalle_productos.TabIndex = 9;
            detalle_productos.UseCompatibleStateImageBehavior = false;
            detalle_productos.View = View.Details;
            // 
            // id_producto
            // 
            id_producto.Text = "ID Producto";
            id_producto.Width = 180;
            // 
            // cantidad
            // 
            cantidad.Text = "Cantidad";
            cantidad.Width = 180;
            // 
            // descripcion
            // 
            descripcion.Text = "Descripcion";
            descripcion.Width = 120;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(392, 24);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 10;
            label1.Text = "Detalle Productos";
            // 
            // mostrar_detalle
            // 
            mostrar_detalle.Location = new Point(187, 432);
            mostrar_detalle.Margin = new Padding(3, 2, 3, 2);
            mostrar_detalle.Name = "mostrar_detalle";
            mostrar_detalle.Size = new Size(154, 22);
            mostrar_detalle.TabIndex = 11;
            mostrar_detalle.Text = "Mostrar Detalle";
            mostrar_detalle.UseVisualStyleBackColor = true;
            mostrar_detalle.Click += MostrarDetalleButton_Click;
            // 
            // confirmarEmpaquetados
            // 
            confirmarEmpaquetados.BackColor = SystemColors.ScrollBar;
            confirmarEmpaquetados.Columns.AddRange(new ColumnHeader[] { IdOrden, IdCliente });
            confirmarEmpaquetados.Enabled = false;
            confirmarEmpaquetados.FullRowSelect = true;
            confirmarEmpaquetados.Location = new Point(28, 45);
            confirmarEmpaquetados.Name = "confirmarEmpaquetados";
            confirmarEmpaquetados.Size = new Size(335, 384);
            confirmarEmpaquetados.TabIndex = 12;
            confirmarEmpaquetados.UseCompatibleStateImageBehavior = false;
            confirmarEmpaquetados.View = View.Details;
            // 
            // IdOrden
            // 
            IdOrden.Text = "ID Orden";
            IdOrden.Width = 200;
            // 
            // IdCliente
            // 
            IdCliente.Text = "ID Cliente";
            IdCliente.Width = 200;
            // 
            // Empaquetado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 499);
            Controls.Add(confirmarEmpaquetados);
            Controls.Add(mostrar_detalle);
            Controls.Add(label1);
            Controls.Add(detalle_productos);
            Controls.Add(cancelar);
            Controls.Add(confirmar_empaquetado);
            Controls.Add(orden_empaquetado);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Empaquetado";
            Text = "Empaquetado";
            Load += Empaquetado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label orden_empaquetado;
        private Button confirmar_empaquetado;
        private Button cancelar;
        private ListView detalle_productos;
        private ColumnHeader id_producto;
        private ColumnHeader cantidad;
        private Label label1;
        private Button mostrar_detalle;
        private ColumnHeader descripcion;
        private ListView confirmarEmpaquetados;
        private ColumnHeader IdOrden;
        private ColumnHeader IdCliente;
    }
}