#region Forms
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
    
    public partial class frmRegistro : Form
    {
        #region Inisializar frmRegistro
        public frmRegistro()
        {
            InitializeComponent();
        }

        #endregion

        #region Boton Registrar Click
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Capturando los Valores
            int Numero = int.Parse(txtNumero.Text);
            DateTime Fecha = dtpFecha.Value;
            string Empresa = txtEmpresa.Text;

            //Calculando los Años de Emision
            int Años = DateTime.Today.Date.Year - Fecha.Year;

            //Determinando la Condicion
            string Condicion = "";
            if (Años <= 5) Condicion = "Habilitado";
            if (Años > 5) Condicion = "Inhabilitado";

            //Imprimiendo los Resultados
            ListViewItem Fila = new ListViewItem(Numero.ToString());
            Fila.SubItems.Add(Fecha.ToString("d"));
            Fila.SubItems.Add(Empresa);
            Fila.SubItems.Add(Años.ToString());
            Fila.SubItems.Add(Condicion);
            lvRegistro.Items.Add(Fila);

            //Limpiando los Controles
            btnCancelar_Click(sender, e);
        }
        #endregion

        #region Boton Cancelar Click
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            dtpFecha.Value = DateTime.Today.Date;
            txtEmpresa.Clear();
            txtNumero.Focus();
        }

        #endregion

        #region Boton Salir Click
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de salir?", "Documentos",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes) this.Close();
        }
        #endregion
    }
    
}
#endregion
#endregion