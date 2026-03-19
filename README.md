- 💳 Sistema de Processamento de Pagamentos

Projeto desenvolvido como atividade de fixação da disciplina de **Desenvolvimento de Sistemas (DS)** — 2DS AMS, aplicando os conceitos de **Herança** e **Polimorfismo** em C#.

## 📋 Sobre o Projeto

O sistema simula diferentes formas de pagamento, onde cada tipo compartilha atributos comuns da classe base `Pagamento`, mas executa o processamento de forma específica.

## 🗂️ Estrutura do Projeto

SistemaPagamentos/
├── Pagamento.cs # Classe base abstrata
├── CartaoCredito.cs # Herda de Pagamento
├── Pix.cs # Herda de Pagamento
├── Boleto.cs # Herda de Pagamento
└── Program.cs # Instancia e testa os objetos


## 🧱 Diagrama de Classes

| Classe          | Herda de   | Atributos Específicos                          |
|-----------------|------------|------------------------------------------------|
| `Pagamento`     | —          | `Valor`, `Data`                                |
| `CartaoCredito` | Pagamento  | `NumeroCartao`, `Parcelas`                     |
| `Pix`           | Pagamento  | `ChavePix`, `CodigoCopiaECola`                 |
| `Boleto`        | Pagamento  | `CodigoBarras`, `DataVencimento`               |

## ▶️ Como Executar

### Pré-requisitos
- [.NET SDK](https://dotnet.microsoft.com/download) instalado (versão 6.0 ou superior)

### Passos

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/SistemaPagamentos.git
   
Acesse a pasta do projeto:
cd SistemaPagamentos

Execute o projeto:
dotnet run

💻 Saída Esperada

Pagamento de R$ 350 realizado no cartão 4111 1111 1111 1111 em 3x.
Chave Pix pagamentos@email.com validada. Aguardando recebimento instantâneo.
Boleto gerado com sucesso. Vencimento para o dia 25/03/2026.
🎯 Conceitos Aplicados
Herança — as classes CartaoCredito, Pix e Boleto herdam da classe base Pagamento usando : Pagamento

Polimorfismo — o método Processar() é sobrescrito com override em cada classe filha

Abstração — a classe Pagamento define o contrato comum para todos os tipos de pagamento

🛠️ Tecnologias
C# (.NET)

Orientação a Objetos (POO)

👨‍🏫 Informações
Instituição: Etec Professor Elias Miguel Junior

Turma: 2DS — AMS

Disciplina: Desenvolvimento de Sistemas


### Dicas antes de publicar:
- Substitua `seu-usuario` pela sua conta do GitHub no link de clone
- Adicione seu **nome** na seção de Informações caso o professor exija identificação
- Para criar o repositório, use `git init`, `git add .`, `git commit -m "primeiro commit"` e `git push`
