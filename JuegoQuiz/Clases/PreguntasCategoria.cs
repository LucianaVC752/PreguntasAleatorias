using JuegoQuiz.Preguntas;
using JuegoQuiz.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoQuiz.Clases
{
    public class PreguntasHistoria : Pregunta
    {
        public PreguntasHistoria(string dificultad) : base(dificultad)
        {}

        public override List<Pregunta> GetPreguntas()
        {
            Historia historia = new Historia();
            return historia.ObtenerPreguntasHistoria().OrderBy(_ => Guid.NewGuid()).Take(Cantidad).ToList();
        }
    }
    public class PreguntasCiencia : Pregunta
    {
        public PreguntasCiencia(string dificultad) : base(dificultad)
        { }

        public override List<Pregunta> GetPreguntas()
        {
            Ciencia ciencia = new Ciencia();
            return ciencia.ObtenerPreguntasCiencia().OrderBy(_ => Guid.NewGuid()).Take(Cantidad).ToList();
        }
    }

    public class PreguntasCulturaGeneral : Pregunta
    {
        public PreguntasCulturaGeneral(string dificultad) : base(dificultad)
        { }

        public override List<Pregunta> GetPreguntas()
        {
            CulturaGeneral culturaGeneral = new CulturaGeneral();
            return culturaGeneral.ObtenerPreguntasCulturaGeneral().OrderBy(_ => Guid.NewGuid()).Take(Cantidad).ToList();
        }
    }
}
