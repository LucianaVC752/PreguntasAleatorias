using JuegoQuiz.Clases;
using JuegoQuiz.Constantes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace JuegoQuiz.Factory
{
    public static class PreguntasFactory
    {
        private class PreguntaJsonWrapper
        {
            public List<Pregunta> Preguntas { get; set; }
        }

        public static Pregunta CrearPregunta(string categoriaSeleccionada, string dificultadSeleccionada)
        {
            try
            {
                string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Preguntas", "preguntas.json");

                if (!File.Exists(rutaArchivo))
                    throw new FileNotFoundException("No se encontró el archivo de preguntas.", rutaArchivo);

                string json;
                try
                {
                    json = File.ReadAllText(rutaArchivo);
                }
                catch (Exception exLectura)
                {
                    MessageBox.Show("Error al leer el archivo JSON:\n" + exLectura.Message, "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                PreguntaJsonWrapper jsonWrapper;
                try
                {
                    var opciones = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    jsonWrapper = JsonSerializer.Deserialize<PreguntaJsonWrapper>(json, opciones);
                }
                catch (Exception exDeserializacion)
                {
                    MessageBox.Show("Error al deserializar el archivo JSON:\n" + exDeserializacion.Message, "Error de deserialización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                if (jsonWrapper?.Preguntas == null || jsonWrapper.Preguntas.Count == 0)
                {
                    MessageBox.Show("No se encontraron preguntas en el archivo JSON.", "Archivo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }

                var preguntasFiltradas = jsonWrapper.Preguntas
                    .Where(p => string.Equals(p.Dificultad, dificultadSeleccionada, StringComparison.OrdinalIgnoreCase) &&
                                string.Equals(p.Categoria, categoriaSeleccionada, StringComparison.OrdinalIgnoreCase))
                    .OrderBy(_ => Guid.NewGuid())
                    .ToList();

                if (preguntasFiltradas.Count == 0)
                {
                    MessageBox.Show("No se encontraron preguntas con la categoría y dificultad seleccionadas.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return null;
                }

                var random = new Random();
                var preguntaSeleccionada = preguntasFiltradas[random.Next(preguntasFiltradas.Count)];

                switch (dificultadSeleccionada)
                {
                    case EnumDificultad.Facil:
                        return new PreguntaFacil(
                            preguntaSeleccionada.Enunciado,
                            preguntaSeleccionada.RespuestaCorrecta,
                            preguntaSeleccionada.Opciones,
                            categoriaSeleccionada
                        );
                    case EnumDificultad.Media:
                        return new PreguntaMedia(
                            preguntaSeleccionada.Enunciado,
                            preguntaSeleccionada.RespuestaCorrecta,
                            preguntaSeleccionada.Opciones,
                            categoriaSeleccionada
                        );
                    case EnumDificultad.Dificil:
                        return new PreguntaDificil(
                            preguntaSeleccionada.Enunciado,
                            preguntaSeleccionada.RespuestaCorrecta,
                            preguntaSeleccionada.Opciones,
                            categoriaSeleccionada
                        );
                    default:
                        MessageBox.Show("La dificultad seleccionada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado:\n" + ex.Message, "Error general", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
