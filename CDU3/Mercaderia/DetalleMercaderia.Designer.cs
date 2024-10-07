namespace GrupoC.Tp3.CDU3.Mercaderia
{
    partial class DetalleMercaderia
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
            list_detalle_mercaderia = new ListView();
            cod_producto = new ColumnHeader();
            descripcion = new ColumnHeader();
            cantidad = new ColumnHeader();
            confirmar_button = new Button();
            cancelar_button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 34);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 0;
            label1.Text = "Detalle de Mercaderia";
            // 
            // list_detalle_mercaderia
            // 
            list_detalle_mercaderia.BackColor = SystemColors.ScrollBar;
            list_detalle_mercaderia.Columns.AddRange(new ColumnHeader[] { cod_producto, descripcion, cantidad });
            list_detalle_mercaderia.Location = new Point(47, 78);
            list_detalle_mercaderia.Name = "list_detalle_mercaderia";
            list_detalle_mercaderia.Size = new Size(534, 154);
            list_detalle_mercaderia.TabIndex = 1;
            list_detalle_mercaderia.UseCompatibleStateImageBehavior = false;
            list_detalle_mercaderia.View = View.Details;
            // 
            // cod_producto
            // 
            cod_producto.Text = "Cod Producto";
            cod_producto.Width = 120;
            // 
            // descripcion
            // 
            descripcion.Text = "Descripción";
            descripcion.Width = 140;
            // 
            // cantidad
            // 
            cantidad.Text = "Cantidad";
            cantidad.Width = 80;
            // 
            // confirmar_button
            // 
            confirmar_button.Location = new Point(182, 266);
            confirmar_button.Name = "confirmar_button";
            confirmar_button.Size = new Size(106, 46);
            confirmar_button.TabIndex = 2;
            confirmar_button.Text = "Confirmar";
            confirmar_button.UseVisualStyleBackColor = true;
            confirmar_button.Click += ConfirmarButton_Click;
            // 
            // cancelar_button
            // 
            cancelar_button.Location = new Point(316, 266);
            cancelar_button.Name = "cancelar_button";
            cancelar_button.Size = new Size(106, 46);
            cancelar_button.TabIndex = 3;
            cancelar_button.Text = "Cancelar";
            cancelar_button.UseVisualStyleBackColor = true;
            cancelar_button.Click += cancelar_Click;
            // 
            // DetalleMercaderia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 378);
            Controls.Add(cancelar_button);
            Controls.Add(confirmar_button);
            Controls.Add(list_detalle_mercaderia);
            Controls.Add(label1);
            Name = "DetalleMercaderia";
            Text = "Detalle de Mercaderia";
            Load += DetalleMercaderia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView list_detalle_mercaderia;
        private ColumnHeader cod_producto;
        private ColumnHeader descripcion;
        private ColumnHeader cantidad;
        private Button confirmar_button;
        private Button cancelar_button;
    }
}