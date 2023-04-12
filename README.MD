# MiniPloomes-API

>REST API com endpoint para leitura e cadastro de usuários e clientes

   
## Usuario

#### `GET /api/Usuario/GetUsuarios`

*Listar todos os usuários.*

  

> Body parameter - No parameter

  

*Exemplo de retorno:*

>Status code: 200

```json
{
  "data": [
    {
      "emailUsuario": "teste@gmail.com",
      "nomeUsuario": "teste"
    },
    {
      "emailUsuario": "teste2@gmail.com",
      "nomeUsuario": "teste2"
    }
  ],
  "friendlyErrorMessage": null,
  "message": null,
  "stackTrace": null
}
```

| Status | Meaning                                                          | Description | Schema                        |
| ------ | ---------------------------------------------------------------- | ----------- | ----------------------------- |
| 200    | OK     | Success     | vmResult       |
| 400    | Bad Request | Bad Request | vmResult |


#### `POST /api/Usuario/InsertUsuario`

*Inserir um usuário.*

> Body parameter


| Name     | In    | Type           | Description                                                                                   |
| -------- | ----- | -------------- |  --------------------------------------------------------------------------------------------- |
| emailUsuario     | query | string | E-mail do usuário.                                                                              |
| nomeUsuario | query | string |  Nome do usuário.                                                                                |

*Exemplo de retorno:*

>Status code: 200

```json
{
  "data": {
    "emailUsuario": "teste3@gmail.com",
    "nomeUsuario": "teste"
  },
  "friendlyErrorMessage": null,
  "message": "Registro inserido com sucesso!",
  "stackTrace": null
}
```

| Status | Meaning                                                          | Description | Schema                        |
| ------ | ---------------------------------------------------------------- | ----------- | ----------------------------- |
| 200    | OK     | Success     | vmResult       |
| 400    | Bad Request | Bad Request | vmResult |


## Cliente

#### `GET /api/Cliente/GetClientes`

*Listar todos os clientes.*

  
> Body parameter - No parameter

  
*Exemplo de retorno:*

>Status code: 200

```json
{
  "data": [
    {
      "idCliente": 1,
      "emailUsuario": "teste@gmail.com",
      "nomeCliente": "douglas",
      "dataCriacaoUsuario": "2023-04-12T17:45:40.067"
    },
    {
      "idCliente": 2,
      "emailUsuario": "teste@gmail.com",
      "nomeCliente": "teste",
      "dataCriacaoUsuario": "2023-04-12T19:56:17.283"
    }
  ],
  "friendlyErrorMessage": null,
  "message": null,
  "stackTrace": null
}
```

| Status | Meaning                                                          | Description | Schema                        |
| ------ | ---------------------------------------------------------------- | ----------- | ----------------------------- |
| 200    | OK     | Success     | vmResult       |
| 400    | Bad Request | Bad Request | vmResult |


#### `POST /api/Cliente/InsertCliente`

*Inserir um cliente.*

> Body parameter


| Name     | In    | Type           | Description                                                                                   |
| -------- | ----- | -------------- |  --------------------------------------------------------------------------------------------- |
| emailUsuario     | query | string | E-mail do usuário.                                                                              |
| nomeCliente | query | string |  Nome do cliente.                                                                                |

*Exemplo de retorno:*

>Status code: 200

```json
{
  "data": {
    "emailUsuario": "teste3@gmail.com",
    "nomeCliente": "teste3"
  },
  "friendlyErrorMessage": null,
  "message": "Registro inserido com sucesso!",
  "stackTrace": null
}
```

| Status | Meaning                                                          | Description | Schema                        |
| ------ | ---------------------------------------------------------------- | ----------- | ----------------------------- |
| 200    | OK     | Success     | vmResult       |
| 400    | Bad Request | Bad Request | vmResult |