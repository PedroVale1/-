# 📦 Product Catalog API

Este projeto é uma API RESTful criada usando ASP.NET Core, que permite gerenciar um catálogo de produtos. A API oferece funcionalidades para criar, listar e buscar produtos por ID, além de permitir a ordenação dos produtos com base no preço.

## 🚀 Funcionalidades

- **Criar um Produto**: Adiciona um novo produto ao banco de dados.
- **Listar Produtos**: Retorna todos os produtos do catálogo, com a opção de ordená-los por preço.
- **Buscar Produto por ID**: Permite a busca de um produto específico através de seu ID.

- **OBS**: Método usado para testar API foi o postman como está as fotos de exemplo.

---

## 1️⃣ Criar Produto

**URL**: `/create`  
**Método**: `POST`  

Este endpoint permite a criação de um novo produto no banco de dados. O produto é criado a partir das informações fornecidas no corpo da requisição.

### 📝 Corpo da Requisição

A requisição deve enviar um JSON contendo as informações do produto a ser criado. Exemplo de corpo:

```json
{
  "Name": "Produto Exemplo",
  "Description": "Descrição do produto",
  "Price": 100.0
}

💬 Respostas
201 Created: Produto criado com sucesso.
Exemplo de resposta:

json
Copiar código
{
  "id": 1,
  "name": "Produto Exemplo",
  "description": "Descrição do produto",
  "price": 100.0
}
400 Bad Request: Caso o modelo de dados fornecido seja inválido ou algum dos campos obrigatórios esteja ausente.

💡 Exemplo de requisição com curl:
bash
Copiar código
curl -X POST http://localhost:5000/create -H "Content-Type: application/json" -d '{
  "Name": "Produto Exemplo",
  "Description": "Descrição do produto",
  "Price": 100.0
}'

![image](https://github.com/user-attachments/assets/d564e6e5-30a5-422e-a72b-d0800d2fe9ae)


2️⃣ Listar Produtos (v1)
URL: /v1/products
Método: GET

Este endpoint retorna todos os produtos do catálogo.

![image](https://github.com/user-attachments/assets/3c295d9c-d401-42f0-85fe-15567c142e46)


💬 Respostas
200 OK: Retorna a lista de produtos.
Exemplo de resposta:

json
Copiar código
[
  {
    "id": 1,
    "name": "Produto Exemplo 1",
    "description": "Descrição do produto 1",
    "price": 100.0
  },
  {
    "id": 2,
    "name": "Produto Exemplo 2",
    "description": "Descrição do produto 2",
    "price": 200.0
  }
]
500 Internal Server Error: Caso ocorra um erro no servidor.

💡 Exemplo de requisição com curl:
bash
Copiar código
curl -X GET http://localhost:5000/v1/products
3️⃣ Listar Produtos (v2) - Ordenado por Preço
URL: /v2/products
Método: GET
Este endpoint retorna todos os produtos do catálogo, ordenados pelo preço de forma crescente.

![image](https://github.com/user-attachments/assets/5c8f6dfb-9551-4c01-9878-7cad0dee2986)

💬 Respostas
200 OK: Retorna a lista de produtos ordenada por preço.
Exemplo de resposta:

json
Copiar código
[
  {
    "id": 1,
    "name": "Produto Exemplo 1",
    "description": "Descrição do produto 1",
    "price": 50.0
  },
  {
    "id": 2,
    "name": "Produto Exemplo 2",
    "description": "Descrição do produto 2",
    "price": 150.0
  }
]
500 Internal Server Error: Caso ocorra um erro no servidor.

💡 Exemplo de requisição com curl:
bash
Copiar código
curl -X GET http://localhost:5000/v2/products
4️⃣ Buscar Produto por ID
URL: [/localhost/port/{id}]
Método: GET

Este endpoint permite buscar um produto específico pelo seu ID.
![image](https://github.com/user-attachments/assets/dccbd6ea-83f3-4cd3-b11d-cc1102f935fc)


💬 Respostas
200 OK: Retorna o produto encontrado.
Exemplo de resposta:

json
Copiar código
{
  "id": 1,
  "name": "Produto Exemplo",
  "description": "Descrição do produto",
  "price": 100.0
}
404 Not Found: Caso o produto com o ID fornecido não seja encontrado.

💡 Exemplo de requisição com curl:
bash
Copiar código
curl -X GET http://localhost:5000/1
🛠️ Tecnologias Usadas
ASP.NET Core: Framework para desenvolvimento de APIs.
Entity Framework Core: ORM para interação com o banco de dados.
SQLite (ou outro banco de dados de sua escolha): Banco de dados utilizado para armazenar os produtos.
📚 Referências
Documentação do ASP.NET Core
Documentação do Entity Framework Core
