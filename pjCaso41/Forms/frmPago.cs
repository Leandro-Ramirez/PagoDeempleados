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

namespace Forms
{
    public partial class frmPago : Form
    {
        double Sueldo;

        #region Inisializar frmPago
        public frmPago()
        {
            InitializeComponent();
        }
        #endregion

        #region Cargar frmpago
        private void frmPago_Load(object sender, EventArgs e)
        {
            dtpFecha.Text = DateTime.Today.Date.ToString("d");
        }
        #endregion

        #region Boton Registrar Click
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Capturando los Valores
            string Nombre = txtNombre.Text;
            string Categoria = cmbCategoria.Text;

            //Realizando Calculos
            double Descuento = 0;
            if (Sueldo > 2000) Descuento = Sueldo * (12.5/100);

            double Neto = Sueldo - Descuento;

            //Imprimiendo los Resultados en la Lista
            ListViewItem fila = new ListViewItem(Nombre);
            fila.SubItems.Add(Categoria);
            fila.SubItems.Add(Sueldo.ToString("C"));
            fila.SubItems.Add(Descuento.ToString("C"));
            fila.SubItems.Add(Neto.ToString("C"));
            lvPago.Items.Add(fila);

            //Limpiando los Controles
            btnCancelar_Click(sender, e);
        }
        #endregion

        #region Combo Box Categoria, Seleccionar
        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Capturando la Categoria Seleccionada
            string Categoria = cmbCategoria.Text;

            //Asignando el Sueldo Segun la Categoria
            if (Categoria == "Jefe") Sueldo = 3500;
            if (Categoria == "Administrativo") Sueldo = 2500;
            if (Categoria == "Tecnico") Sueldo = 1700;
            if (Categoria == "Operario") Sueldo = 1000;

            //Enviando el Sueldo Obtenido a la Impresion
            txtSueldo.Text = Sueldo.ToString("C");
        }

        #endregion

        #region Boton Cancelar Click
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cmbCategoria.Text = "(Seleccione)";
            txtNombre.Clear();
            txtNombre.Focus();
        }
        #endregion

        #region Boton Salir Click
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de salir?","Pago",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes) this.Close();
        }
        #endregion
    }
}
