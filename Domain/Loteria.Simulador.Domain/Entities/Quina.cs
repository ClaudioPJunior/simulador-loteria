namespace Loteria.Simulador.Domain.Entities
{
    public class Quina : BaseEntity
    {
        public Quina() { }

        public void GerarJogo5Numeros()
        {
            Concurso = 1;
            Jogo = GeradorAleatorioDeNumeros(5);
        }

        public override string GeradorAleatorioDeNumeros(int qtdeNumeros)
        {
            Random random = new Random();

            List<int> numerosAleatorios = new List<int>();

            while (numerosAleatorios.Count < qtdeNumeros)
            {
                int numeroAleatorio = random.Next(1, 80);
                if (!numerosAleatorios.Contains(numeroAleatorio))
                {
                    numerosAleatorios.Add(numeroAleatorio);
                }
            }

            return string.Join(", ", numerosAleatorios);
        }
    }
}
