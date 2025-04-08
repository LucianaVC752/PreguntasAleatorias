using JuegoQuiz.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace JuegoQuiz
{
    public partial class Form1 : Form
    {

        //private Nivel nivelActual;
        private List<Pregunta> preguntasActuales;
        private int preguntaActualIndex = 0;
        private int puntaje = 0;
        private int tiempoRestante;
        private Pregunta preguntaActual;
        public Form1()
        {
            InitializeComponent();
            btnSiguiente.Visible = false;
            timerPregunta.Interval = 1000;
            timerPregunta.Tick += timerPregunta_Tick;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dificultad, categoria;
            try
            {
                if (cmbCategoria.SelectedItem == null || cmbDificultad.SelectedItem == null)
                {
                    MessageBox.Show("Debes seleccionar una categoría y dificultad antes de comenzar.");
                    return;
                }
                categoria = cmbCategoria.SelectedItem.ToString();
                dificultad = cmbDificultad.SelectedItem.ToString();

                var preguntaFactory = FactoryPreguntas.CrearPreguntas(dificultad, categoria);
                preguntasActuales = preguntaFactory.GetPreguntas();

                puntaje = 0;
                preguntaActualIndex = 0;

                MostrarPregunta();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error" + ex);
            }
        }

        private void MostrarPregunta() {
            if (preguntaActualIndex >= preguntasActuales.Count)
            {
                timerPregunta.Stop();
                MostrarResultadoFinal();
                return;
            }

            preguntaActual = preguntasActuales[preguntaActualIndex];

            lblPregunta.Text = preguntaActual.PreguntaT;
            var respuestas = preguntaActual.RespuestasIncorrectas.ToList();
            respuestas.Add(preguntaActual.RespuestaCorrecta);
            respuestas = respuestas.OrderBy(_ => Guid.NewGuid()).ToList();

            rdbRespuesta1.Text = respuestas[0];
            rdbRespuesta2.Text = respuestas[1];
            rdbRespuesta3.Text = respuestas[2];
            rdbRespuesta4.Text = respuestas[3];

            HabilitarBotones(true);
            btnSiguiente.Visible = false;

            tiempoRestante = preguntaActual.Categoria.Tiempo;
            lblTiempo.Text = $"Tiempo: {tiempoRestante}s";
            timerPregunta.Start();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region
            cmbCategoria.Items.Add("Historia");
            cmbCategoria.Items.Add("Ciencia");
            cmbCategoria.Items.Add("Cultura General");
            cmbCategoria.SelectedIndex = 0;

            cmbDificultad.Items.Add("facil");
            cmbDificultad.Items.Add("medio");
            cmbDificultad.Items.Add("dificil");
            cmbDificultad.SelectedIndex = 0;
            #endregion
        }

        private void timerPregunta_Tick(object sender, EventArgs e)
        {
            tiempoRestante--;
            lblTiempo.Text = $"Tiempo: {tiempoRestante}s";

            if (tiempoRestante <= 0)
            {
                timerPregunta.Stop();
                EvaluarRespuesta(null); // tiempo agotado
            }
        }

        private void EvaluarRespuesta(string respuestaSeleccionada)
        {
            bool esCorrecta = respuestaSeleccionada == preguntaActual.RespuestaCorrecta;

            if (esCorrecta)
            {
                puntaje += preguntaActual.Categoria.ValorPregunta;
                MessageBox.Show("¡Correcto!");
            }
            else
            {
                puntaje = Math.Max(0, puntaje - 2);
                MessageBox.Show($"Incorrecto. La correcta era: {preguntaActual.RespuestaCorrecta}");
            }

            lblPuntaje.Text = $"Puntaje: {puntaje}";
            btnSiguiente.Visible = true;
            HabilitarBotones(false);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            preguntaActualIndex++;
            MostrarPregunta();
        }

        private void HabilitarBotones(bool estado)
        {
            rdbRespuesta1.Enabled = estado;
            rdbRespuesta2.Enabled = estado;
            rdbRespuesta3.Enabled = estado;
            rdbRespuesta4.Enabled = estado;
        }

        private void MostrarResultadoFinal()
        {
            var formFinal = new FormResultadoFinal(puntaje);
            formFinal.Show();
            this.Hide();
        }

        private void rdbRespuesta1_Click(object sender, EventArgs e)
        {
            var btn = sender as RadioButton;
            timerPregunta.Stop();
            EvaluarRespuesta(btn.Text);
        }
    }
}
