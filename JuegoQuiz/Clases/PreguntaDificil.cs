using JuegoQuiz.Enums;
using System.Collections.Generic;

namespace JuegoQuiz.Clases
{
    internal class PreguntaDificil : Pregunta
    {
        public PreguntaDificil(string enunciado, string respuestaCorrecta, List<string> opciones, Categoria categoria)
             : base(enunciado, respuestaCorrecta, opciones, Dificultad.Dificil, categoria, Puntaje.Dificil)
        {
        }
    }
}
