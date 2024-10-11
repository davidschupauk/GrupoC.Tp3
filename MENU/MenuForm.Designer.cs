namespace GrupoC.Tp3.MENU
{
    partial class MenuForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

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
            botonGenerarOrdenDePreparacion.Location = new Point(50, 80);
            botonGenerarOrdenDePreparacion.Size = new Size(700, 80);
            botonGenerarOrdenDePreparacion.Name = "botonGenerarOrdenDePreparacion";
            botonGenerarOrdenDePreparacion.TabIndex = 0;
            botonGenerarOrdenDePreparacion.Text = "Generar orden de preparación";
            botonGenerarOrdenDePreparacion.UseVisualStyleBackColor = true;
            botonGenerarOrdenDePreparacion.Click += new System.EventHandler(this.botonGenerarOrdenDePreparacion_Click);
            // 
            // botonGenerarOrdenSeleccion
            // 
            botonGenerarOrdenSeleccion.Location = new Point(50, 180);
            botonGenerarOrdenSeleccion.Size = new Size(700, 80);
            botonGenerarOrdenSeleccion.Name = "botonGenerarOrdenSeleccion";
            botonGenerarOrdenSeleccion.TabIndex = 1;
            botonGenerarOrdenSeleccion.Text = "Generar orden de selección";
            botonGenerarOrdenSeleccion.UseVisualStyleBackColor = true;
            botonGenerarOrdenSeleccion.Click += botonGenerarOrdenSeleccion_Click;
            // 
            // botonGenerarDocumentos
            // 
            botonGenerarDocumentos.Location = new Point(50, 280);
            botonGenerarDocumentos.Size = new Size(700, 80);
            botonGenerarDocumentos.Name = "botonGenerarDocumentos";
            botonGenerarDocumentos.TabIndex = 2;
            botonGenerarDocumentos.Text = "Generar Documentos y confirmar entrega";
            botonGenerarDocumentos.UseVisualStyleBackColor = true;
            botonGenerarDocumentos.Click += botonGenerarDocumentos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 20);
            label1.Name = "label1";
            label1.Size = new Size(300, 30);
            label1.TabIndex = 3;
            label1.Text = "Preparación y despacho de órdenes";
            // 
            // botonSalir
            // 
            botonSalir.Location = new Point(600, 400);
            botonSalir.Size = new Size(150, 60);
            botonSalir.Name = "botonSalir";
            botonSalir.TabIndex = 4;
            botonSalir.Text = "Salir";
            botonSalir.UseVisualStyleBackColor = true;
            botonSalir.Click += botonSalir_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(botonSalir);
            Controls.Add(label1);
            Controls.Add(botonGenerarDocumentos);
            Controls.Add(botonGenerarOrdenSeleccion);
            Controls.Add(botonGenerarOrdenDePreparacion);
            Name = "MenuForm";
            Text = "Preparación y despacho de órdenes";
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
