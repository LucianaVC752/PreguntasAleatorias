using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JuegoQuiz.Clases
{
    public class Pregunta
    {
        private string _enunciado;
        private string _respuestaCorrecta;
        private List<string> _opciones;
        private string _dificultad;
        private string _categoria;
        private int _puntaje;

        [JsonPropertyName("pregunta")]
        public string Enunciado
        {
            get => _enunciado;
            set => _enunciado = !string.IsNullOrWhiteSpace(value)
                ? value
                : throw new ArgumentException("El enunciado no puede estar vacío.");
        }

        [JsonPropertyName("respuesta_correcta")]
        public string RespuestaCorrecta
        {
            get => _respuestaCorrecta;
            set => _respuestaCorrecta = !string.IsNullOrWhiteSpace(value)
                ? value
                : throw new ArgumentException("La respuesta correcta no puede estar vacía.");
        }

        [JsonPropertyName("opciones")]
        public List<string> Opciones
        {
            get => _opciones;
            set => _opciones = value != null && value.Count >= 3
                ? value
                : throw new ArgumentException("Debe haber al menos tres opciones.");
        }

        [JsonPropertyName("dificultad")]
        public string Dificultad
        {
            get => _dificultad;
            set => _dificultad = !string.IsNullOrWhiteSpace(value)
                ? value
                : throw new ArgumentException("La dificultad no puede estar vacía.");
        }

        [JsonPropertyName("categoria")]
        public string Categoria
        {
            get => _categoria;
            set => _categoria = !string.IsNullOrWhiteSpace(value)
                ? value
                : throw new ArgumentException("La categoria no puede estar vacía.");
        }

        [JsonIgnore]
        public int Puntaje => _puntaje;

        public Pregunta(string enunciado, string respuestaCorrecta, List<string> opciones, string dificultad, string categoria, int puntaje)
        {
            Enunciado = enunciado;
            RespuestaCorrecta = respuestaCorrecta;
            Opciones = opciones;
            Dificultad = dificultad;
            Categoria = categoria;
            _puntaje = puntaje;
        }
    }
}
