CASCA API - EXERCÍCIO PENEIRA ARAXÁ ESPORTE 2027

Conteúdo:
- Models/ExemploModel.cs
- Models/ResultadoPeneira.cs
- Validations/ExemploValidations.cs
- Repository/IExemploRepository.cs
- Repository/ExemploRepository.cs
- Controllers/ExemploController.cs
- Program.cs

Como usar:
1. Faça backup dos arquivos atuais.
2. Copie os arquivos para as pastas correspondentes do seu projeto.
3. Confira se o namespace do projeto continua sendo CascaApi.
4. Execute: dotnet build
5. Execute: dotnet run

Endpoints:
POST /Exemplo
GET  /Exemplo/ListarJogadores
POST /Exemplo/RegistrarResultado
GET  /Exemplo/ListarAprovados

Exemplo de cadastro:
{
  "nome": "João Silva",
  "cpf": "12345678901",
  "descricao": "Jogador de teste",
  "posicao": "AT"
}

Exemplo de resultado:
{
  "cpf": "12345678901",
  "aprovado": true
}

Os dados ficam apenas em memória e são perdidos quando a aplicação reinicia.
A documentação OpenAPI configurada no projeto pode ser acessada pelo endpoint /openapi/v1.json.
