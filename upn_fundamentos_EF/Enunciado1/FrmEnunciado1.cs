using System;
using System.Windows.Forms;

namespace upn_fundamentos_EF.Enunciado1
{
    public partial class FrmEnunciado1 : Form
    {
        private string[] f_array;

        public FrmEnunciado1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtArray.Text))
            {
                MessageBox.Show("Debe ingresar un array!", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            string[] f_inputArray = txtArray.Text.Split(',');

            f_array = new string[f_inputArray.Length];
            Array.Copy(f_inputArray, f_array, f_inputArray.Length);

            MostrarArray(f_array, txtSalida);

            txtArray.Clear();
        }

        private void MostrarArray(string[] f_arr, TextBox f_textBox)
        {
            f_textBox.Text = string.Join(", ", f_arr);
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            OrdenarRecursivo(f_array, 0, f_array.Length - 1);

            MostrarArray(f_array, txtSalida);
        }

        private void OrdenarRecursivo(string[] f_arr, int f_left, int f_right)
        {
            if (f_left < f_right)
            {
                int f_pivotIndex = Pivote(f_arr, f_left, f_right);

                OrdenarRecursivo(f_arr, f_left, f_pivotIndex - 1);
                OrdenarRecursivo(f_arr, f_pivotIndex + 1, f_right);
            }
        }

        private int Pivote(string[] f_arr, int f_left, int f_right)
        {
            string f_pivot = f_arr[f_right];
            int f_i = f_left - 1;

            for (int f_j = f_left; f_j < f_right; f_j++)
            {
                if (string.Compare(f_arr[f_j], f_pivot, StringComparison.Ordinal) <= 0)
                {
                    f_i++;
                    Intercambiar(f_arr, f_i, f_j);
                }
            }

            Intercambiar(f_arr, f_i + 1, f_right);
            return f_i + 1;
        }

        private void Intercambiar(string[] f_arr, int f_i, int f_j)
        {
            string temp = f_arr[f_i];
            f_arr[f_i] = f_arr[f_j];
            f_arr[f_j] = temp;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtArray.Clear();
            txtSalida.Clear();
        }
    }
}
