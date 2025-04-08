using JuegoQuiz.Clases;
using JuegoQuiz.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace JuegoQuiz.Factory
{
    public static class PreguntasFactory
    {
        private class PreguntaJsonWrapper
        {
            public List<Pregunta> preguntas { get; set; }
        }

        public static Pregunta CrearPregunta(Categoria categoriaSeleccionada, Dificultad dificultadSeleccionada)
        {
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Preguntas", "preguntas.json");

            if (!File.Exists(rutaArchivo))
                throw new FileNotFoundException("No se encontró el archivo de preguntas.", rutaArchivo);

            string json = File.ReadAllText(rutaArchivo);
            var opciones = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var jsonWrapper = JsonSerializer.Deserialize<PreguntaJsonWrapper>(json, opciones);

            if (jsonWrapper?.preguntas == null || jsonWrapper.preguntas.Count == 0)
                throw new InvalidOperationException("No se pudieron cargar preguntas desde el archivo.");

            // Filtrar por dificultad y categoría, usando cadenas
            var preguntasFiltradas = jsonWrapper.preguntas
                .Where(p => string.Equals(p.Dificultad.ToString(), dificultadSeleccionada.ToString(), StringComparison.OrdinalIgnoreCase) &&
                            string.Equals(p.Categoria.ToString(), categoriaSeleccionada.ToString(), StringComparison.OrdinalIgnoreCase))
                .ToList();

            // Si no se encuentran preguntas con los enums (porque vienen en texto del JSON), intentar filtrar por el texto del JSON
            if (preguntasFiltradas.Count == 0)
            {
                preguntasFiltradas = jsonWrapper.preguntas
                    .Where(p => string.Equals(GetCategoriaFromJson(p), categoriaSeleccionada.ToString(), StringComparison.OrdinalIgnoreCase) &&
                                string.Equals(GetDificultadFromJson(p), dificultadSeleccionada.ToString(), StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            if (preguntasFiltradas.Count == 0)
                throw new InvalidOperationException("No se encontraron preguntas con la categoría y dificultad seleccionadas.");

            var random = new Random();
            var preguntaSeleccionada = preguntasFiltradas[random.Next(preguntasFiltradas.Count)];

            switch (dificultadSeleccionada)
            {
                case Dificultad.Facil:
                    return new PreguntaFacil(
                        preguntaSeleccionada.Enunciado,
                        preguntaSeleccionada.RespuestaCorrecta,
                        preguntaSeleccionada.Opciones,
                        categoriaSeleccionada
                    );
                case Dificultad.Media:
                    return new PreguntaMedia(
                        preguntaSeleccionada.Enunciado,
                        preguntaSeleccionada.RespuestaCorrecta,
                        preguntaSeleccionada.Opciones,
                        categoriaSeleccionada
                    );
                case Dificultad.Dificil:
                    return new PreguntaDificil(
                        preguntaSeleccionada.Enunciado,
                        preguntaSeleccionada.RespuestaCorrecta,
                        preguntaSeleccionada.Opciones,
                        categoriaSeleccionada
                    );
                default:
                    throw new ArgumentOutOfRangeException("dificultadSeleccionada", "Dificultad no válida.");
            }

        }

        private static string GetDificultadFromJson(Pregunta pregunta)
        {
            return JsonDocument.Parse(JsonSerializer.Serialize(pregunta))
                .RootElement.GetProperty("dificultad").GetString();
        }

        private static string GetCategoriaFromJson(Pregunta pregunta)
        {
            return JsonDocument.Parse(JsonSerializer.Serialize(pregunta))
                .RootElement.GetProperty("categoria").GetString();
        }
    }
}
