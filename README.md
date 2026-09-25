📞 Tabulador de Atendimentos

Simulação de uma ferramenta de **CTI** usada por times de atendimento: a ligação entra, a ficha do cliente abre e a analista registra o motivo do contato. Cada tabulação alimenta o histórico e os indicadores da operação.

**🔗 [Acesse a demo](https://daniella-2907.github.io/tabulador-atendimentos/)**

<img width="1365" height="598" alt="image" src="https://github.com/user-attachments/assets/0981ef24-5c9d-4a87-b999-da0a6c1a54f8" />

<img width="1365" height="600" alt="image" src="https://github.com/user-attachments/assets/bdaeb212-f451-4719-a2d1-9bf487d61f71" />

<img width="1364" height="598" alt="image" src="https://github.com/user-attachments/assets/835f7b90-0183-47d0-a376-2f7f3618c7d7" />

<img width="1364" height="596" alt="image" src="https://github.com/user-attachments/assets/7d525b89-b952-441e-9734-71046e98d9d2" />


## 💡 Sobre o projeto

Trabalho desenvolvendo ferramentas de CTI e tabulação para operações de atendimento. Como o código dessas ferramentas é confidencial, criei este projeto do zero para mostrar como resolvo esse tipo de problema, usando o **.NET 10** e dados fictícios.

## ✨ Funcionalidades

- **Atendimento**: simula uma ligação com cliente aleatório, exibe a ficha com CPF mascarado (LGPD), o histórico do cliente e um cronômetro da ligação
- **Tabulação**: motivo e submotivo em cascata, com validação dos campos obrigatórios
- **Histórico**: lista de atendimentos com filtro por motivo e por data
- **Painel**: volume de atendimentos, taxa de resolução, tempo médio de atendimento (TMA) e distribuição por motivo




## 🛠️ Tecnologias

- C# e .NET 10
- Blazor WebAssembly
- Bootstrap 5
- GitHub Actions para publicação automática no GitHub Pages

## 🧩 Decisões técnicas

- **Validação no modelo** com Data Annotations: a regra fica em um lugar só e o formulário lê automaticamente
- **Injeção de dependência** para o serviço de tabulação, compartilhado entre as telas
- **Persistência no localStorage** do navegador via `IJSRuntime`, para a demo funcionar sem servidor
- **Dados sensíveis mascarados** na exibição, seguindo o mesmo cuidado com LGPD das ferramentas reais

## ▶️ Como rodar localmente

Pré-requisito: [.NET 10 SDK](https://dotnet.microsoft.com/download)

```bash
git clone https://github.com/Daniella-2907/tabulador-atendimentos.git
cd tabulador-atendimentos/TabuladorAtendimentos
dotnet watch
```

## 👩‍💻 Autora

**Daniella Veronez**, Analista de Sistemas e desenvolvedora .NET

[LinkedIn](https://www.linkedin.com/in/daniella-veronez-dev) · [GitHub](https://github.com/Daniella-2907)
