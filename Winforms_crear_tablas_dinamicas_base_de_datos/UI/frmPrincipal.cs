using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Winforms_crear_tablas_dinamicas_base_de_datos.Controles;
using Winforms_crear_tablas_dinamicas_base_de_datos.DB;

namespace Winforms_crear_tablas_dinamicas_base_de_datos.UI
{
    public partial class frmPrincipal : Form
    {

        clsMetodosDB db = new clsMetodosDB();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void opcion_crearTabla_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectTab(0);
        }

        private void opcion_eliminarTabla_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectTab(1);
        }

        private void opcion_añadirCampo_Click(object sender, EventArgs e)
        {

        }

        private void opcioneliminarCampo_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (db.crearTabla(txtNombreTabla.Text,
                controlColumna1.Nombre + " " + controlColumna1.tipoDato,
                controlColumna2.Nombre + " " + controlColumna2.tipoDato,
                controlColumna3.Nombre+ " "+ controlColumna3.tipoDato))
            {
                MessageBox.Show("La tabla fue creada correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                llenarListado(cboListaTablas);
            }
            else
                MessageBox.Show("Ocurrio un error", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEliminarTabla_Click(object sender, EventArgs e)
        {
            if (cboListaTablas.SelectedIndex!=-1)
            {
                if (MessageBox.Show("¿Seguro que desea eliminar la tabla?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.eliminarTabla(cboListaTablas.Text);
                    MessageBox.Show("Tabla eliminada correctamente");
                    llenarListado(cboListaTablas);
                    cboListaTablas.Text = "";
                }
            }
            else MessageBox.Show("Seleccione una tabla");
        }
        List<clsInformacionTablas> listaNombreTabla = new List<clsInformacionTablas>();

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            llenarListado(cboListaTablas);
        }

        void llenarListado(ComboBox cbo)
        {
            cbo.Items.Clear();
            listaNombreTabla = db.listadoTablas();
            listaNombreTabla.ForEach(t => cboListaTablas.Items.Add(t.Nombre));
        }

        private void btnLimpiarCamposColumna_Click(object sender, EventArgs e)
        {
            txtNombreTabla.ResetText();
            controlColumna1.reset();
            controlColumna2.reset();
            controlColumna3.reset();
            txtNombreTabla.Focus();
        }
    }
}
