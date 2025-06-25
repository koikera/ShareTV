# ShareTV
📘 Documentação da API - Plataforma de Streaming
Backend desenvolvido em .NET 8 com EF Core e SQLite.

📁 Endpoints
▶️ Criar uma nova live
POST /api/stream/create

Cria uma nova live com título, descrição e gera uma chave de stream única.

Requisição (JSON):
json
Copiar
Editar
{
  "title": "Live com Matheus",
  "description": "Primeira transmissão de teste"
}
Resposta (200 OK):
json
Copiar
Editar
{
  "id": 1,
  "streamKey": "b1dc7351-f324-41bc-984b-c3a2bfa5fdab",
  "title": "Live com Matheus",
  "description": "Primeira transmissão de teste",
  "createdAt": "2025-06-25T18:30:00Z",
  "isLive": false
}
📄 Listar todas as lives
GET /api/stream

Retorna uma lista de lives cadastradas.

Resposta:
json
Copiar
Editar
[
  {
    "id": 1,
    "streamKey": "b1dc7351-f324-41bc-984b-c3a2bfa5fdab",
    "title": "Live com Matheus",
    "description": "Primeira transmissão de teste",
    "createdAt": "2025-06-25T18:30:00Z",
    "isLive": false
  },
  ...
]
🗃️ Modelo: LiveStream
Campo	Tipo	Descrição
id	int	Identificador da live
streamKey	string	Chave única para envio via OBS
title	string	Título da live
description	string	Descrição opcional da live
createdAt	DateTime	Data de criação
isLive	bool	Status da transmissão (online?)

🏗️ Setup do Projeto
Criar projeto

bash
Copiar
Editar
dotnet new webapi -n StreamPlatform.API
Instalar dependências

bash
Copiar
Editar
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Tools
Executar migração

bash
Copiar
Editar
dotnet ef migrations add Initial
dotnet ef database update
Rodar projeto

bash
Copiar
Editar
dotnet run
📺 Integração com OBS (futura)
Você pode enviar vídeo ao vivo via OBS para um servidor RTMP com a seguinte URL:

arduino
Copiar
Editar
rtmp://<seu-servidor>:1935/live
Use a streamKey retornada pela API como Stream Key no OBS.