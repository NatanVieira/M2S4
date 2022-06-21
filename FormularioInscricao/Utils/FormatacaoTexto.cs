using FormularioInscricao.Models;

namespace FormularioInscricao.Utils
{
    public static class FormatacaoTexto
    {
        public static string formataTexto(FichaInscricao fichaInscricao)
        {
            if(fichaInscricao.valorDeDesconto <= 0)
            {
                return $"Nome: {fichaInscricao.nome}, Curso: {fichaInscricao.curso}, Valor Curso: {fichaInscricao.valorDoCurso.ToString("c")}.";
            }else if(fichaInscricao.valorDeDesconto > 0)
            {
                if(fichaInscricao.idade < 18)
                {
                    return $"Nome: {fichaInscricao.nome}, Curso: {fichaInscricao.curso}, Valor Curso: {fichaInscricao.valorDoCurso.ToString("c")}, Valor de desconto: {fichaInscricao.valorDeDesconto.ToString("c")}.";
                }
                else
                {
                    return $"Nome: {fichaInscricao.nome}, Curso: {fichaInscricao.curso}, Valor Curso: {fichaInscricao.valorDoCurso.ToString("c")}, Valor de desconto: {fichaInscricao.valorDeDesconto.ToString("c")}, Idade: {fichaInscricao.idade}.";
                }
            }
            return "";

        }
    }
}
