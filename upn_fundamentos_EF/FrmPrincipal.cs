using System.Windows.Forms;
using upn_fundamentos_EF.Enunciado1;
using upn_fundamentos_EF.Enunciado2;

namespace upn_fundamentos_EF
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnEnunciado1_Click(object sender, System.EventArgs e)
        {
            FrmEnunciado1 f_frmEnunciado1 = new FrmEnunciado1();
            f_frmEnunciado1.Show();
        }

        private void btnEnunciado2_Click(object sender, System.EventArgs e)
        {
            FrmEnunciado2 f_frmEnunciado2 = new FrmEnunciado2();
            f_frmEnunciado2.Show();
        }
    }
}
