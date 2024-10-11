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
            ConfirmarOrdenDeSeleccion = new Button();
            SuspendLayout();
            // 
            // botonGenerarOrdenDePreparacion
            // 
            botonGenerarOrdenDePreparacion.Location = new Point(81, 128);
            botonGenerarOrdenDePreparacion.Margin = new Padding(5);
            botonGenerarOrdenDePreparacion.Name = "botonGenerarOrdenDePreparacion";
            botonGenerarOrdenDePreparacion.Size = new Size(1138, 128);
            botonGenerarOrdenDePreparacion.TabIndex = 0;
            botonGenerarOrdenDePreparacion.Text = "Generar orden de preparación";
            botonGenerarOrdenDePreparacion.UseVisualStyleBackColor = true;
            botonGenerarOrdenDePreparacion.Click += botonGenerarOrdenDePreparacion_Click;
            // 
            // botonGenerarOrdenSeleccion
            // 
            botonGenerarOrdenSeleccion.Location = new Point(81, 288);
            botonGenerarOrdenSeleccion.Margin = new Padding(5);
            botonGenerarOrdenSeleccion.Name = "botonGenerarOrdenSeleccion";
            botonGenerarOrdenSeleccion.Size = new Size(1138, 128);
            botonGenerarOrdenSeleccion.TabIndex = 1;
            botonGenerarOrdenSeleccion.Text = "Generar orden de selección";
            botonGenerarOrdenSeleccion.UseVisualStyleBackColor = true;
            botonGenerarOrdenSeleccion.Click += botonGenerarOrdenSeleccion_Click;
            // 
            // botonGenerarDocumentos
            // 
            botonGenerarDocumentos.Location = new Point(81, 598);
            botonGenerarDocumentos.Margin = new Padding(5);
            botonGenerarDocumentos.Name = "botonGenerarDocumentos";
            botonGenerarDocumentos.Size = new Size(1138, 128);
            botonGenerarDocumentos.TabIndex = 2;
            botonGenerarDocumentos.Text = "Generar remito y confirmar entrega";
            botonGenerarDocumentos.UseVisualStyleBackColor = true;
            botonGenerarDocumentos.Click += botonGenerarDocumentos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 32);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(394, 32);
            label1.TabIndex = 3;
            label1.Text = "Preparación y despacho de órdenes";
            // 
            // botonSalir
            // 
            botonSalir.Location = new Point(1161, 1009);
            botonSalir.Margin = new Padding(5);
            botonSalir.Name = "botonSalir";
            botonSalir.Size = new Size(244, 96);
            botonSalir.TabIndex = 4;
            botonSalir.Text = "Salir";
            botonSalir.UseVisualStyleBackColor = true;
            botonSalir.Click += botonSalir_Click;
            // 
            // ConfirmarOrdenDeSeleccion
            // 
            ConfirmarOrdenDeSeleccion.Location = new Point(81, 453);
            ConfirmarOrdenDeSeleccion.Name = "ConfirmarOrdenDeSeleccion";
            ConfirmarOrdenDeSeleccion.Size = new Size(1138, 114);
            ConfirmarOrdenDeSeleccion.TabIndex = 5;
            ConfirmarOrdenDeSeleccion.Text = "Confirmar orden de seleccion";
            ConfirmarOrdenDeSeleccion.UseVisualStyleBackColor = true;
            ConfirmarOrdenDeSeleccion.Click += ConfirmarOrdenDeSeleccion_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 1133);
            Controls.Add(ConfirmarOrdenDeSeleccion);
            Controls.Add(botonSalir);
            Controls.Add(label1);
            Controls.Add(botonGenerarDocumentos);
            Controls.Add(botonGenerarOrdenSeleccion);
            Controls.Add(botonGenerarOrdenDePreparacion);
            Margin = new Padding(5);
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
        private Button ConfirmarOrdenDeSeleccion;
    }
}
