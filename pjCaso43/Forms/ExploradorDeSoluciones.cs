#region Usos
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

#region Namespace
namespace Forms
{
    public partial class ExploradorDeSoluciones : Form
    {
        #region Inisializar ExploradorDeSoluciones
        public ExploradorDeSoluciones()
        {
            InitializeComponent();
        }
        #endregion

        #region Boton Registrar Click
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Capturando los Valores
            string Nombre = txtNombre.Text;
            int E1 = int.Parse(txtEvaluacion1.Text);
            int E2 = int.Parse(txtEvaluacion2.Text);
            int E3 = int.Parse(txtEvaluacion3.Text);
            int E4 = int.Parse(txtEvaluacion4.Text);

            //Determinar la Menor
            int Menor;
            if (E1 < E2) Menor = E1; else Menor = E2;
            if (E3 < Menor) Menor = E3;
            if (E4 < Menor) Menor = E4;

            //Calculando el Promedio
            double Promedio = (E1 + E2 + E3 + E4 - Menor) / 3;

            //Determinando la Condicion
            string Condicion;
            if (Promedio <= 12.49)
                Condicion = "DESAPROBADO";
            else
                Condicion = "APROBADO";

            //Imprimiendo los Resultados
            ListViewItem Fila = new ListViewItem(Nombre);
            Fila.SubItems.Add(E1.ToString());
            Fila.SubItems.Add(E2.ToString());
            Fila.SubItems.Add(E3.ToString());
            Fila.SubItems.Add(E4.ToString());
            Fila.SubItems.Add(Menor.ToString());
            Fila.SubItems.Add(Promedio.ToString());
            Fila.SubItems.Add(Condicion);
            lvRegistro.Items.Add(Fila);

            //Limpiando los Controles
            btnCancelar_Click(sender, e);
        }
        #endregion

        #region Validando Nombre 1
        private void txtAlumno_Validated(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            { 
                epError.SetError(txtNombre, "Ingrese Nombre del Alumno...!!!");
                txtNombre.Focus();
            }
            else 
            {
                epError.Clear();
            }
        }
        #endregion

        #region Validando Evaluacion 1
        private void txtEvaluacion1_Validated(object sender, EventArgs e)
        { 
            if (txtEvaluacion1.Text.Trim() == "")
            {
                epError.SetError(txtEvaluacion1, "Ingrese la Evaluacion 1 ...!");
                txtEvaluacion1.Focus();
            }
            else
            {
                epError.Clear();
            }
        }
        #endregion

        #region Validando Evaluacion 2
        private void txtEvaluacion2_Validated(object sender, EventArgs e)
        {
            if (txtEvaluacion2.Text.Trim() == "")
            {
                epError.SetError(txtEvaluacion2, "Ingrese la Evaluacion 2 ...!");
                txtEvaluacion2.Focus();
            }
            else
            {
                epError.Clear();
            }
        }
        #endregion

        #region Validando Evaluacion 3
        private void txtEvaluacion3_Validated(object sender, EventArgs e)
        {
            if (txtEvaluacion3.Text.Trim() == "")
            {
                epError.SetError(txtEvaluacion3, "Ingrese Evaluacion 3 ...!");
                txtEvaluacion3.Focus();
            }
            else
            {
                epError.Clear();
            }
        }
        #endregion

        #region Validando Evaluacion 4
        private void txtEvaluacion4_Click(object sender, EventArgs e)
        {
            if (txtEvaluacion4.Text.Trim() == "")
            {
                epError.SetError(txtEvaluacion4, "Ingrese Evaluacion 4 ...!");
                txtEvaluacion4.Focus();
            }
            else
            {
                epError.Clear();
            }
        }
        #endregion

        #region Boton Cancelar Click
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtEvaluacion1.Clear();
            txtEvaluacion2.Clear();
            txtEvaluacion3.Clear();
            txtEvaluacion4.Clear();
            txtNombre.Focus();
        }

        #endregion

        #region Boton Salir Click
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta Seguro de Salir?", "Promedio",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes) this.Close();
        }
        #endregion
    }
}
#endregion