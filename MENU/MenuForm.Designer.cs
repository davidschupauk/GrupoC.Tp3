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
            consultarOrdenButton = new Button();
            EmpaquetarOrden = new Button();
            SuspendLayout();
            // 
            // botonGenerarOrdenDePreparacion
            // 
            botonGenerarOrdenDePreparacion.Location = new Point(50, 55);
            botonGenerarOrdenDePreparacion.Name = "botonGenerarOrdenDePreparacion";
            botonGenerarOrdenDePreparacion.Size = new Size(701, 80);
            botonGenerarOrdenDePreparacion.TabIndex = 0;
            botonGenerarOrdenDePreparacion.Text = "Generar orden de preparación";
            botonGenerarOrdenDePreparacion.UseVisualStyleBackColor = true;
            botonGenerarOrdenDePreparacion.Click += botonGenerarOrdenDePreparacion_Click;
            // 
            // botonGenerarOrdenSeleccion
            // 
            botonGenerarOrdenSeleccion.Location = new Point(50, 155);
            botonGenerarOrdenSeleccion.Name = "botonGenerarOrdenSeleccion";
            botonGenerarOrdenSeleccion.Size = new Size(701, 80);
            botonGenerarOrdenSeleccion.TabIndex = 1;
            botonGenerarOrdenSeleccion.Text = "Generar orden de selección";
            botonGenerarOrdenSeleccion.UseVisualStyleBackColor = true;
            botonGenerarOrdenSeleccion.Click += botonGenerarOrdenSeleccion_Click;
            // 
            // botonGenerarDocumentos
            // 
            botonGenerarDocumentos.Location = new Point(50, 435);
            botonGenerarDocumentos.Name = "botonGenerarDocumentos";
            botonGenerarDocumentos.Size = new Size(701, 75);
            botonGenerarDocumentos.TabIndex = 2;
            botonGenerarDocumentos.Text = "Generar remito y confirmar entrega";
            botonGenerarDocumentos.UseVisualStyleBackColor = true;
            botonGenerarDocumentos.Click += botonGenerarDocumentos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 20);
            label1.Name = "label1";
            label1.Size = new Size(245, 20);
            label1.TabIndex = 3;
            label1.Text = "Preparación y despacho de órdenes";
            // 
            // botonSalir
            // 
            botonSalir.Location = new Point(601, 630);
            botonSalir.Name = "botonSalir";
            botonSalir.Size = new Size(150, 60);
            botonSalir.TabIndex = 4;
            botonSalir.Text = "Salir";
            botonSalir.UseVisualStyleBackColor = true;
            botonSalir.Click += botonSalir_Click;
            // 
            // ConfirmarOrdenDeSeleccion
            // 
            ConfirmarOrdenDeSeleccion.Location = new Point(50, 254);
            ConfirmarOrdenDeSeleccion.Margin = new Padding(2, 1, 2, 1);
            ConfirmarOrdenDeSeleccion.Name = "ConfirmarOrdenDeSeleccion";
            ConfirmarOrdenDeSeleccion.Size = new Size(701, 71);
            ConfirmarOrdenDeSeleccion.TabIndex = 5;
            ConfirmarOrdenDeSeleccion.Text = "Confirmar orden de seleccion";
            ConfirmarOrdenDeSeleccion.UseVisualStyleBackColor = true;
            ConfirmarOrdenDeSeleccion.Click += ConfirmarOrdenDeSeleccion_Click;
            // 
            // consultarOrdenButton
            // 
            consultarOrdenButton.Location = new Point(50, 527);
            consultarOrdenButton.Margin = new Padding(3, 4, 3, 4);
            consultarOrdenButton.Name = "consultarOrdenButton";
            consultarOrdenButton.Size = new Size(701, 66);
            consultarOrdenButton.TabIndex = 6;
            consultarOrdenButton.Text = "Consultar orden";
            consultarOrdenButton.UseVisualStyleBackColor = true;
            consultarOrdenButton.Click += consultarOrdenButton_Click;
            // 
            // EmpaquetarOrden
            // 
            EmpaquetarOrden.Location = new Point(50, 347);
            EmpaquetarOrden.Margin = new Padding(3, 4, 3, 4);
            EmpaquetarOrden.Name = "EmpaquetarOrden";
            EmpaquetarOrden.Size = new Size(701, 73);
            EmpaquetarOrden.TabIndex = 7;
            EmpaquetarOrden.Text = "Empaquetar Orden";
            EmpaquetarOrden.UseVisualStyleBackColor = true;
            EmpaquetarOrden.Click += EmpaquetarOrden_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 698);
            Controls.Add(EmpaquetarOrden);
            Controls.Add(consultarOrdenButton);
            Controls.Add(ConfirmarOrdenDeSeleccion);
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
        private Button ConfirmarOrdenDeSeleccion;
        private Button consultarOrdenButton;
        private Button EmpaquetarOrden;
    }
}
