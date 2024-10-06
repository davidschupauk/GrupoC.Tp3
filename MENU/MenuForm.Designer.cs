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
            botonGenerarOrdenPreparacion.Location = new Point(30, 201);
            botonGenerarOrdenPreparacion.Name = "botonGenerarOrdenPreparacion";
            botonGenerarOrdenPreparacion.Size = new Size(758, 68);
            botonGenerarOrdenPreparacion.TabIndex = 0;
            botonGenerarOrdenPreparacion.Text = "Generar orden de preparación";
            botonGenerarOrdenPreparacion.UseVisualStyleBackColor = true;
            botonGenerarOrdenPreparacion.Click += botonGenerarOrdenPreparacion_Click;
            // 
            // botonGenerarOrdenSeleccion
            // 
            botonGenerarOrdenSeleccion.Location = new Point(30, 127);
            botonGenerarOrdenSeleccion.Name = "botonGenerarOrdenSeleccion";
            botonGenerarOrdenSeleccion.Size = new Size(758, 68);
            botonGenerarOrdenSeleccion.TabIndex = 2;
            botonGenerarOrdenSeleccion.Text = "Generar orden de selección";
            botonGenerarOrdenSeleccion.UseVisualStyleBackColor = true;
            botonGenerarOrdenSeleccion.Click += botonGenerarOrdenSeleccion_Click;
            // 
            // botonGenerarDocumentos
            // 
            botonGenerarDocumentos.Location = new Point(30, 275);
            botonGenerarDocumentos.Name = "botonGenerarDocumentos";
            botonGenerarDocumentos.Size = new Size(758, 68);
            botonGenerarDocumentos.TabIndex = 3;
            botonGenerarDocumentos.Text = "Generar Documentos y confirmar entrega";
            botonGenerarDocumentos.UseVisualStyleBackColor = true;
            botonGenerarDocumentos.Click += botonGenerarDocumentos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 9);
            label1.Name = "label1";
            label1.Size = new Size(295, 25);
            label1.TabIndex = 5;
            label1.Text = "Preparación y despacho de ordenes";
            // 
            // botonSalir
            // 
            botonSalir.Location = new Point(647, 356);
            botonSalir.Name = "botonSalir";
            botonSalir.Size = new Size(141, 53);
            botonSalir.TabIndex = 6;
            botonSalir.Text = "Salir";
            botonSalir.UseVisualStyleBackColor = true;
            botonSalir.Click += botonSalir_Click;
            // 
            // botonBuscarCliente
            // 
            botonBuscarCliente.Location = new Point(30, 53);
            botonBuscarCliente.Name = "botonBuscarCliente";
            botonBuscarCliente.Size = new Size(758, 68);
            botonBuscarCliente.TabIndex = 7;
            botonBuscarCliente.Text = "Buscar cliente";
            botonBuscarCliente.UseVisualStyleBackColor = true;
            botonBuscarCliente.Click += botonBuscarCliente_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 421);
            Controls.Add(botonBuscarCliente);
            Controls.Add(botonSalir);
            Controls.Add(label1);
            Controls.Add(botonGenerarDocumentos);
            Controls.Add(botonGenerarOrdenSeleccion);
            Controls.Add(botonGenerarOrdenPreparacion);
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