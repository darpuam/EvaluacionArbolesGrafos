namespace EvaluacionArbolesGrafos
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Arbol = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.tbCargo = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.tbNuevoEmpleado = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.Label();
            this.tbJefeSuperior = new System.Windows.Forms.TextBox();
            this.lblJefeSuperior = new System.Windows.Forms.Label();
            this.Grafo = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEdificio1 = new System.Windows.Forms.TextBox();
            this.tbEdifiicio2 = new System.Windows.Forms.TextBox();
            this.tbDistancia = new System.Windows.Forms.TextBox();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.lblEdificio1 = new System.Windows.Forms.Label();
            this.lblEdificio2 = new System.Windows.Forms.Label();
            this.btnCrearRuta = new System.Windows.Forms.Button();
            this.btnAgregarEdificio = new System.Windows.Forms.Button();
            this.lstRutas = new System.Windows.Forms.ListBox();
            this.btnCalcularRuta = new System.Windows.Forms.Button();
            this.lblResultadoRuta = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Arbol.SuspendLayout();
            this.Grafo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Arbol);
            this.tabControl1.Controls.Add(this.Grafo);
            this.tabControl1.Location = new System.Drawing.Point(84, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(408, 437);
            this.tabControl1.TabIndex = 0;
            // 
            // Arbol
            // 
            this.Arbol.Controls.Add(this.label1);
            this.Arbol.Controls.Add(this.treeView1);
            this.Arbol.Controls.Add(this.btnAgregarEmpleado);
            this.Arbol.Controls.Add(this.tbCargo);
            this.Arbol.Controls.Add(this.lblCargo);
            this.Arbol.Controls.Add(this.tbNuevoEmpleado);
            this.Arbol.Controls.Add(this.c);
            this.Arbol.Controls.Add(this.tbJefeSuperior);
            this.Arbol.Controls.Add(this.lblJefeSuperior);
            this.Arbol.Location = new System.Drawing.Point(4, 25);
            this.Arbol.Name = "Arbol";
            this.Arbol.Padding = new System.Windows.Forms.Padding(3);
            this.Arbol.Size = new System.Drawing.Size(400, 408);
            this.Arbol.TabIndex = 0;
            this.Arbol.Text = "Arbol";
            this.Arbol.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(37, 138);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(330, 254);
            this.treeView1.TabIndex = 7;
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(267, 16);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(100, 55);
            this.btnAgregarEmpleado.TabIndex = 6;
            this.btnAgregarEmpleado.Text = "Agregar a la jerarquia";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = true;
            // 
            // tbCargo
            // 
            this.tbCargo.Location = new System.Drawing.Point(87, 88);
            this.tbCargo.Name = "tbCargo";
            this.tbCargo.Size = new System.Drawing.Size(100, 22);
            this.tbCargo.TabIndex = 5;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(34, 88);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(47, 16);
            this.lblCargo.TabIndex = 4;
            this.lblCargo.Text = "Cargo:";
            // 
            // tbNuevoEmpleado
            // 
            this.tbNuevoEmpleado.Location = new System.Drawing.Point(156, 55);
            this.tbNuevoEmpleado.Name = "tbNuevoEmpleado";
            this.tbNuevoEmpleado.Size = new System.Drawing.Size(100, 22);
            this.tbNuevoEmpleado.TabIndex = 3;
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(34, 55);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(116, 16);
            this.c.TabIndex = 2;
            this.c.Text = "Nuevo Empleado:";
            // 
            // tbJefeSuperior
            // 
            this.tbJefeSuperior.Location = new System.Drawing.Point(128, 18);
            this.tbJefeSuperior.Name = "tbJefeSuperior";
            this.tbJefeSuperior.Size = new System.Drawing.Size(100, 22);
            this.tbJefeSuperior.TabIndex = 1;
            // 
            // lblJefeSuperior
            // 
            this.lblJefeSuperior.AutoSize = true;
            this.lblJefeSuperior.Location = new System.Drawing.Point(34, 18);
            this.lblJefeSuperior.Name = "lblJefeSuperior";
            this.lblJefeSuperior.Size = new System.Drawing.Size(90, 16);
            this.lblJefeSuperior.TabIndex = 0;
            this.lblJefeSuperior.Text = "Jefe Superior:";
            // 
            // Grafo
            // 
            this.Grafo.Controls.Add(this.lblResultadoRuta);
            this.Grafo.Controls.Add(this.btnCalcularRuta);
            this.Grafo.Controls.Add(this.lstRutas);
            this.Grafo.Controls.Add(this.btnAgregarEdificio);
            this.Grafo.Controls.Add(this.btnCrearRuta);
            this.Grafo.Controls.Add(this.lblEdificio2);
            this.Grafo.Controls.Add(this.lblEdificio1);
            this.Grafo.Controls.Add(this.lblDistancia);
            this.Grafo.Controls.Add(this.tbDistancia);
            this.Grafo.Controls.Add(this.tbEdifiicio2);
            this.Grafo.Controls.Add(this.tbEdificio1);
            this.Grafo.Location = new System.Drawing.Point(4, 25);
            this.Grafo.Name = "Grafo";
            this.Grafo.Padding = new System.Windows.Forms.Padding(3);
            this.Grafo.Size = new System.Drawing.Size(400, 408);
            this.Grafo.TabIndex = 1;
            this.Grafo.Text = "Grafo";
            this.Grafo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "lblTotalEmpleados";
            // 
            // tbEdificio1
            // 
            this.tbEdificio1.Location = new System.Drawing.Point(119, 25);
            this.tbEdificio1.Name = "tbEdificio1";
            this.tbEdificio1.Size = new System.Drawing.Size(100, 22);
            this.tbEdificio1.TabIndex = 0;
            // 
            // tbEdifiicio2
            // 
            this.tbEdifiicio2.Location = new System.Drawing.Point(119, 62);
            this.tbEdifiicio2.Name = "tbEdifiicio2";
            this.tbEdifiicio2.Size = new System.Drawing.Size(100, 22);
            this.tbEdifiicio2.TabIndex = 1;
            // 
            // tbDistancia
            // 
            this.tbDistancia.Location = new System.Drawing.Point(119, 101);
            this.tbDistancia.Name = "tbDistancia";
            this.tbDistancia.Size = new System.Drawing.Size(100, 22);
            this.tbDistancia.TabIndex = 2;
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(41, 107);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(66, 16);
            this.lblDistancia.TabIndex = 3;
            this.lblDistancia.Text = "Distancia:";
            // 
            // lblEdificio1
            // 
            this.lblEdificio1.AutoSize = true;
            this.lblEdificio1.Location = new System.Drawing.Point(44, 30);
            this.lblEdificio1.Name = "lblEdificio1";
            this.lblEdificio1.Size = new System.Drawing.Size(64, 16);
            this.lblEdificio1.TabIndex = 4;
            this.lblEdificio1.Text = "Edificio 1:";
            // 
            // lblEdificio2
            // 
            this.lblEdificio2.AutoSize = true;
            this.lblEdificio2.Location = new System.Drawing.Point(44, 68);
            this.lblEdificio2.Name = "lblEdificio2";
            this.lblEdificio2.Size = new System.Drawing.Size(64, 16);
            this.lblEdificio2.TabIndex = 5;
            this.lblEdificio2.Text = "Edificio 2:";
            // 
            // btnCrearRuta
            // 
            this.btnCrearRuta.Location = new System.Drawing.Point(261, 60);
            this.btnCrearRuta.Name = "btnCrearRuta";
            this.btnCrearRuta.Size = new System.Drawing.Size(115, 32);
            this.btnCrearRuta.TabIndex = 6;
            this.btnCrearRuta.Text = "Crear Conexion";
            this.btnCrearRuta.UseVisualStyleBackColor = true;
            // 
            // btnAgregarEdificio
            // 
            this.btnAgregarEdificio.Location = new System.Drawing.Point(249, 22);
            this.btnAgregarEdificio.Name = "btnAgregarEdificio";
            this.btnAgregarEdificio.Size = new System.Drawing.Size(136, 32);
            this.btnAgregarEdificio.TabIndex = 7;
            this.btnAgregarEdificio.Text = "Registrar Edificio";
            this.btnAgregarEdificio.UseVisualStyleBackColor = true;
            // 
            // lstRutas
            // 
            this.lstRutas.FormattingEnabled = true;
            this.lstRutas.ItemHeight = 16;
            this.lstRutas.Location = new System.Drawing.Point(75, 166);
            this.lstRutas.Name = "lstRutas";
            this.lstRutas.Size = new System.Drawing.Size(254, 180);
            this.lstRutas.TabIndex = 8;
            // 
            // btnCalcularRuta
            // 
            this.btnCalcularRuta.Location = new System.Drawing.Point(261, 98);
            this.btnCalcularRuta.Name = "btnCalcularRuta";
            this.btnCalcularRuta.Size = new System.Drawing.Size(115, 32);
            this.btnCalcularRuta.TabIndex = 9;
            this.btnCalcularRuta.Text = "Calcular Ruta";
            this.btnCalcularRuta.UseVisualStyleBackColor = true;
            // 
            // lblResultadoRuta
            // 
            this.lblResultadoRuta.AutoSize = true;
            this.lblResultadoRuta.Location = new System.Drawing.Point(101, 189);
            this.lblResultadoRuta.Name = "lblResultadoRuta";
            this.lblResultadoRuta.Size = new System.Drawing.Size(7, 112);
            this.lblResultadoRuta.TabIndex = 10;
            this.lblResultadoRuta.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 498);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "ArbolesGrafos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Arbol.ResumeLayout(false);
            this.Arbol.PerformLayout();
            this.Grafo.ResumeLayout(false);
            this.Grafo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Arbol;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.TextBox tbJefeSuperior;
        private System.Windows.Forms.Label lblJefeSuperior;
        private System.Windows.Forms.TabPage Grafo;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.TextBox tbCargo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox tbNuevoEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEdificio1;
        private System.Windows.Forms.Button btnAgregarEdificio;
        private System.Windows.Forms.Button btnCrearRuta;
        private System.Windows.Forms.Label lblEdificio2;
        private System.Windows.Forms.Label lblEdificio1;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.TextBox tbDistancia;
        private System.Windows.Forms.TextBox tbEdifiicio2;
        private System.Windows.Forms.Label lblResultadoRuta;
        private System.Windows.Forms.Button btnCalcularRuta;
        private System.Windows.Forms.ListBox lstRutas;
    }
}

