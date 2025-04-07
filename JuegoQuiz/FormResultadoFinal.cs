using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        

        private void FormResultadoFinal_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 Inicio = new Form1();
            Inicio.Show();
            this.Hide();
        }
    }
}
