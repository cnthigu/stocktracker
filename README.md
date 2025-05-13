# StockTracker

Projeto simples de uma aplicação web desenvolvida com **ASP.NET Core MVC**, que consome a **API da Twelve Data** para exibir cotações de ações em tempo real. A interface permite consultar rapidamente o preço das ações de diversas empresas, exibindo dados como preço atual, variação percentual e outros dados financeiros.

Este projeto demonstra a aplicação prática de conceitos fundamentais em consumo de APIs, estruturação de projetos MVC e boas práticas de desenvolvimento backend em C#.

---

## Visão Geral

A aplicação permite que o usuário:

- Busque o preço atual de qualquer ação.
- Visualize informações como:
  - Preço atual da ação.
  - Variação percentual (alta/baixa).
  - Volume de transações.
  - Última atualização.

---

## Tecnologias Utilizadas

- **ASP.NET Core MVC** – Estrutura principal da aplicação.
- **C#** – Linguagem para construção da lógica de negócio.
- **Razor Pages** – Para renderização das views.
- **HttpClient** – Para chamadas assíncronas à API externa.
- **Twelve Data API** – Fonte oficial dos dados financeiros.
- **Newtonsoft.Json (JObject)** – Para parse e leitura dinâmica dos dados JSON.

---

## O que foi aprendido

Durante o desenvolvimento deste projeto, foi possível consolidar conhecimentos em:

- Estruturação de projetos no padrão **MVC**.
- Utilização do **HttpClient** para consumo de APIs externas.
- Manipulação e tratamento de respostas JSON com **JObject**.
- Leitura de configurações seguras com **IConfiguration** (via `appsettings.json`).
- Boas práticas de **tratamento de erros** e respostas HTTP.
- Exibição de dados dinamicamente nas views com **Razor Pages**.
- Escrita de código limpo, organizado e orientado a propósito.

---

## Como Executar Localmente

1. Clone este repositório:
   ```bash
   git clone https://github.com/cnthigu/stocktracker.git
    ```
2. Abra o projeto no **Visual Studio** ou no seu editor preferido.

3. Adicione sua chave da  Twelve Data em `appsettings.json`:
   ```json
   "TwelveData": {
     "ApiKey": "SUA_CHAVE_AQUI"
   }
   ```
---

## Demonstração

[ Video Rapido](https://youtu.be/Yo1G-Xmo5Cc)

---

Desenvolvido com atenção aos detalhes, mesmo sendo um projeto de escopo simples, com foco em boas práticas e clareza no código.
