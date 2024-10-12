namespace GrupoC.Tp3.CDU6
{
    partial class EmpaquetarOrden
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "101", "Axioma" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "Teclado", "5" }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "Monitor", "10" }, -1);
            OrdenesEmpaquetarlistView = new ListView();
            NroOrden = new ColumnHeader();
            Cliente = new ColumnHeader();
            label1 = new Label();
            OrdenesDetallesEmpaquetarlistView = new ListView();
            Producto = new ColumnHeader();
            Cantidad = new ColumnHeader();
            label2 = new Label();
            MostrarDetallebutton = new Button();
            OrdenEmpaquetadabutton = new Button();
            SuspendLayout();
            // 
            // OrdenesEmpaquetarlistView
            // 
            OrdenesEmpaquetarlistView.Columns.AddRange(new ColumnHeader[] { NroOrden, Cliente });
            OrdenesEmpaquetarlistView.Items.AddRange(new ListViewItem[] { listViewItem1 });
            OrdenesEmpaquetarlistView.Location = new Point(12, 38);
            OrdenesEmpaquetarlistView.Name = "OrdenesEmpaquetarlistView";
            OrdenesEmpaquetarlistView.Size = new Size(280, 349);
            OrdenesEmpaquetarlistView.TabIndex = 0;
            OrdenesEmpaquetarlistView.UseCompatibleStateImageBehavior = false;
            OrdenesEmpaquetarlistView.View = View.Details;
            // 
            // NroOrden
            // 
            NroOrden.Text = "Nro Orden";
            NroOrden.Width = 90;
            // 
            // Cliente
            // 
            Cliente.Text = "Cliente";
            Cliente.Width = 90;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(139, 15);
            label1.TabIndex = 1;
            label1.Text = "Ordenes por empaquetar";
            // 
            // OrdenesDetallesEmpaquetarlistView
            // 
            OrdenesDetallesEmpaquetarlistView.Columns.AddRange(new ColumnHeader[] { Producto, Cantidad });
            OrdenesDetallesEmpaquetarlistView.Items.AddRange(new ListViewItem[] { listViewItem2, listViewItem3 });
            OrdenesDetallesEmpaquetarlistView.Location = new Point(335, 38);
            OrdenesDetallesEmpaquetarlistView.Name = "OrdenesDetallesEmpaquetarlistView";
            OrdenesDetallesEmpaquetarlistView.Size = new Size(594, 349);
            OrdenesDetallesEmpaquetarlistView.TabIndex = 2;
            OrdenesDetallesEmpaquetarlistView.UseCompatibleStateImageBehavior = false;
            OrdenesDetallesEmpaquetarlistView.View = View.Details;
            // 
            // Producto
            // 
            Producto.Text = "Producto";
            Producto.Width = 70;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(335, 20);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 3;
            label2.Text = "Detalles";
            // 
            // MostrarDetallebutton
            // 
            MostrarDetallebutton.Location = new Point(27, 393);
            MostrarDetallebutton.Name = "MostrarDetallebutton";
            MostrarDetallebutton.Size = new Size(124, 23);
            MostrarDetallebutton.TabIndex = 4;
            MostrarDetallebutton.Text = "Mostrar detalle";
            MostrarDetallebutton.UseVisualStyleBackColor = true;
            // 
            // OrdenEmpaquetadabutton
            // 
            OrdenEmpaquetadabutton.Location = new Point(157, 393);
            OrdenEmpaquetadabutton.Name = "OrdenEmpaquetadabutton";
            OrdenEmpaquetadabutton.Size = new Size(135, 23);
            OrdenEmpaquetadabutton.TabIndex = 5;
            OrdenEmpaquetadabutton.Text = "Orden empaquetada";
            OrdenEmpaquetadabutton.UseVisualStyleBackColor = true;
            // 
            // EmpaquetarOrden
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 496);
            Controls.Add(OrdenEmpaquetadabutton);
            Controls.Add(MostrarDetallebutton);
            Controls.Add(label2);
            Controls.Add(OrdenesDetallesEmpaquetarlistView);
            Controls.Add(label1);
            Controls.Add(OrdenesEmpaquetarlistView);
            Name = "EmpaquetarOrden";
            Text = "EmpaquetarOrden";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView OrdenesEmpaquetarlistView;
        private Label label1;
        private ColumnHeader NroOrden;
        private ListView OrdenesDetallesEmpaquetarlistView;
        private ColumnHeader Producto;
        private ColumnHeader Cantidad;
        private Label label2;
        private Button MostrarDetallebutton;
        private ColumnHeader Cliente;
        private Button OrdenEmpaquetadabutton;
    }
}