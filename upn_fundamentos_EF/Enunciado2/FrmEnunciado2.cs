using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace upn_fundamentos_EF.Enunciado2
{
    public partial class FrmEnunciado2 : Form
    {
        private BLJuego f_blJuego = new BLJuego();

        public FrmEnunciado2()
        {
            InitializeComponent();
        }

        private void FrmEnunciado2_Load(object sender, EventArgs e)
        {
            try
            {
                f_blJuego.CargarDatos();
                lblTotal.Text = f_blJuego.ObtenerPuntos().ToString();

                CargarGridView();
            }
            catch (Exception)
            {
                MessageBox.Show("Ha sucedido un error, intente de nuevo!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtJuego.Text))
                {
                    MessageBox.Show("Debe ingresar nombre del juego!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtJuego.Focus();
                    return;
                }

                int f_puntos = rbVictoria.Checked ? 100 : -20;

                f_blJuego.GuardarJuego(new JuegoModel(
                    txtJuego.Text,
                    f_puntos,
                    rbVictoria.Checked)
                    );

                f_blJuego.AsignarPuntos(f_puntos);
                lblTotal.Text = f_blJuego.ObtenerPuntos().ToString();

                dgvLista.Rows.Add(txtJuego.Text.ToUpper(), f_puntos, rbVictoria.Checked ? "Ganado" : "Perdido");

                txtJuego.Clear();
                txtJuego.Focus();
                rbVictoria.Checked = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ha sucedido un error, intente de nuevo!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarGridView()
        {
            List<JuegoModel> f_juegos = f_blJuego.ObtenerJuegos();

            if (!f_juegos.Any()) return;

            foreach (var f_item in f_juegos)
            {
                dgvLista.Rows.Add(f_item.f_Nombre.ToUpper(), f_item.f_Puntaje, f_item.f_VictoriaTexto);
            }
        }
    }
}
