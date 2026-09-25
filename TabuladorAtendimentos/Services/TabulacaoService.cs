using System.Text.Json;
using Microsoft.JSInterop;
using TabuladorAtendimentos.Models;

namespace TabuladorAtendimentos.Services;

public class TabulacaoService(IJSRuntime js)
{
    private const string Chave = "tabulacoes";
    private List<Tabulacao> _tabulacoes = [];
    private bool _carregado;

    public async Task<IReadOnlyList<Tabulacao>> ListarAsync()
    {
        await CarregarAsync();
        return _tabulacoes.OrderByDescending(t => t.Fim).ToList();
    }

    public async Task<IReadOnlyList<Tabulacao>> ListarPorClienteAsync(int clienteId)
    {
        await CarregarAsync();
        return _tabulacoes
            .Where(t => t.ClienteId == clienteId)
            .OrderByDescending(t => t.Fim)
            .ToList();
    }

    public async Task SalvarAsync(Tabulacao tabulacao)
    {
        await CarregarAsync();
        _tabulacoes.Add(tabulacao);
        var json = JsonSerializer.Serialize(_tabulacoes);
        await js.InvokeVoidAsync("localStorage.setItem", Chave, json);
    }

    private async Task CarregarAsync()
    {
        if (_carregado) return;

        var json = await js.InvokeAsync<string?>("localStorage.getItem", Chave);
        if (!string.IsNullOrEmpty(json))
            _tabulacoes = JsonSerializer.Deserialize<List<Tabulacao>>(json) ?? [];

        _carregado = true;
    }
}