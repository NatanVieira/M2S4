namespace FormularioInscricao.Models
{
    public class FichaInscricao
    {
        public string nome;
        public int idade;
        public string curso;
        public string escolaridade;
        public System.DateTime dataDeNascimento;
        public double valorDoCurso;
        public double valorDeDesconto;
        public double valorDaMulta;

        public FichaInscricao(string nome, string curso, string escolaridade, System.DateTime dataDeNascimento, double valorDoCurso, double valorDeDesconto, double valorDaMulta)
        {
            this.nome = nome;
            this.curso = curso;
            this.dataDeNascimento = dataDeNascimento; 
            this.escolaridade = escolaridade;
            this.valorDaMulta = valorDaMulta;
            this.valorDeDesconto = valorDeDesconto;
            this.valorDoCurso = valorDoCurso;
            this.CalcularIdade();
        }

        private void CalcularIdade()
        {   
            this.idade = System.DateTime.Now.Year - this.dataDeNascimento.Year;
        }
    }
}
