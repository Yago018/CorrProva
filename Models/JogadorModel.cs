using System.ComponentModel.DataAnnotations;
using CorrProva.Validations;

namespace CorrProva.Models
{
    public class Jogador
    {
        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(50, MinimumLength = 3,
            ErrorMessage = "Nome deve ter entre 3 e 50 caracteres")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "CPF é obrigatório")]
        [RegularExpression(@"^\d{11}$",
            ErrorMessage = "CPF deve conter exatamente 11 dígitos numéricos")]
        public string CPF { get; set; } = string.Empty;

        [Required(ErrorMessage = "Descrição é obrigatória")]
        [StringLength(500,
            ErrorMessage = "Descrição deve ter no máximo 500 caracteres")]
        public string Descricao { get; set; } = string.Empty;

        [Required(ErrorMessage = "Posição é obrigatória")]
        [PosicaoValidation]
        public string Posicao { get; set; } = string.Empty;

        // null = resultado não registrado; true = aprovado; false = reprovado
        public bool? Peneira { get; set; }
    }
}
