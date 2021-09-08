using System.Windows.Forms;

namespace Winforms_crear_tablas_dinamicas_base_de_datos.Controles
{
    public partial class controlColumna : UserControl
    {
        public controlColumna()
        {
            InitializeComponent();
        }
        public void reset()
        {
            cboDatatype.SelectedIndex = 0;
            txtNombreColumna.Text = null;
        }
        public string Nombre
        {
            get
            {
                return txtNombreColumna.Text;
            }
            set
            {
                value = txtNombreColumna.Text;
            }
        }
        public string tipoDato
        {
            get
            {
                return cboDatatype.Text;
            }
            set
            {
                value = cboDatatype.Text;
            }
        }
    }
}
