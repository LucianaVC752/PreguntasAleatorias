//using JuegoQuiz.Clases;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Text.Json;
//using System.Threading.Tasks;

//namespace JuegoQuiz.Recursos
//{
//    public class CulturaGeneral
//    {
//        // En esta clase estoy trayendo la base de datos de los empleados
//        // acá estoy diciendo la direcci+on que se va a guardar en la variable filePath
//        private string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Preguntas", "CulturaGeneral.json"); // Ruta del archivo de trabajadores

//        public IList<PreguntasCulturaGeneral> ObtenerPreguntasCulturaGeneral(string dificultadSeleccionada)
//        {//Verifica si el archivo existe

//            //Verifica si el archivo existe
//            try
//            {
//                if (!File.Exists(filePath))
//                    throw new FileNotFoundException($"El archivo {filePath} no se encontró.");

//                string jsonData = File.ReadAllText(filePath);
//                var jsonCultura = JsonSerializer.Deserialize<Dictionary<string, List<PreguntasCulturaGeneral>>>(jsonData);

//                var preguntasFiltradas = jsonCultura["Cultura General"]
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
