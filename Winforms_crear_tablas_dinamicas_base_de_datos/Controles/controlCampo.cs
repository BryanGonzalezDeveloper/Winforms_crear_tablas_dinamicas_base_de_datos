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
        public string TipoDato
        {
            get
            {
                return cboTipoDato.Text;
            }
            set { }
        }

        public int indiceInicial { get; set; }
        public int indiceFinal { get; set; }


        public void setTipoDato(string nombreTipoDato)
        {
            for (int i = 0; i < cboTipoDato.Items.Count; i++)
            {
                if(cboTipoDato.Items[i].ToString().StartsWith(nombreTipoDato))
                {
                    cboTipoDato.SelectedIndex = i;
                    indiceInicial = i;
                }
            }
        }

        public void setIndiceFinal()
        {
            indiceFinal = cboTipoDato.SelectedIndex;
        }

        public bool fueModificado()
        {
            if (indiceInicial == indiceFinal)
                return false;
            else
                return true;
        }

        private void cboTipoDato_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cboTipoDato.SelectedIndex != -1)
                setIndiceFinal();
        }
    }
}
