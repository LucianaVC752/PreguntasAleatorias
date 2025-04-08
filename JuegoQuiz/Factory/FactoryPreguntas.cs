//using JuegoQuiz.Clases;
//using System;

//namespace JuegoQuiz.Factory
//{
//    public class FactoryPreguntas
//    {
//        public static Pregunta CrearPreguntas(string dificultad, string categoria)
//        {
//			try
//			{
//                switch (categoria.ToLower())
//                {
//                    case "historia":
//                        return new PreguntasHistoria(dificultad);
//                    case "ciencia":
//                        return new PreguntasCiencia(dificultad);
//                    case "cultura general":
//                        return new PreguntasCulturaGeneral(dificultad);
//                    default:
//                        return null;
//                }
//            }
//			catch (Exception ex)
//			{

//                throw new ArgumentException("Ocurrió un error " + ex);
//            }
//        }

//        public static Nivel CrearNivel(string dificultad, string categoria)
//        {
//            var preguntaBase = CrearPreguntas(dificultad, categoria);
//            var preguntas = preguntaBase.GetPreguntas();

//            return new Nivel(new Category(dificultad), preguntas);
//        }
//    }
//}
