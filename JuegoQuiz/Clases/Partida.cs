using JuegoQuiz.Constantes;
using System;
using System.Collections.Generic;

namespace JuegoQuiz.Clases
{
    internal class Partida
    {
        private int _puntaje;
        private int _tiempoPorPregunta;
        private List<Pregunta> _preguntas;

        public Partida(string dificultad)
        {
            if (string.IsNullOrEmpty(dificultad)) throw new ArgumentException("La categoria no puede estar vacía.");
            if (dificultad == EnumDificultad.Facil) _tiempoPorPregunta = EnumTiempo.Facil;
            else if (dificultad == EnumDificultad.Media) _tiempoPorPregunta = EnumTiempo.Media;
            else if (dificultad == EnumDificultad.Dificil) _tiempoPorPregunta = EnumTiempo.Dificil;

            _puntaje = 0;
            _preguntas = new List<Pregunta>();
        }

        public void AcertarPregunta(Pregunta pregrunta)
        {
            _puntaje += pregrunta.Puntaje;
        }
        public void FallarPregunta()
        {
            _puntaje = Math.Max(0, _puntaje - 2);
        }

        public int ObtenerPuntaje()
        {
            return _puntaje;
        }

        public int ObtenerTiempoPorPregunta()
        {
            return _tiempoPorPregunta;
        }

        public int ObtenerTotalPreguntas()
        {
            return _preguntas.Count;
        }

        public void AgregarPregunta(Pregunta pregunta)
        {
            _preguntas.Add(pregunta);
        }
    }
}
