namespace Loteria.Simulador.Domain.Entities
{
    public class MegaSena : BaseEntity
    {
        public MegaSena() { }

        public void GerarJogo6Numeros()
        {
            Concurso = 1;
            Jogo = GeradorAleatorioDeNumeros(6);
        }

        public override string GeradorAleatorioDeNumeros(int qtdeNumeros)
        {
            Random random = new Random();

            List<int> numerosAleatorios = new List<int>();

            while (numerosAleatorios.Count < qtdeNumeros)
            {
                int numeroAleatorio = random.Next(1, 60);
                if (!numerosAleatorios.Contains(numeroAleatorio))
                {
                    numerosAleatorios.Add(numeroAleatorio);
                }
            }

            return string.Join(", ", numerosAleatorios);
        }
    }
}
