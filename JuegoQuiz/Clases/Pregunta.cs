using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JuegoQuiz.Clases
{
    public class Pregunta
    {
        [JsonPropertyName("pregunta")]
        public string PreguntaT { get; set; }

        [JsonPropertyName("respuesta_correcta")]
        public string RespuestaCorrecta { get; set; }
        [JsonPropertyName("respuestas_incorrectas")]
        public IList<string> RespuestasIncorrectas { get; set; }

        [JsonPropertyName("dificultad")]
        public string Dificultad { get; set; }

        [JsonPropertyName("categoria")]
        public Category Categoria { get; set; }


        //public Pregunta(string dificultad, string pregunta, string respuesta, IList<string> respuestasIncorrectas)
        //{
        //    Dificultad = dificultad;
        //    PreguntaT = pregunta;
        //    RespuestaCorrecta = respuesta;
        //    RespuestasIncorrectas = respuestasIncorrectas;
        //}

    }
}
