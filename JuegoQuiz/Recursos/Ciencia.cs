using JuegoQuiz.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JuegoQuiz.Recursos
{
    public class Ciencia
    {
       
            // En esta clase estoy trayendo la base de datos de los empleados
            // acá estoy diciendo la direcci+on que se va a guardar en la variable filePath
            private string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Preguntas", "Ciencia.json"); // Ruta del archivo de trabajadores

            public IList<PreguntasCiencia> ObtenerPreguntasCiencia()
            {//Verifica si el archivo existe
            try
            {
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException($"El archivo {filePath} no se encontró.");
                }

                string jsonData = File.ReadAllText(filePath);

                // ✅ Esta es la forma correcta para tu estructura actual
                var jsonCiencia = JsonSerializer.Deserialize<Dictionary<string, List<PreguntasCiencia>>>(jsonData);

                // Aquí puedes acceder a las preguntas directamente
                var listaPreguntas = jsonCiencia["Ciencia"];

                return listaPreguntas;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Ocurrió un error: " + ex);
            }
        }
    }
}
