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