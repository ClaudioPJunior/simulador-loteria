#nullable disable
namespace Loteria.Simulador.Domain.Entities
{
    public class Lotofacil : BaseEntity
    {
        public Lotofacil() { }

        public void GerarJogo15Numeros()
        {
            Concurso = 1;
            Jogo = GeradorAleatorioDeNumeros(15);
        }

        public override string GeradorAleatorioDeNumeros(int qtdeNumeros)
        {
            Random random = new Random();

            List<int> numerosAleatorios = new List<int>();

            while (numerosAleatorios.Count < qtdeNumeros)
            {
                int numeroAleatorio = random.Next(1, 26);
                if (!numerosAleatorios.Contains(numeroAleatorio))
                {
                    numerosAleatorios.Add(numeroAleatorio);
                }
            }

            return string.Join(", ", numerosAleatorios);
        }
    }
}