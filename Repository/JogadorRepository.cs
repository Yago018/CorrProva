using CorrProva.Models;

namespace CorrProva.Repository
{
    public class JogadorRepository : IJogadorRepository
    {
        private readonly List<Jogador> _listaJogadores = new();

        public void Cadastrar(Jogador jogador)
        {
            _listaJogadores.Add(jogador);
        }

        public List<Jogador> ObterTodos()
        {
            return _listaJogadores;
        }

        public Jogador? ObterPorCPF(string cpf)
        {
            return _listaJogadores.FirstOrDefault(
                jogador => jogador.CPF == cpf);
        }

        public bool RegistrarResultado(string cpf, bool aprovado)
        {
            Jogador? jogador = ObterPorCPF(cpf);

            if (jogador is null || jogador.Peneira.HasValue)
                return false;

            jogador.Peneira = aprovado;
            return true;
        }

        public List<Jogador> ObterAprovados()
        {
            return _listaJogadores
                .Where(jogador => jogador.Peneira == true)
                .ToList();
        }
    }
}
