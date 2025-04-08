using JuegoQuiz.Constantes;
using System.Collections.Generic;

namespace JuegoQuiz.Clases
{
    internal class PreguntaDificil : Pregunta
    {
        public PreguntaDificil(string enunciado, string respuestaCorrecta, List<string> opciones, string categoria)
             : base(enunciado, respuestaCorrecta, opciones, EnumDificultad.Dificil, categoria, EnumPuntaje.Dificil)
        {
        }
    }
}
