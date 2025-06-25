# 📺 ShareTV - Plataforma de Streaming

Backend desenvolvido em **.NET 8** com **Entity Framework Core** e **SQLite**. A API possui os seguintes endpoints para gerenciamento de lives:

---

## Endpoints

### Criar nova live

`POST /api/stream/create`

Cria uma nova live com título, descrição e gera uma chave única para streaming.

**Exemplo de requisição JSON:**

```json
{
  "title": "Live com Matheus",
  "description": "Primeira transmissão de teste"
}
```

**Resposta JSON:**

```json
{
  "id": 1,
  "streamKey": "b1dc7351-f324-41bc-984b-c3a2bfa5fdab",
  "title": "Live com Matheus",
  "description": "Primeira transmissão de teste",
  "createdAt": "2025-06-25T18:30:00Z",
  "isLive": false
}
```

---

### Listar lives cadastradas

`GET /api/stream`

Retorna a lista de lives cadastradas.

**Exemplo de resposta JSON:**

```json
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
```

---

## Modelo de Dados: `LiveStream`

| Campo       | Tipo      | Descrição                              |
|-------------|-----------|--------------------------------------|
| `id`        | int       | Identificador único da live           |
| `streamKey` | string    | Chave única para envio via OBS        |
| `title`     | string    | Título da live                        |
| `description` | string  | Descrição opcional da live            |
| `createdAt` | DateTime  | Data e hora da criação da live        |
| `isLive`    | bool      | Status da transmissão (online/offline)|

---

## Setup do Projeto

1. Criar projeto Web API:

   ```bash
   dotnet new webapi -n StreamPlatform.API
   ```

2. Instalar dependências:

   ```bash
   dotnet add package Microsoft.EntityFrameworkCore.Sqlite
   dotnet add package Microsoft.EntityFrameworkCore.Tools
   ```

3. Criar e aplicar migração inicial:

   ```bash
   dotnet ef migrations add Initial
   dotnet ef database update
   ```

4. Rodar o projeto:

   ```bash
   dotnet run
   ```

---

## Integração com OBS

Para enviar vídeo ao vivo para o servidor RTMP, configure o OBS com a URL:

```
rtmp://<seu-servidor>:1935/live
```

Use a `streamKey` retornada pela API como **Stream Key** no OBS.

---

Seja bem-vindo(a) ao **ShareTV**! 🚀  
Quer ajudar no projeto? Sinta-se à vontade para contribuir!
