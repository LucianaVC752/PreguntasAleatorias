//using JuegoQuiz.Clases;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Text.Json;
//using System.Threading.Tasks;

//namespace JuegoQuiz.Preguntas
//{
//    public class Historia
//    {
//        // En esta clase estoy trayendo la base de datos de los empleados
//        // acá estoy diciendo la direcci+on que se va a guardar en la variable filePath
//        private string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Preguntas", "Historia.json"); // Ruta del archivo de trabajadores

//        public IList<PreguntasHistoria> ObtenerPreguntasHistoria(string dificultadSeleccionada)
//        {//Verifica si el archivo existe

//            try
//            {
//                if (!File.Exists(filePath))
//                    throw new FileNotFoundException($"El archivo {filePath} no se encontró.");

//                string jsonData = File.ReadAllText(filePath);
//                var jsonHistoria = JsonSerializer.Deserialize<Dictionary<string, List<PreguntasHistoria>>>(jsonData);

//                var preguntasFiltradas = jsonHistoria["Historia"]
//                    .Where(p => p.Dificultad.ToLower() == dificultadSeleccionada.ToLower())
//                    .OrderBy(_ => Guid.NewGuid()) // 🔀 Aleatorizar
//                    .Take(15)                     // 📦 Tomar solo 15 aleatorias
//                    .ToList();

//                foreach (var pregunta in preguntasFiltradas)
//                {
//                    pregunta.Categoria = new Category(dificultadSeleccionada);
//                }

//                return preguntasFiltradas;
//            }
//            catch (Exception ex)
//            {
//                throw new ArgumentException("Ocurrió un error: " + ex.Message);
//            }
//        }
//    }
//}
