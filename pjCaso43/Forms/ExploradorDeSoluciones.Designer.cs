
namespace Forms
{
    partial class ExploradorDeSoluciones
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.gbEvaluaciones = new System.Windows.Forms.GroupBox();
            this.lblEvaluacion1 = new System.Windows.Forms.Label();
            this.lblEvaluacion2 = new System.Windows.Forms.Label();
            this.lblEvaluacion3 = new System.Windows.Forms.Label();
            this.txtEvaluacion1 = new System.Windows.Forms.TextBox();
            this.txtEvaluacion2 = new System.Windows.Forms.TextBox();
            this.txtEvaluacion3 = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lvRegistro = new System.Windows.Forms.ListView();
            this.lblEvaluacion4 = new System.Windows.Forms.Label();
            this.txtEvaluacion4 = new System.Windows.Forms.TextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbEvaluaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(64, 41);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(501, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CONTROL DE REGISTRO DE EVALUACIONES";
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumno.Location = new System.Drawing.Point(12, 127);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(63, 16);
            this.lblAlumno.TabIndex = 1;
            this.lblAlumno.Text = "Alumno:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 146);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // gbEvaluaciones
            // 
            this.gbEvaluaciones.Controls.Add(this.txtEvaluacion4);
            this.gbEvaluaciones.Controls.Add(this.lblEvaluacion4);
            this.gbEvaluaciones.Controls.Add(this.txtEvaluacion3);
            this.gbEvaluaciones.Controls.Add(this.txtEvaluacion2);
            this.gbEvaluaciones.Controls.Add(this.txtEvaluacion1);
            this.gbEvaluaciones.Controls.Add(this.lblEvaluacion3);
            this.gbEvaluaciones.Controls.Add(this.lblEvaluacion2);
            this.gbEvaluaciones.Controls.Add(this.lblEvaluacion1);
            this.gbEvaluaciones.Location = new System.Drawing.Point(239, 102);
            this.gbEvaluaciones.Name = "gbEvaluaciones";
            this.gbEvaluaciones.Size = new System.Drawing.Size(350, 100);
            this.gbEvaluaciones.TabIndex = 3;
            this.gbEvaluaciones.TabStop = false;
            this.gbEvaluaciones.Text = "Evaluaciones";
            // 
            // lblEvaluacion1
            // 
            this.lblEvaluacion1.AutoSize = true;
            this.lblEvaluacion1.Location = new System.Drawing.Point(18, 33);
            this.lblEvaluacion1.Name = "lblEvaluacion1";
            this.lblEvaluacion1.Size = new System.Drawing.Size(40, 13);
            this.lblEvaluacion1.TabIndex = 0;
            this.lblEvaluacion1.Text = "Eval. 1";
            // 
            // lblEvaluacion2
            // 
            this.lblEvaluacion2.AutoSize = true;
            this.lblEvaluacion2.Location = new System.Drawing.Point(99, 32);
            this.lblEvaluacion2.Name = "lblEvaluacion2";
            this.lblEvaluacion2.Size = new System.Drawing.Size(34, 13);
            this.lblEvaluacion2.TabIndex = 1;
            this.lblEvaluacion2.Text = "Evl. 2";
            // 
            // lblEvaluacion3
            // 
            this.lblEvaluacion3.AutoSize = true;
            this.lblEvaluacion3.Location = new System.Drawing.Point(180, 32);
            this.lblEvaluacion3.Name = "lblEvaluacion3";
            this.lblEvaluacion3.Size = new System.Drawing.Size(40, 13);
            this.lblEvaluacion3.TabIndex = 2;
            this.lblEvaluacion3.Text = "Eval. 3";
            // 
            // txtEvaluacion1
            // 
            this.txtEvaluacion1.Location = new System.Drawing.Point(21, 49);
            this.txtEvaluacion1.Name = "txtEvaluacion1";
            this.txtEvaluacion1.Size = new System.Drawing.Size(75, 20);
            this.txtEvaluacion1.TabIndex = 3;
            // 
            // txtEvaluacion2
            // 
            this.txtEvaluacion2.Location = new System.Drawing.Point(102, 49);
            this.txtEvaluacion2.Name = "txtEvaluacion2";
            this.txtEvaluacion2.Size = new System.Drawing.Size(75, 20);
            this.txtEvaluacion2.TabIndex = 4;
            // 
            // txtEvaluacion3
            // 
            this.txtEvaluacion3.Location = new System.Drawing.Point(183, 49);
            this.txtEvaluacion3.Name = "txtEvaluacion3";
            this.txtEvaluacion3.Size = new System.Drawing.Size(75, 20);
            this.txtEvaluacion3.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.ForeColor = System.Drawing.Color.Green;
            this.btnRegistrar.Location = new System.Drawing.Point(12, 172);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 30);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.Blue;
            this.btnCancelar.Location = new System.Drawing.Point(118, 172);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(12, 394);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 30);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lvRegistro
            // 
            this.lvRegistro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvRegistro.GridLines = true;
            this.lvRegistro.HideSelection = false;
            this.lvRegistro.Location = new System.Drawing.Point(12, 208);
            this.lvRegistro.Name = "lvRegistro";
            this.lvRegistro.Size = new System.Drawing.Size(602, 180);
            this.lvRegistro.TabIndex = 7;
            this.lvRegistro.UseCompatibleStateImageBehavior = false;
            this.lvRegistro.View = System.Windows.Forms.View.Details;
            // 
            // lblEvaluacion4
            // 
            this.lblEvaluacion4.AutoSize = true;
            this.lblEvaluacion4.Location = new System.Drawing.Point(261, 32);
            this.lblEvaluacion4.Name = "lblEvaluacion4";
            this.lblEvaluacion4.Size = new System.Drawing.Size(40, 13);
            this.lblEvaluacion4.TabIndex = 6;
            this.lblEvaluacion4.Text = "Eval. 4";
            // 
            // txtEvaluacion4
            // 
            this.txtEvaluacion4.Location = new System.Drawing.Point(264, 49);
            this.txtEvaluacion4.Name = "txtEvaluacion4";
            this.txtEvaluacion4.Size = new System.Drawing.Size(75, 20);
            this.txtEvaluacion4.TabIndex = 7;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Alumno";
            this.columnHeader1.Width = 179;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "E1";
            this.columnHeader2.Width = 48;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "E2";
            this.columnHeader3.Width = 44;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "E3";
            this.columnHeader4.Width = 44;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "E4";
            this.columnHeader5.Width = 49;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Menor";
            this.columnHeader6.Width = 70;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Promedio";
            this.columnHeader7.Width = 69;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Condicion";
            this.columnHeader8.Width = 95;
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // ExploradorDeSoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 436);
            this.Controls.Add(this.lvRegistro);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.gbEvaluaciones);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ExploradorDeSoluciones";
            this.Text = "Control de Registro de Evaluaciones";
            this.gbEvaluaciones.ResumeLayout(false);
            this.gbEvaluaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox gbEvaluaciones;
        private System.Windows.Forms.TextBox txtEvaluacion4;
        private System.Windows.Forms.Label lblEvaluacion4;
        private System.Windows.Forms.TextBox txtEvaluacion3;
        private System.Windows.Forms.TextBox txtEvaluacion2;
        private System.Windows.Forms.TextBox txtEvaluacion1;
        private System.Windows.Forms.Label lblEvaluacion3;
        private System.Windows.Forms.Label lblEvaluacion2;
        private System.Windows.Forms.Label lblEvaluacion1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListView lvRegistro;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ErrorProvider epError;
    }
}

