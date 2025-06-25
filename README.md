# 📺 ShareTV - Plataforma de Streaming

Backend desenvolvido em **.NET 8** com **Entity Framework Core** e **SQLite**. A API possui os seguintes endpoints:  

**POST /api/stream/create** — Cria uma nova live com título, descrição e gera uma chave única para streaming. Exemplo de requisição JSON:  

{
  "title": "Live com Matheus",
  "description": "Primeira transmissão de teste"
}

Resposta JSON:  

{
  "id": 1,
  "streamKey": "b1dc7351-f324-41bc-984b-c3a2bfa5fdab",
  "title": "Live com Matheus",
  "description": "Primeira transmissão de teste",
  "createdAt": "2025-06-25T18:30:00Z",
  "isLive": false
}

**GET /api/stream** — Retorna a lista de lives cadastradas, exemplo de resposta:  

[
  {
    "id": 1,
    "streamKey": "b1dc7351-f324-41bc-984b-c3a2bfa5fdab",
    "title": "Live com Matheus",
    "description": "Primeira transmissão de teste",
    "createdAt": "2025-06-25T18:30:00Z",
    "isLive": false
  }
]

O modelo de dados para uma live (`LiveStream`) possui os campos:  
`id` (int, identificador),  
`streamKey` (string, chave única para envio via OBS),  
`title` (string, título da live),  
`description` (string, descrição opcional),  
`createdAt` (DateTime, data de criação) e  
`isLive` (bool, status da transmissão online).

Setup do projeto: criar projeto Web API com  

`dotnet new webapi -n StreamPlatform.API`,  

instalar dependências com  

`dotnet add package Microsoft.EntityFrameworkCore.Sqlite` e  
`dotnet add package Microsoft.EntityFrameworkCore.Tools`,  

criar e aplicar migração inicial com  

`dotnet ef migrations add Initial` e  
`dotnet ef database update`,  

e rodar o projeto com  

`dotnet run`.

Integração futura com OBS: envie vídeo ao vivo para o servidor RTMP na URL  

`rtmp://<seu-servidor>:1935/live`  

usando a `streamKey` retornada pela API como Stream Key no OBS.

Seja bem-vindo(a) ao ShareTV! 🚀  
Quer ajudar no projeto? Sinta-se à vontade para contribuir!
