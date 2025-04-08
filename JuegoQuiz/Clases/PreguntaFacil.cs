using JuegoQuiz.Constantes;
using System.Collections.Generic;

namespace JuegoQuiz.Clases
{
    internal class PreguntaFacil : Pregunta
    {
        public PreguntaFacil(string enunciado, string respuestaCorrecta, List<string> opciones, string categoria)
           : base(enunciado, respuestaCorrecta, opciones, EnumDificultad.Facil, categoria, EnumPuntaje.Facil)
        {
        }
    }
}
