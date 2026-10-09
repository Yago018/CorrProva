using System.ComponentModel.DataAnnotations;

namespace CorrProva.Models
{
    public class ResultadoPeneira
    {
        [Required(ErrorMessage = "CPF é obrigatório")]
        [RegularExpression(@"^\d{11}$",
            ErrorMessage = "CPF deve conter exatamente 11 dígitos numéricos")]
        public string CPF { get; set; } = string.Empty;

        [Required(ErrorMessage = "O resultado de aprovação é obrigatório")]
        public bool? Aprovado { get; set; }
    }
}
