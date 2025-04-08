using JuegoQuiz.Enums;
using System.Collections.Generic;

namespace JuegoQuiz.Clases
{
    internal class PreguntaFacil : Pregunta
    {
        public PreguntaFacil(string enunciado, string respuestaCorrecta, List<string> opciones, Categoria categoria)
           : base(enunciado, respuestaCorrecta, opciones, Dificultad.Facil, categoria, Puntaje.Facil)
        {
        }
    }
}
