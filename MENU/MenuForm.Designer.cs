namespace GrupoC.Tp3.MENU
{
    partial class MenuForm
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
            botonGenerarOrdenPreparacion = new Button();
            botonGenerarOrdenSeleccion = new Button();
            botonGenerarDocumentos = new Button();
            label1 = new Label();
            botonSalir = new Button();
            botonBuscarCliente = new Button();
            SuspendLayout();
            // 
            // botonGenerarOrdenPreparacion
            // 
            botonGenerarOrdenPreparacion.Location = new Point(25, 100);
            botonGenerarOrdenPreparacion.Margin = new Padding(2, 2, 2, 2);
            botonGenerarOrdenPreparacion.Name = "botonGenerarOrdenPreparacion";
            botonGenerarOrdenPreparacion.Size = new Size(606, 54);
            botonGenerarOrdenPreparacion.TabIndex = 0;
            botonGenerarOrdenPreparacion.Text = "Generar orden de preparación";
            botonGenerarOrdenPreparacion.UseVisualStyleBackColor = true;
            botonGenerarOrdenPreparacion.Click += botonGenerarOrdenPreparacion_Click;
            // 
            // botonGenerarOrdenSeleccion
            // 
            botonGenerarOrdenSeleccion.Location = new Point(24, 158);
            botonGenerarOrdenSeleccion.Margin = new Padding(2, 2, 2, 2);
            botonGenerarOrdenSeleccion.Name = "botonGenerarOrdenSeleccion";
            botonGenerarOrdenSeleccion.Size = new Size(606, 54);
            botonGenerarOrdenSeleccion.TabIndex = 2;
            botonGenerarOrdenSeleccion.Text = "Generar orden de selección";
            botonGenerarOrdenSeleccion.UseVisualStyleBackColor = true;
            botonGenerarOrdenSeleccion.Click += botonGenerarOrdenSeleccion_Click;
            // 
            // botonGenerarDocumentos
            // 
            botonGenerarDocumentos.Location = new Point(23, 216);
            botonGenerarDocumentos.Margin = new Padding(2, 2, 2, 2);
            botonGenerarDocumentos.Name = "botonGenerarDocumentos";
            botonGenerarDocumentos.Size = new Size(606, 54);
            botonGenerarDocumentos.TabIndex = 3;
            botonGenerarDocumentos.Text = "Generar Documentos y confirmar entrega";
            botonGenerarDocumentos.UseVisualStyleBackColor = true;
            botonGenerarDocumentos.Click += botonGenerarDocumentos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(245, 20);
            label1.TabIndex = 5;
            label1.Text = "Preparación y despacho de ordenes";
            // 
            // botonSalir
            // 
            botonSalir.Location = new Point(518, 285);
            botonSalir.Margin = new Padding(2, 2, 2, 2);
            botonSalir.Name = "botonSalir";
            botonSalir.Size = new Size(113, 42);
            botonSalir.TabIndex = 6;
            botonSalir.Text = "Salir";
            botonSalir.UseVisualStyleBackColor = true;
            botonSalir.Click += botonSalir_Click;
            // 
            // botonBuscarCliente
            // 
            botonBuscarCliente.Location = new Point(24, 42);
            botonBuscarCliente.Margin = new Padding(2, 2, 2, 2);
            botonBuscarCliente.Name = "botonBuscarCliente";
            botonBuscarCliente.Size = new Size(606, 54);
            botonBuscarCliente.TabIndex = 7;
            botonBuscarCliente.Text = "Buscar cliente";
            botonBuscarCliente.UseVisualStyleBackColor = true;
            botonBuscarCliente.Click += botonBuscarCliente_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 337);
            Controls.Add(botonBuscarCliente);
            Controls.Add(botonSalir);
            Controls.Add(label1);
            Controls.Add(botonGenerarDocumentos);
            Controls.Add(botonGenerarOrdenSeleccion);
            Controls.Add(botonGenerarOrdenPreparacion);
            Margin = new Padding(2, 2, 2, 2);
            Name = "MenuForm";
            Text = "Preparación y despacho de ordenes";
            Load += MenuForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonGenerarOrdenPreparacion;
        private Button botonGenerarOrdenSeleccion;
        private Button botonGenerarDocumentos;
        private Label label1;
        private Button botonSalir;
        private Button botonBuscarCliente;
    }
}