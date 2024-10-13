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
            label_idOrden = new Label();
            idOrden_textBox = new TextBox();
            buscar_buttton = new Button();
            reiniciar_filtro_button = new Button();
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
            orden_empaquetado.Location = new Point(32, 124);
            orden_empaquetado.Name = "orden_empaquetado";
            orden_empaquetado.Size = new Size(176, 20);
            orden_empaquetado.TabIndex = 2;
            orden_empaquetado.Text = "Ordenes por Empaquetar";
            // 
            // label_idOrden
            // 
            label_idOrden.AutoSize = true;
            label_idOrden.Location = new Point(32, 37);
            label_idOrden.Name = "label_idOrden";
            label_idOrden.Size = new Size(69, 20);
            label_idOrden.TabIndex = 3;
            label_idOrden.Text = "ID Orden";
            // 
            // idOrden_textBox
            // 
            idOrden_textBox.Location = new Point(107, 37);
            idOrden_textBox.Name = "idOrden_textBox";
            idOrden_textBox.Size = new Size(236, 27);
            idOrden_textBox.TabIndex = 4;
            // 
            // buscar_buttton
            // 
            buscar_buttton.Location = new Point(107, 70);
            buscar_buttton.Name = "buscar_buttton";
            buscar_buttton.Size = new Size(115, 29);
            buscar_buttton.TabIndex = 5;
            buscar_buttton.Text = "Filtrar";
            buscar_buttton.UseVisualStyleBackColor = true;
            buscar_buttton.Click += buscar_Click;
            // 
            // reiniciar_filtro_button
            // 
            reiniciar_filtro_button.Location = new Point(228, 70);
            reiniciar_filtro_button.Name = "reiniciar_filtro_button";
            reiniciar_filtro_button.Size = new Size(115, 29);
            reiniciar_filtro_button.TabIndex = 6;
            reiniciar_filtro_button.Text = "Reiniciar Filtro";
            reiniciar_filtro_button.UseVisualStyleBackColor = true;
            reiniciar_filtro_button.Click += reiniciar_filtro_Click;
            // 
            // confirmar_empaquetado
            // 
            confirmar_empaquetado.Location = new Point(32, 576);
            confirmar_empaquetado.Name = "confirmar_empaquetado";
            confirmar_empaquetado.Size = new Size(176, 29);
            confirmar_empaquetado.TabIndex = 7;
            confirmar_empaquetado.Text = "Empaquetar";
            confirmar_empaquetado.UseVisualStyleBackColor = true;
            confirmar_empaquetado.Click += ConfirmarButton_Click;
            // 
            // cancelar
            // 
            cancelar.BackgroundImageLayout = ImageLayout.Stretch;
            cancelar.Location = new Point(32, 611);
            cancelar.Name = "cancelar";
            cancelar.Size = new Size(176, 29);
            cancelar.TabIndex = 8;
            cancelar.Text = "Cerrar";
            cancelar.UseVisualStyleBackColor = true;
            cancelar.Click += CancelarButton_Click;
            // 
            // detalle_productos
            // 
            detalle_productos.BackColor = SystemColors.ScrollBar;
            detalle_productos.Columns.AddRange(new ColumnHeader[] { id_producto, cantidad, descripcion });
            detalle_productos.Location = new Point(448, 147);
            detalle_productos.Name = "detalle_productos";
            detalle_productos.Size = new Size(464, 423);
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
            cantidad.DisplayIndex = 2;
            cantidad.Text = "Cantidad";
            cantidad.Width = 180;
            // 
            // descripcion
            // 
            descripcion.DisplayIndex = 1;
            descripcion.Text = "Descripcion";
            descripcion.Width = 120;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(448, 124);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 10;
            label1.Text = "Detalle Productos";
            // 
            // mostrar_detalle
            // 
            mostrar_detalle.Location = new Point(214, 576);
            mostrar_detalle.Name = "mostrar_detalle";
            mostrar_detalle.Size = new Size(176, 29);
            mostrar_detalle.TabIndex = 11;
            mostrar_detalle.Text = "Mostrar Detalle";
            mostrar_detalle.UseVisualStyleBackColor = true;
            mostrar_detalle.Click += MostrarDetalleButton_Click;
            // 
            // confirmarEmpaquetados
            // 
            confirmarEmpaquetados.BackColor = SystemColors.ScrollBar;
            confirmarEmpaquetados.Columns.AddRange(new ColumnHeader[] { IdOrden, IdCliente });
            confirmarEmpaquetados.FullRowSelect = true;
            confirmarEmpaquetados.Location = new Point(32, 148);
            confirmarEmpaquetados.Margin = new Padding(3, 4, 3, 4);
            confirmarEmpaquetados.Name = "confirmarEmpaquetados";
            confirmarEmpaquetados.Size = new Size(382, 422);
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 665);
            Controls.Add(confirmarEmpaquetados);
            Controls.Add(mostrar_detalle);
            Controls.Add(label1);
            Controls.Add(detalle_productos);
            Controls.Add(cancelar);
            Controls.Add(confirmar_empaquetado);
            Controls.Add(reiniciar_filtro_button);
            Controls.Add(buscar_buttton);
            Controls.Add(idOrden_textBox);
            Controls.Add(label_idOrden);
            Controls.Add(orden_empaquetado);
            Name = "Empaquetado";
            Text = "Empaquetado";
            Load += Empaquetado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label orden_empaquetado;
        private Label label_idOrden;
        private TextBox idOrden_textBox;
        private Button buscar_buttton;
        private Button reiniciar_filtro_button;
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