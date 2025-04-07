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

            public IList<Pregunta> ObtenerPreguntasCiencia()
            {//Verifica si el archivo existe
            try
            {
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException($"El archivo {filePath} no se encontró.");
                }
                //Acá trae la info pero si estar convertida en json ya que c# no sabe que es un Json
                string jsonData = File.ReadAllText(filePath);
                //acá le decimos que vamos a organizar el Json como un diccionario con 
                //un strin (historia, categoria) y va a tener info de las preguntas

                var jsonCiencia = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, List<Pregunta>>>>(jsonData);

                var listaPreguntas = jsonCiencia
                                      .SelectMany(categoria => categoria.Value
                                      .SelectMany(nivel => nivel.Value.Select(p => {
                                       p.Dificultad = nivel.Key;
                                       p.Categoria = new Category(nivel.Key);
                            return p;
                            }))
                            )
                            .ToList();

                return listaPreguntas;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Ocurrio un error "+ ex);
            }
        }
    }
}
