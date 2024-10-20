﻿namespace GrupoC.Tp3.CDU5
{
    partial class ConsultarOrden
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
            filtrarButton = new Button();
            LimpiarButton = new Button();
            ordenTextBox = new TextBox();
            ClienteTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            listadoPedidosListView = new ListView();
            Orden = new ColumnHeader();
            Cliente = new ColumnHeader();
            Transportista = new ColumnHeader();
            Fecha = new ColumnHeader();
            Estado = new ColumnHeader();
            FechaInicioDateTimePicker = new DateTimePicker();
            label3 = new Label();
            listadoOrdenListView1 = new ListView();
            sku = new ColumnHeader();
            nombre = new ColumnHeader();
            cantidad = new ColumnHeader();
            ubicación = new ColumnHeader();
            label4 = new Label();
            FechaFinaldateTimePicker = new DateTimePicker();
            label5 = new Label();
            seleccioanarOrdenbutton = new Button();
            SuspendLayout();
            // 
            // filtrarButton
            // 
            filtrarButton.Location = new Point(713, 32);
            filtrarButton.Name = "filtrarButton";
            filtrarButton.Size = new Size(75, 23);
            filtrarButton.TabIndex = 0;
            filtrarButton.Text = "Filtrar";
            filtrarButton.UseVisualStyleBackColor = true;
            filtrarButton.Click += filtrarButton_Click;
            // 
            // LimpiarButton
            // 
            LimpiarButton.Location = new Point(794, 32);
            LimpiarButton.Name = "LimpiarButton";
            LimpiarButton.Size = new Size(75, 23);
            LimpiarButton.TabIndex = 1;
            LimpiarButton.Text = "Limpiar";
            LimpiarButton.UseVisualStyleBackColor = true;
            LimpiarButton.Click += LimpiarButton_Click;
            // 
            // ordenTextBox
            // 
            ordenTextBox.Location = new Point(46, 33);
            ordenTextBox.Name = "ordenTextBox";
            ordenTextBox.Size = new Size(100, 23);
            ordenTextBox.TabIndex = 2;
            // 
            // ClienteTextBox
            // 
            ClienteTextBox.Location = new Point(153, 33);
            ClienteTextBox.Name = "ClienteTextBox";
            ClienteTextBox.Size = new Size(100, 23);
            ClienteTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 15);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 4;
            label1.Text = "Orden";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 15);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 5;
            label2.Text = "Cliente";
            // 
            // listadoPedidosListView
            // 
            listadoPedidosListView.Columns.AddRange(new ColumnHeader[] { Orden, Cliente, Transportista, Fecha, Estado });
            listadoPedidosListView.FullRowSelect = true;
            listadoPedidosListView.LabelWrap = false;
            listadoPedidosListView.Location = new Point(46, 70);
            listadoPedidosListView.Margin = new Padding(3, 2, 3, 2);
            listadoPedidosListView.MultiSelect = false;
            listadoPedidosListView.Name = "listadoPedidosListView";
            listadoPedidosListView.Size = new Size(596, 157);
            listadoPedidosListView.TabIndex = 6;
            listadoPedidosListView.UseCompatibleStateImageBehavior = false;
            listadoPedidosListView.View = View.Details;
            // 
            // Orden
            // 
            Orden.Text = "Orden";
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
            // Fecha
            // 
            Fecha.Text = "Fecha";
            Fecha.Width = 80;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 80;
            // 
            // FechaInicioDateTimePicker
            // 
            FechaInicioDateTimePicker.Location = new Point(259, 33);
            FechaInicioDateTimePicker.Margin = new Padding(3, 2, 3, 2);
            FechaInicioDateTimePicker.Name = "FechaInicioDateTimePicker";
            FechaInicioDateTimePicker.Size = new Size(221, 23);
            FechaInicioDateTimePicker.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(259, 15);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 8;
            label3.Text = "Fecha inicio";
            label3.Click += label3_Click;
            // 
            // listadoOrdenListView1
            // 
            listadoOrdenListView1.Columns.AddRange(new ColumnHeader[] { sku, nombre, cantidad, ubicación });
            listadoOrdenListView1.FullRowSelect = true;
            listadoOrdenListView1.LabelWrap = false;
            listadoOrdenListView1.Location = new Point(46, 325);
            listadoOrdenListView1.Margin = new Padding(3, 2, 3, 2);
            listadoOrdenListView1.MultiSelect = false;
            listadoOrdenListView1.Name = "listadoOrdenListView1";
            listadoOrdenListView1.Size = new Size(596, 174);
            listadoOrdenListView1.TabIndex = 9;
            listadoOrdenListView1.UseCompatibleStateImageBehavior = false;
            listadoOrdenListView1.View = View.Details;
            listadoOrdenListView1.SelectedIndexChanged += listadoOrdenListView1_SelectedIndexChanged;
            // 
            // sku
            // 
            sku.Text = "Codigo Producto";
            sku.Width = 120;
            // 
            // nombre
            // 
            nombre.Text = "Nombre producto";
            nombre.TextAlign = HorizontalAlignment.Center;
            nombre.Width = 120;
            // 
            // cantidad
            // 
            cantidad.Text = "Cantidad";
            // 
            // ubicación
            // 
            ubicación.Text = "Ubicación deposito";
            ubicación.TextAlign = HorizontalAlignment.Center;
            ubicación.Width = 120;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 308);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 10;
            label4.Text = "Orden seleccionada:";
            // 
            // FechaFinaldateTimePicker
            // 
            FechaFinaldateTimePicker.Location = new Point(486, 33);
            FechaFinaldateTimePicker.Margin = new Padding(3, 2, 3, 2);
            FechaFinaldateTimePicker.Name = "FechaFinaldateTimePicker";
            FechaFinaldateTimePicker.Size = new Size(221, 23);
            FechaFinaldateTimePicker.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(486, 16);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 12;
            label5.Text = "Fecha final";
            // 
            // seleccioanarOrdenbutton
            // 
            seleccioanarOrdenbutton.Location = new Point(567, 232);
            seleccioanarOrdenbutton.Name = "seleccioanarOrdenbutton";
            seleccioanarOrdenbutton.Size = new Size(75, 23);
            seleccioanarOrdenbutton.TabIndex = 13;
            seleccioanarOrdenbutton.Text = "Seleccionar";
            seleccioanarOrdenbutton.UseVisualStyleBackColor = true;
            seleccioanarOrdenbutton.Click += seleccioanarOrdenbutton_Click;
            // 
            // ConsultarOrden
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 558);
            Controls.Add(seleccioanarOrdenbutton);
            Controls.Add(label5);
            Controls.Add(FechaFinaldateTimePicker);
            Controls.Add(label4);
            Controls.Add(listadoOrdenListView1);
            Controls.Add(label3);
            Controls.Add(FechaInicioDateTimePicker);
            Controls.Add(listadoPedidosListView);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ClienteTextBox);
            Controls.Add(ordenTextBox);
            Controls.Add(LimpiarButton);
            Controls.Add(filtrarButton);
            Name = "ConsultarOrden";
            Text = "ConsultarOrdenForm";
            Load += ConsultarOrden_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button filtrarButton;
        private Button LimpiarButton;
        private TextBox ordenTextBox;
        private TextBox ClienteTextBox;
        private Label label1;
        private Label label2;
        private ListView listadoPedidosListView;
        private ColumnHeader Orden;
        private ColumnHeader Cliente;
        private ColumnHeader Transportista;
        private ColumnHeader Fecha;
        private ColumnHeader Estado;
        private DateTimePicker FechaInicioDateTimePicker;
        private Label label3;
        private ListView listadoOrdenListView1;
        private ColumnHeader sku;
        private ColumnHeader nombre;
        private ColumnHeader cantidad;
        private Label label4;
        private ColumnHeader ubicación;
        private DateTimePicker FechaFinaldateTimePicker;
        private Label label5;
        private Button seleccioanarOrdenbutton;
    }
}