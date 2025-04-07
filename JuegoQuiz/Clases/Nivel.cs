using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace JuegoQuiz.Clases
{
    public class Nivel
    {
        public Category Categoria { get; set; }

        public IList<Pregunta> Preguntas { get; set; }

        public int Puntaje { get; set; }

        public Nivel(Category categoria, IList<Pregunta> preguntas, int puntaje = 0) 
        {
            Categoria = categoria;
            Preguntas = preguntas;
            Puntaje = puntaje;
        }

        public IList<Pregunta> ListaPreguntas()
        {
            return Preguntas;
        }
        public void SumarPuntaje(int valor)
        {
            Puntaje+=valor;
        }
        public void RestarPuntaje()
        {
            Puntaje -= 2;
        }
        public int PuntajeFinal()
        { 
            return Puntaje;
        }
    }
}
