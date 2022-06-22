using System.Collections.Generic;

namespace FormularioInscricao.Models
{
    internal class CursoSelecionado
    {
        private List<string> cursos;

        public void AdicionaCurso(string curso)
        {
            if(!this.cursos.Contains(curso))
                this.cursos.Add(curso);
        }
    }
}
