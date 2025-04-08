using JuegoQuiz.Constantes;
using System.Collections.Generic;

namespace JuegoQuiz.Clases
{
    internal class PreguntaMedia : Pregunta
    {
        public PreguntaMedia(string enunciado, string respuestaCorrecta, List<string> opciones, string categoria)
            : base(enunciado, respuestaCorrecta, opciones, EnumDificultad.Media, categoria, EnumPuntaje.Media)
        {
        }
    }
}

