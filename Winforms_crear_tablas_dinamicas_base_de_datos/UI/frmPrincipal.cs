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
            cboTablas.Items.Clear();
            var lista = db.listadoTablas();
            lista.ForEach(t => cboTablas.Items.Add(t.Nombre));
            materialTabControl1.SelectTab(2);
        }

        private void opcioneliminarCampo_Click(object sender, EventArgs e)
        {
            cboEliminarCampo.Items.Clear();
            var lista = db.listadoTablas();
            lista.ForEach(t => cboEliminarCampo.Items.Add(t.Nombre));
            materialTabControl1.SelectTab(3);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (db.crearTabla(txtNombreTabla.Text,
                controlColumna1.Nombre + " " + controlColumna1.tipoDato,
                controlColumna2.Nombre + " " + controlColumna2.tipoDato,
                controlColumna3.Nombre + " " + controlColumna3.tipoDato))
            {
                MessageBox.Show("La tabla fue creada correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                llenarListado(cboListaTablas);
            }
            else
                MessageBox.Show("Ocurrio un error", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEliminarTabla_Click(object sender, EventArgs e)
        {
            if (cboListaTablas.SelectedIndex != -1)
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

        private void cboTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTablas.SelectedIndex != -1)
            {
                mostrarCampos();
            }
        }

        private void btnModificarCampos_Click(object sender, EventArgs e)
        {
            foreach (var campo in flowLayoutPanel1.Controls)
            {
                if (campo is controlCampo)
                {
                    controlCampo col = (controlCampo)campo;
                    if (col.fueModificado())
                    {
                        db.modificarCampos(cboTablas.Text, col.Nombre, col.TipoDato);
                    }
                }
            }
            mostrarCampos();
        }

        void mostrarCampos()
        {
            flowLayoutPanel1.Controls.Clear();
            var lista = db.listadoCampos(cboTablas.Text);
            List<controlCampo> listaControles = new List<controlCampo>(lista.Count);
            for (int i = 0; i < lista.Count; i++)
            {
                listaControles.Add(new controlCampo { Nombre = lista[i].NombreCampo });
                listaControles[i].setTipoDato(lista[i].TipoDato);
                flowLayoutPanel1.Controls.Add(listaControles[i]);
            }
        }

        private void cboEliminarCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboEliminarCampo.SelectedIndex!=-1)
            {
                mostrarCamposTablas();
            }
        }

        private void btnEliminarCampos_Click(object sender, EventArgs e)
        {
            foreach (var campo in flowLayoutPanel2.Controls)
            {
                if(campo is controlEliminarCampo)
                {
                   controlEliminarCampo ctrl = (controlEliminarCampo)campo;
                    if(ctrl.Eliminar)
                    {
                        db.eliminarCampo(cboEliminarCampo.Text, ctrl.campo);
                    }
                }
            }
            mostrarCamposTablas();
        }
        void mostrarCamposTablas()
        {
            flowLayoutPanel2.Controls.Clear();
            var lista = db.listadoCampos(cboEliminarCampo.Text);
            List<controlEliminarCampo> listaControles = new List<controlEliminarCampo>(lista.Count);
            for (int i = 0; i < lista.Count; i++)
            {
                listaControles.Add(new controlEliminarCampo { campo = lista[i].NombreCampo });
                listaControles[i].setNombreCampo(lista[i].NombreCampo);
                flowLayoutPanel2.Controls.Add(listaControles[i]);
            }
        }
    }
}
