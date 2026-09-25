using System.ComponentModel.DataAnnotations;

namespace TabuladorAtendimentos.Models;

public class Tabulacao
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public int ClienteId { get; set; }
    public string ClienteNome { get; set; } = "";

    [Required(ErrorMessage = "Selecione o motivo do atendimento.")]
    public string Motivo { get; set; } = "";

    [Required(ErrorMessage = "Selecione o submotivo.")]
    public string Submotivo { get; set; } = "";

    public bool Resolvido { get; set; }

    [MaxLength(500, ErrorMessage = "A observação pode ter no máximo 500 caracteres.")]
    public string Observacao { get; set; } = "";

    public DateTime Inicio { get; set; }
    public DateTime Fim { get; set; }

    public TimeSpan Duracao => Fim - Inicio;
}