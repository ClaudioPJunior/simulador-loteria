#nullable disable
namespace Loteria.Simulador.Domain.Entities
{
    public abstract class BaseEntity
    {
        public int Concurso { get; set; }
        public string Jogo { get; set; }

        public abstract string GeradorAleatorioDeNumeros(int qtdeNumeros);
    }
}
