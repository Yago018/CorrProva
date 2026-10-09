using System.ComponentModel.DataAnnotations;

namespace CorrProva.Validations
{
    public class PosicaoValidation : ValidationAttribute
    {
        public override bool IsValid(object? value) 
        {
            string? posicao = value?.ToString();
            if (posicao == "GL" || posicao == "ZA" || posicao == "LD" || posicao == "LE" || posicao == "VO" || posicao == "MD" || posicao == "AT")
            {
                return true;
            }
            return false;
        }
    }
}
