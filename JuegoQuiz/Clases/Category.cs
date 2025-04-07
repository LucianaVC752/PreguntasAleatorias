using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoQuiz.Clases
{
    public class Category
    {
        public int Tiempo { get; set; }
        public int ValorPregunta { get; set; }
        public Category(string dificultad)
        {
            try
            {
                switch (dificultad.ToLower())
                {
                    case "facil":
                        Tiempo = 20;
                        ValorPregunta = 5;
                        break;
                    case "media":
                    case "medio": 
                        Tiempo = 15;
                        ValorPregunta = 10;
                        break;
                    case "dificil":
                        Tiempo = 10;
                        ValorPregunta = 15;
                        break;
                    default:
                        Tiempo = 0;
                        ValorPregunta = 0;
                        break;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error con la categoría" + ex);
            }
        }

        public int TiempoPregunta()
        {
            return Tiempo;
        }

        public int SaberPregunta()
        {
            return ValorPregunta;
        }
    }
}
