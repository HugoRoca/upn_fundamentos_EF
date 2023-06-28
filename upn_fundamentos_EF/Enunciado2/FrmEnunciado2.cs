using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace upn_fundamentos_EF.Enunciado2
{
    public partial class FrmEnunciado2 : Form
    {
        private BLJuego blJuego = new BLJuego();

        public FrmEnunciado2()
        {
            InitializeComponent();
        }

        private void FrmEnunciado2_Load(object sender, EventArgs e)
        {
            blJuego.LoadGameData();
            lblTotal.Text = blJuego.ObtenerPuntos().ToString();

            CargarGridView();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtJuego.Text))
            {
                MessageBox.Show("Debe ingresar nombre del juego!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJuego.Focus();
                return;
            }

            int puntos = rbVictoria.Checked ? 100 : -20;

            blJuego.GuardarJuego(new JuegoModel(
                txtJuego.Text,
                puntos,
                rbVictoria.Checked)
                );

            blJuego.AsignarPuntos(puntos);
            lblTotal.Text = blJuego.ObtenerPuntos().ToString();

            dgvLista.Rows.Add(txtJuego.Text.ToUpper(), puntos, rbVictoria.Checked ? "Ganado" : "Perdido");

            txtJuego.Clear();
            txtJuego.Focus();
            rbVictoria.Checked = true;
        }

        private void CargarGridView()
        {
            List<JuegoModel> juegos = blJuego.ObtenerJuegos();

            if (!juegos.Any()) return;

            foreach (var item in juegos)
            {
                dgvLista.Rows.Add(item.Nombre.ToUpper(), item.Puntaje, item.VictoriaTexto);
            }
        }
    }
}
