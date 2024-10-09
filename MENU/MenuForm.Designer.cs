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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            botonGenerarOrdenDePreparacion = new Button();
            botonGenerarOrdenSeleccion = new Button();
            botonGenerarDocumentos = new Button();
            label1 = new Label();
            botonSalir = new Button();
            SuspendLayout();
            // 
            // botonGenerarOrdenDePreparacion
            // 
            this.botonGenerarOrdenDePreparacion = new System.Windows.Forms.Button();           
            this.botonGenerarOrdenDePreparacion.Location = new System.Drawing.Point(25, 42);
            this.botonGenerarOrdenDePreparacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonGenerarOrdenDePreparacion.Name = "botonGenerarOrdenDePreparacion";
            this.botonGenerarOrdenDePreparacion.Size = new System.Drawing.Size(606, 54);
            this.botonGenerarOrdenDePreparacion.TabIndex = 0;
            this.botonGenerarOrdenDePreparacion.Text = "Generar orden de preparación";
            this.botonGenerarOrdenDePreparacion.UseVisualStyleBackColor = true;
            this.botonGenerarOrdenDePreparacion.Click += new System.EventHandler(this.botonGenerarOrdenDePreparacion_Click);

            // 
            // botonGenerarOrdenSeleccion
            // 
            botonGenerarOrdenSeleccion.Location = new Point(25, 100);
            botonGenerarOrdenSeleccion.Margin = new Padding(2, 2, 2, 2);
            botonGenerarOrdenSeleccion.Name = "botonGenerarOrdenSeleccion";
            botonGenerarOrdenSeleccion.Size = new Size(606, 54);
            botonGenerarOrdenSeleccion.TabIndex = 1;
            botonGenerarOrdenSeleccion.Text = "Generar orden de selección";
            botonGenerarOrdenSeleccion.UseVisualStyleBackColor = true;
            botonGenerarOrdenSeleccion.Click += botonGenerarOrdenSeleccion_Click;
            // 
            // botonGenerarDocumentos
            // 
            botonGenerarDocumentos.Location = new Point(25, 158);
            botonGenerarDocumentos.Margin = new Padding(2, 2, 2, 2);
            botonGenerarDocumentos.Name = "botonGenerarDocumentos";
            botonGenerarDocumentos.Size = new Size(606, 54);
            botonGenerarDocumentos.TabIndex = 2;
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
            label1.TabIndex = 3;
            label1.Text = "Preparación y despacho de ordenes";
            // 
            // botonSalir
            // 
            botonSalir.Location = new Point(518, 216);
            botonSalir.Margin = new Padding(2, 2, 2, 2);
            botonSalir.Name = "botonSalir";
            botonSalir.Size = new Size(113, 42);
            botonSalir.TabIndex = 4;
            botonSalir.Text = "Salir";
            botonSalir.UseVisualStyleBackColor = true;
            botonSalir.Click += botonSalir_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 275);
            Controls.Add(botonSalir);
            Controls.Add(label1);
            Controls.Add(botonGenerarDocumentos);
            Controls.Add(botonGenerarOrdenSeleccion);
            Controls.Add(botonGenerarOrdenDePreparacion);
            Margin = new Padding(2, 2, 2, 2);
            Name = "MenuForm";
            Text = "Preparación y despacho de ordenes";
            Load += MenuForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonGenerarOrdenDePreparacion;
        private Button botonGenerarOrdenSeleccion;
        private Button botonGenerarDocumentos;
        private Label label1;
        private Button botonSalir;
    }
}
