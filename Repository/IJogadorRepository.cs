using CorrProva.Models;

namespace CorrProva.Repository
{
    public interface IJogadorRepository
    {
        void Cadastrar(Jogador jogador);
        List<Jogador> ObterTodos();
        Jogador? ObterPorCPF(string cpf);
        bool RegistrarResultado(string cpf, bool aprovado);
        List<Jogador> ObterAprovados();
    }
}
