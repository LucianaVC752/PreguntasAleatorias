using JuegoQuiz.Clases;
using JuegoQuiz.Constantes;
using JuegoQuiz.Factory;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace JuegoQuiz
{
    public partial class Form1 : Form
    {
        private Partida partida;
        private int tiempoRestante;
        Pregunta preguntaGenerada;

        public Form1()
        {
            InitializeComponent();
            btnSiguiente.Visible = false;
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategoria.SelectedItem == null || cmbDificultad.SelectedItem == null)
                {
                    MessageBox.Show("Debes seleccionar una categoría y dificultad antes de comenzar.");
                    return;
                }
                string dificultad = cmbDificultad.SelectedItem.ToString();
                partida = new Partida(dificultad);

                ActualizarPuntajeEnVista();
                ObtenerSiguientePregunta();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error" + ex);
            }
        }

        private void ObtenerSiguientePregunta() {
            if (partida.ObtenerTotalPreguntas() >= EnumConstantes.MAX_PREGUNTAS)
            {
                timerPregunta.Stop();
                MostrarResultadoFinal();
                return;
            }

            string categoria = cmbCategoria.SelectedItem.ToString();
            string dificultad = cmbDificultad.SelectedItem.ToString();

            preguntaGenerada = PreguntasFactory.CrearPregunta(categoria, dificultad);
            partida.AgregarPregunta(preguntaGenerada);

            lblPregunta.Text = preguntaGenerada.Enunciado;
            var respuestas = preguntaGenerada.Opciones.ToList();
            respuestas = respuestas.OrderBy(_ => Guid.NewGuid()).ToList();

            rdbRespuesta1.Text = respuestas[0];
            rdbRespuesta2.Text = respuestas[1];
            rdbRespuesta3.Text = respuestas[2];
            rdbRespuesta4.Text = respuestas[3];

            HabilitarOpciones(true);
            btnSiguiente.Visible = false;

            tiempoRestante = partida.ObtenerTiempoPorPregunta();
            lblTiempo.Text = $"Tiempo: {tiempoRestante}s";
            timerPregunta.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerPregunta.Interval = 1000;
            timerPregunta.Tick -= timerPregunta_Tick;
            timerPregunta.Tick += timerPregunta_Tick;

            #region
            cmbCategoria.Items.Add(EnumCategoria.Ciencia);
            cmbCategoria.Items.Add(EnumCategoria.Historia);
            cmbCategoria.Items.Add(EnumCategoria.CulturaGeneral);
            cmbCategoria.SelectedIndex = -1;

            cmbDificultad.Items.Add(EnumDificultad.Facil);
            cmbDificultad.Items.Add(EnumDificultad.Media);
            cmbDificultad.Items.Add(EnumDificultad.Dificil);
            cmbDificultad.SelectedIndex = -1;
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
            bool esCorrecta = respuestaSeleccionada == preguntaGenerada.RespuestaCorrecta;

            if (esCorrecta)
            {
                partida.AcertarPregunta(preguntaGenerada);
                MessageBox.Show("¡Correcto!");
            }
            else
            {
                partida.FallarPregunta();
                MessageBox.Show($"Incorrecto. La correcta era: {preguntaGenerada.RespuestaCorrecta}");
            }

            ActualizarPuntajeEnVista();
            btnSiguiente.Visible = true;
            HabilitarOpciones(false);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            ObtenerSiguientePregunta();
        }

        private void HabilitarOpciones(bool estado)
        {
            rdbRespuesta1.Enabled = estado;
            rdbRespuesta2.Enabled = estado;
            rdbRespuesta3.Enabled = estado;
            rdbRespuesta4.Enabled = estado;
        }

        private void ActualizarPuntajeEnVista()
        {
            lblPuntaje.Text = $"Puntaje: {partida.ObtenerPuntaje()}";
        }

        private void MostrarResultadoFinal()
        {
            var formFinal = new FormResultadoFinal(partida.ObtenerPuntaje());
            formFinal.Show();
            Hide();
        }

        private void rdbRespuesta1_Click(object sender, EventArgs e)
        {
            var btn = sender as RadioButton;
            timerPregunta.Stop();
            EvaluarRespuesta(btn.Text);
        }
    }
}
