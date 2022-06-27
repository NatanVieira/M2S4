using System.Collections.Generic;

namespace FormularioInscricao.Models
{
    internal class CursoSelecionado
    {
        private List<string> cursos;

        public CursoSelecionado()
        {
            this.cursos = new List<string>();
        }
        public void AdicionaCurso(string curso)
        {
            if(!this.cursos.Contains(curso))
                this.cursos.Add(curso);
        }

        public override string ToString()
        {
            if (this.cursos.Count > 0){
                string cursoString = ""; // $"{this.cursos[0]},\n";
                this.cursos.ForEach(c =>
                {
                    cursoString += $"{c},\n";
                });
                cursoString = cursoString.Substring(0,cursoString.Length - 2);
                return cursoString;
            }
            return "";
        }
    }
}
