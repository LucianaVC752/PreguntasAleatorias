using JuegoQuiz.Recursos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaEntrada = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Preguntas", "CulturaGeneral.json");
                string rutaSalida = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Preguntas", "CulturaGeneralTransformada.json");

                TransformadorJson.ConvertirJson(rutaEntrada, rutaSalida);

                MessageBox.Show("Transformación exitosa 🎉\nArchivo guardado como CienciaTransformada.json", "Éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error");
            }
        }
    }
}
