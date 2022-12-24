namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }

        public Suite Suite { get; set; }

        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            //TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes recebido
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                throw new Exception("Capacidade menor do que o número de hóspedes");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public double CalcularValorDiaria()
        {
            //TODO: Retorna o valor da diaria
            // Cálculo: DiasReservados X Suite.ValorDiaria

            double valor = Convert.ToDouble(DiasReservados) * Convert.ToDouble(Suite.ValorDiaria);

            // Regra: Caso os dias reservados forem maior ou igual a 10 conceder um desconto de 10%.
            //Implemente aqui

            if (DiasReservados >= 10)
            {
                valor = valor * 0.9;
            }

            return valor;
        }
        class Excecao : Exception
        {
            public Excecao(string mensagem) : base(mensagem)
            {
                // construtor que chama construtor de classe genérica
            }
        }
    }
}