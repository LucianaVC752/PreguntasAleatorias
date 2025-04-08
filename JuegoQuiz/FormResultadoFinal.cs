using System;
using System.Windows.Forms;

namespace JuegoQuiz
{
    public partial class FormResultadoFinal : Form
    {
        public FormResultadoFinal(int puntaje)
        {
            InitializeComponent();
            lblPuntaje.Text = $"Tu puntaje final fue: {puntaje}";
        }
        
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 Inicio = new Form1();
            Inicio.Show();
            Hide();
        }
    }
}
