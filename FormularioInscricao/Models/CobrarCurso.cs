namespace FormularioInscricao.Models
{
    internal class CobrarCurso
    {
        private double valorDoCurso;
        private double valorDaMulta;
        private double valorDeDesconto;
        private double resultado;

        public CobrarCurso(double valorDoCurso, double valorDaMulta, double valorDeDesconto)
        {
            this.valorDoCurso = valorDoCurso;
            this.valorDaMulta = valorDaMulta;
            this.valorDeDesconto = valorDeDesconto;
        }

        public double ValorDoCurso { get; set; }
        public double ValorDaMulta { get; set; }
        public double ValorDeDesconto { get; set; }
        public double Resultado { get => this.resultado;}

        public void CalcularResultado()
        {
            this.resultado = this.valorDaMulta > 0 ? this.valorDoCurso + this.valorDaMulta : this.valorDoCurso - this.valorDeDesconto;
        }

    }
}
