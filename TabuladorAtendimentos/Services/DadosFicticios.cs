using TabuladorAtendimentos.Models;

namespace TabuladorAtendimentos.Services;

public static class DadosFicticios
{
    public static readonly IReadOnlyList<Cliente> Clientes =
    [
        new() { Id = 1, Nome = "Mariana Souza",    Cpf = "12345678909", Telefone = "(11) 98765-4321", Cidade = "São Paulo, SP",      Produto = "Internet 500 Mega" },
        new() { Id = 2, Nome = "Carlos Henrique",  Cpf = "98765432100", Telefone = "(21) 99876-5432", Cidade = "Rio de Janeiro, RJ", Produto = "Internet 1 Giga" },
        new() { Id = 3, Nome = "Juliana Ferreira", Cpf = "45678912355", Telefone = "(31) 97654-3210", Cidade = "Belo Horizonte, MG", Produto = "Combo Internet + TV" },
        new() { Id = 4, Nome = "Rafael Lima",      Cpf = "32165498711", Telefone = "(41) 96543-2109", Cidade = "Curitiba, PR",       Produto = "Internet 300 Mega" },
        new() { Id = 5, Nome = "Patrícia Gomes",   Cpf = "78945612322", Telefone = "(51) 95432-1098", Cidade = "Porto Alegre, RS",   Produto = "Internet 500 Mega" },
        new() { Id = 6, Nome = "Bruno Almeida",    Cpf = "15975345688", Telefone = "(81) 94321-0987", Cidade = "Recife, PE",         Produto = "Combo Internet + Móvel" },
        new() { Id = 7, Nome = "Fernanda Rocha",   Cpf = "75315925844", Telefone = "(71) 93210-9876", Cidade = "Salvador, BA",       Produto = "Internet 1 Giga" },
        new() { Id = 8, Nome = "Lucas Martins",    Cpf = "85245696377", Telefone = "(61) 92109-8765", Cidade = "Brasília, DF",       Produto = "Internet 300 Mega" }
    ];

    public static readonly IReadOnlyDictionary<string, string[]> Motivos =
        new Dictionary<string, string[]>
        {
            ["Financeiro"]      = ["Segunda via de fatura", "Contestação de cobrança", "Negociação de débito"],
            ["Suporte técnico"] = ["Sem conexão", "Lentidão", "Troca de equipamento"],
            ["Comercial"]       = ["Upgrade de plano", "Informações sobre planos", "Cancelamento"],
            ["Cadastro"]        = ["Atualização de dados", "Troca de titularidade"]
        };
}