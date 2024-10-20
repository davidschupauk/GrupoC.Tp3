﻿namespace GrupoC.Tp3.CDU4
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
            label1 = new Label();
            pedidosPreparadosListView = new ListView();
            Orden = new ColumnHeader();
            Cliente = new ColumnHeader();
            Transportista = new ColumnHeader();
            Fecha = new ColumnHeader();
            generarBoton = new Button();
            Filtrarbutton = new Button();
            Limpiarbutton = new Button();
            OrdenTextBox = new TextBox();
            ClienteTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 136);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 0;
            label1.Text = "Pedidos Preparados";
            label1.Click += label1_Click;
            // 
            // pedidosPreparadosListView
            // 
            pedidosPreparadosListView.Columns.AddRange(new ColumnHeader[] { Orden, Cliente, Transportista, Fecha });
            pedidosPreparadosListView.FullRowSelect = true;
            pedidosPreparadosListView.LabelWrap = false;
            pedidosPreparadosListView.Location = new Point(12, 153);
            pedidosPreparadosListView.Margin = new Padding(3, 2, 3, 2);
            pedidosPreparadosListView.MultiSelect = false;
            pedidosPreparadosListView.Name = "pedidosPreparadosListView";
            pedidosPreparadosListView.Size = new Size(628, 323);
            pedidosPreparadosListView.TabIndex = 1;
            pedidosPreparadosListView.UseCompatibleStateImageBehavior = false;
            pedidosPreparadosListView.View = View.Details;
            pedidosPreparadosListView.SelectedIndexChanged += pedidosPreparadosListView_SelectedIndexChanged;
            // 
            // Orden
            // 
            Orden.Text = "Orden";
            Orden.Width = 45;
            // 
            // Cliente
            // 
            Cliente.Text = "Cliente";
            Cliente.Width = 49;
            // 
            // Transportista
            // 
            Transportista.Text = "Transportista";
            Transportista.Width = 80;
            // 
            // Fecha
            // 
            Fecha.Text = "Fecha";
            Fecha.Width = 43;
            // 
            // generarBoton
            // 
            generarBoton.Location = new Point(493, 480);
            generarBoton.Margin = new Padding(3, 2, 3, 2);
            generarBoton.Name = "generarBoton";
            generarBoton.Size = new Size(147, 34);
            generarBoton.TabIndex = 2;
            generarBoton.Text = "Generar remito";
            generarBoton.UseVisualStyleBackColor = true;
            generarBoton.Click += generarBoton_Click;
            // 
            // Filtrarbutton
            // 
            Filtrarbutton.Location = new Point(224, 32);
            Filtrarbutton.Name = "Filtrarbutton";
            Filtrarbutton.Size = new Size(75, 23);
            Filtrarbutton.TabIndex = 4;
            Filtrarbutton.Text = "Filtrar";
            Filtrarbutton.UseVisualStyleBackColor = true;
            Filtrarbutton.Click += Filtrarbutton_Click;
            // 
            // Limpiarbutton
            // 
            Limpiarbutton.Location = new Point(305, 32);
            Limpiarbutton.Name = "Limpiarbutton";
            Limpiarbutton.Size = new Size(75, 23);
            Limpiarbutton.TabIndex = 5;
            Limpiarbutton.Text = "Limpiar";
            Limpiarbutton.UseVisualStyleBackColor = true;
            Limpiarbutton.Click += Limpiarbutton_Click;
            // 
            // OrdenTextBox
            // 
            OrdenTextBox.Location = new Point(12, 32);
            OrdenTextBox.Name = "OrdenTextBox";
            OrdenTextBox.Size = new Size(100, 23);
            OrdenTextBox.TabIndex = 6;
            // 
            // ClienteTextBox
            // 
            ClienteTextBox.Location = new Point(118, 32);
            ClienteTextBox.Name = "ClienteTextBox";
            ClienteTextBox.Size = new Size(100, 23);
            ClienteTextBox.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 14);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 8;
            label2.Text = "Orden";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 14);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 9;
            label3.Text = "Cliente";
            // 
            // GenerarDocumentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 525);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ClienteTextBox);
            Controls.Add(OrdenTextBox);
            Controls.Add(Limpiarbutton);
            Controls.Add(Filtrarbutton);
            Controls.Add(generarBoton);
            Controls.Add(pedidosPreparadosListView);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "GenerarDocumentos";
            Text = "Generar Remito";
            Load += GenerarDocumentos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView pedidosPreparadosListView;
        private Button generarBoton;
        private ColumnHeader Orden;
        private ColumnHeader Cliente;
        private ColumnHeader Transportista;
        private ColumnHeader Fecha;
        private Button Filtrarbutton;
        private Button Limpiarbutton;
        private TextBox OrdenTextBox;
        private TextBox ClienteTextBox;
        private Label label2;
        private Label label3;
    }
}