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
//    //public class TransformadorJson
//    //{
//    //    public static void ConvertirJson(string rutaEntrada, string rutaSalida)
//    //    {
//    //        string jsonData = File.ReadAllText(rutaEntrada, Encoding.GetEncoding("ISO-8859-1"));

//    //        var datosOriginales = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, List<Pregunta>>>>(jsonData);

//    //        var nuevoFormato = new Dictionary<string, List<Pregunta>>();

//    //        foreach (var categoria in datosOriginales)
//    //        {
//    //            var nombreCategoria = categoria.Key;
//    //            var preguntasLista = new List<Pregunta>();

//    //            foreach (var dificultad in categoria.Value)
//    //            {
//    //                foreach (var pregunta in dificultad.Value)
//    //                {
//    //                    pregunta.Dificultad = dificultad.Key;
//    //                    pregunta.Categoria = new Category(dificultad.Key, nombreCategoria);
//    //                    preguntasLista.Add(pregunta);
//    //                }
//    //            }

//    //            nuevoFormato[nombreCategoria] = preguntasLista;
//    //        }

//    //        var opciones = new JsonSerializerOptions { WriteIndented = true };
//    //        var jsonTransformado = JsonSerializer.Serialize(nuevoFormato, opciones);
//    //        File.WriteAllText(rutaSalida, jsonTransformado);

//    //        Console.WriteLine($"JSON transformado guardado en: {rutaSalida}");
//    //    }
//    //}
//}