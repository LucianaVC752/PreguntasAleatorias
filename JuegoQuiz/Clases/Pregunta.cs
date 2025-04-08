using JuegoQuiz.Enums;
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
        private Dificultad _dificultad;
        private Categoria _categoria;
        private Puntaje _puntaje;

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

        [JsonIgnore] // se carga desde la factory, no desde el JSON
        public Dificultad Dificultad
        {
            get => _dificultad;
            set => _dificultad = value;
        }

        [JsonIgnore]
        public Categoria Categoria
        {
            get => _categoria;
            set => _categoria = value;
        }

        [JsonIgnore]
        public Puntaje Puntaje => _puntaje;

        public Pregunta(string enunciado, string respuestaCorrecta, List<string> opciones, Dificultad dificultad, Categoria categoria, Puntaje puntaje)
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
