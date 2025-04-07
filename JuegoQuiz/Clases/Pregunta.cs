using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JuegoQuiz.Clases
{
    public abstract class Pregunta
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

        [JsonIgnore]
        public int Cantidad { get; set; } = 15;


        public Pregunta(string dificultad)
        {
          Dificultad = dificultad;
          Categoria = new Category(dificultad);
        }

        public abstract List<Pregunta>  GetPreguntas();

    }
}
