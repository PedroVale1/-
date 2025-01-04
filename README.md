# 📦 Product Catalog API

Este projeto é uma API RESTful criada usando **ASP.NET Core**, que permite gerenciar um catálogo de produtos. A API oferece funcionalidades para criar, listar e buscar produtos por ID, além de permitir a ordenação dos produtos com base no preço.

---

## 🚀 Funcionalidades
1. **Criar um Produto**: Adiciona um novo produto ao banco de dados.
2. **Listar Produtos**: Retorna todos os produtos do catálogo, com a opção de ordená-los por preço.
3. **Buscar Produto por ID**: Permite a busca de um produto específico através de seu ID.

> **OBS**: O método usado para testar a API foi o **Postman**. As fotos de exemplo estão incluídas abaixo.

---

## 📝 Endpoints

### 1️⃣ Criar Produto

- **URL**: `/create`
- **Método**: `POST`
- **Descrição**: Este endpoint permite a criação de um novo produto no banco de dados. O produto é criado a partir das informações fornecidas no corpo da requisição.

#### Corpo da Requisição
A requisição deve enviar um JSON contendo as informações do produto a ser criado.

**Exemplo de corpo**:

```json
{
  "Name": "Produto Exemplo",
  "Description": "Descrição do produto",
  "Price": 100.0
}
Respostas
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

Exemplo de requisição com curl:
bash
Copiar código
curl -X POST http://localhost:5000/create -H "Content-Type: application/json" -d '{
  "Name": "Produto Exemplo",
  "Description": "Descrição do produto",
  "Price": 100.0
}'
```

![image](https://github.com/user-attachments/assets/4da45581-b780-427e-9abe-6d3846598071)


### 2️⃣ Listar Produtos (v1)
URL: /v1/products
Método: GET
Descrição: Este endpoint retorna todos os produtos do catálogo.
Respostas
200 OK: Retorna a lista de produtos.

![image](https://github.com/user-attachments/assets/c0382796-f814-4de1-9249-8a9240fdc22e)


Exemplo de resposta:

``` json
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

Exemplo de requisição com curl:
bash
Copiar código
curl -X GET http://localhost:5000/v1/products
```

### 3️⃣ Listar Produtos (v2) - Ordenado por Preço
URL: /v2/products
Método: GET
Descrição: Este endpoint retorna todos os produtos do catálogo, ordenados pelo preço de forma crescente.
Respostas
200 OK: Retorna a lista de produtos ordenada por preço.

![image](https://github.com/user-attachments/assets/193efccc-389a-4438-b6e8-1d8aa5b1f38f)


Exemplo de resposta:

``` json
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

Exemplo de requisição com curl:
bash
Copiar código
curl -X GET http://localhost:5000/v2/products
```

### 4️⃣ Buscar Produto por ID
URL: /products/{id}
Método: GET
Descrição: Este endpoint permite buscar um produto específico pelo seu ID.
Respostas
200 OK: Retorna o produto encontrado.

![image](https://github.com/user-attachments/assets/67667197-f9ec-457a-92c1-42c06aab2154)


Exemplo de resposta:

```json
Copiar código
{
  "id": 1,
  "name": "Produto Exemplo",
  "description": "Descrição do produto",
  "price": 100.0
}
404 Not Found: Caso o produto com o ID fornecido não seja encontrado.

Exemplo de requisição com curl:
bash
Copiar código
curl -X GET http://localhost:5000/products/1
```

### 🛠️ Tecnologias Usadas
ASP.NET Core: Framework para desenvolvimento de APIs.
Entity Framework Core: ORM para interação com o banco de dados.
Docker: Para containers.
Azure: Para deployment na nuvem.
SQL Server (ou outro banco de dados de sua escolha): Banco de dados utilizado para armazenar os produtos.


### 📚 Referências
Documentação do ASP.NET Core
Documentação do Entity Framework Core
