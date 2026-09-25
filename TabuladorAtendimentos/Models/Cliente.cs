namespace TabuladorAtendimentos.Models;

public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; } = "";
    public string Cpf { get; set; } = "";
    public string Telefone { get; set; } = "";
    public string Cidade { get; set; } = "";
    public string Produto { get; set; } = "";

    public string CpfMascarado =>
        Cpf.Length == 11
            ? $"***.{Cpf.Substring(3, 3)}.***-{Cpf.Substring(9, 2)}"
            : Cpf;
}