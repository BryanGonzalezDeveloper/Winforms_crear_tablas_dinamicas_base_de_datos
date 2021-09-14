using System.Windows.Forms;

namespace Winforms_crear_tablas_dinamicas_base_de_datos.Controles
{
    public partial class controlEliminarCampo : UserControl
    {
        public controlEliminarCampo()
        {
            InitializeComponent();
        }
        public string tabla { get; set; }
        public string campo { get { return txtNombreCampo.Text; } set { } }
        public bool Eliminar { get { return cbEliminar.Checked; } set { } }
        public void setNombreCampo(string txt)
        {
            txtNombreCampo.Text = txt;
        }
       
        
       
    }
}
