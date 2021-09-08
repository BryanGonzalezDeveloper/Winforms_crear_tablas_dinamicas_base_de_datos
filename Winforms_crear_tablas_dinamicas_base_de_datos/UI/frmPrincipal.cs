using System;
using System.Windows.Forms;
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

        }

        private void opcion_eliminarTabla_Click(object sender, EventArgs e)
        {

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
                controlColumna1.Columna + " " + controlColumna1.tipoDato,
                controlColumna2.Columna + " " + controlColumna2.tipoDato,
                controlColumna3.Columna+ " "+ controlColumna3.tipoDato))
            {
                MessageBox.Show("La tabla fue creada correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Ocurrio un error", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
