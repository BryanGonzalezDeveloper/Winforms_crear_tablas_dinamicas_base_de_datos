using System.Windows.Forms;

namespace Winforms_crear_tablas_dinamicas_base_de_datos.Controles
{
    public partial class controlCampo : UserControl
    {
        public controlCampo()
        {
            InitializeComponent();
        }

        public string Nombre
        {
            set
            {
                txtNombreCampo.Text = value;
            }
            get
            {
                return txtNombreCampo.Text;
            }
        }
        /*VARCHAR(100)
INT
DECIMAL(8,2)
DATE*/

        public string TipoDato
        {
            get
            {
                return cboTipoDato.Text;
            }
            set { }
        }
        public void setTipoDato(string nombreTipoDato)
        {
            cboTipoDato.SelectedItem = nombreTipoDato;
        }
    }
}
