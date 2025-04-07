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
        private string _dificultad;
        public PreguntasHistoria() : base("") { }
        public PreguntasHistoria(string dificultad) : base(dificultad)
        {
            _dificultad = dificultad;
        }

        public override List<Pregunta> GetPreguntas()
        {
            Historia historia = new Historia();
            return historia.ObtenerPreguntasHistoria(_dificultad)
                      .Cast<Pregunta>() // Porque la función debe devolver List<Pregunta>
                      .OrderBy(_ => Guid.NewGuid())
                      .Take(Cantidad)
                      .ToList();
        }
    }
    public class PreguntasCiencia : Pregunta
    {
        private string _dificultad;
        public PreguntasCiencia() : base("") { }
        public PreguntasCiencia(string dificultad) : base(dificultad)
        {
            _dificultad = dificultad;
        }

        public override List<Pregunta> GetPreguntas()
        {
            Ciencia ciencia = new Ciencia();
            return ciencia.ObtenerPreguntasCiencia(_dificultad)
                      .Cast<Pregunta>() // Porque la función debe devolver List<Pregunta>
                      .OrderBy(_ => Guid.NewGuid())
                      .Take(Cantidad)
                      .ToList();
        }
    }

    public class PreguntasCulturaGeneral : Pregunta
    {
        private string _dificultad;
        public PreguntasCulturaGeneral() : base("") { }
        public PreguntasCulturaGeneral(string dificultad) : base(dificultad)
        {
            _dificultad = dificultad;
        }

        public override List<Pregunta> GetPreguntas()
        {
            CulturaGeneral culturaGeneral = new CulturaGeneral();
            return culturaGeneral.ObtenerPreguntasCulturaGeneral(_dificultad)
                      .Cast<Pregunta>() // Porque la función debe devolver List<Pregunta>
                      .OrderBy(_ => Guid.NewGuid())
                      .Take(Cantidad)
                      .ToList();
        }
    }
}
