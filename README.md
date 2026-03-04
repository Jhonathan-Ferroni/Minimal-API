# Minimal API – API CRUD em ASP.NET Core

Uma API REST simples desenvolvida com **ASP.NET Core Minimal API** para realizar operações CRUD (Create, Read, Update, Delete) em uma entidade (como alunos/estudantes).  
Essa API foi criada como parte dos estudos e prática em desenvolvimento backend com .NET.

---

## 🚀 Visão Geral

Este projeto implementa uma **API minimalista** usando os recursos mais simples e diretos do .NET para criar endpoints HTTP. O foco principal é facilitar o entendimento da estrutura de uma API sem a complexidade de controladores tradicionais. :contentReference[oaicite:2]{index=2}

---

## 🛠️ Funcionalidades

✔ Operações básicas de CRUD:  
- Listar todos os registros  
- Buscar por ID  
- Criar um novo registro  
- Atualizar um registro  
- Deletar um registro

✔ Organização de projeto para aprendizado  
✔ Utiliza migrations com Entity Framework (se aplicável)  
✔ Estrutura enxuta e fácil de entender

---

## 📋 Pré-requisitos

Antes de rodar o projeto, você precisa ter instalado:

- [.NET 7 ou superior](https://dotnet.microsoft.com/)
- (Opcional) Um cliente HTTP como **Postman** ou **Insomnia** para testar os endpoints

---

## 🚀 Como executar o projeto

1. **Clone o repositório:**

```bash
git clone https://github.com/Jhonathan-Ferroni/Minimal-API.git
````

2. **Entre na pasta do projeto:**

```bash
cd Minimal-API
```

3. **Instale as dependências e rode:**

```bash
dotnet restore
dotnet run
```

4. **Abra no navegador ou no Postman:**

```
http://localhost:5000
```

---

## 📦 Exemplos de Requests

### GET — Listar todos

```
GET /estudantes
```

### POST — Criar novo registro

```
POST /estudantes
Content-Type: application/json

{
  "nome": "Jhonathan",
  "idade": 19
}
```

---

## 🧠 Estrutura do Projeto

Você encontrará:

```
Program.cs
Data/                # Pasta de acesso a dados (se estiver usando EF)
Estudantes/          # Model da entidade Estudante
Migrations/          # Migrations (se houver)
Properties/
appsettings.json
```

> A organização é simples para facilitar seu estudo e evolução da API.

---

## 📄 Licença

Este projeto está aberto para aprendizado e uso pessoal.

---

## 🛠️ Tecnologias usadas

| Tecnologia | Versão |
| ---------- | ------ |
| .NET       | 7+     |
| C#         | 10+    |

---

Feito por **Jhonathan Ferroni** ✨
