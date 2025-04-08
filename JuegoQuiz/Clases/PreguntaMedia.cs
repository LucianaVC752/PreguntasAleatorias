using JuegoQuiz.Enums;
using System.Collections.Generic;

namespace JuegoQuiz.Clases
{
    internal class PreguntaMedia : Pregunta
    {
        public PreguntaMedia(string enunciado, string respuestaCorrecta, List<string> opciones, Categoria categoria)
            : base(enunciado, respuestaCorrecta, opciones, Dificultad.Media, categoria, Puntaje.Media)
        {
        }
    }
}
