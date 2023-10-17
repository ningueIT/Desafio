# WebAPI de Pagamentos

Esta WebAPI é responsável por gerenciar transações de pagamento e é projetada para fornecer funcionalidades como consulta de saldo da conta corrente, inserção, atualização e exclusão de cartões, e validação de transações de pagamento.

## Funcionalidades

A WebAPI inclui os seguintes recursos:

- **GET:** O endpoint GET é responsável por retornar o saldo da conta corrente.

- **POST:** O endpoint POST recebe informações sobre uma transação de pagamento. Os campos obrigatórios incluem:
  - Conta Corrente
  - Número do Cartão
  - Data de Validade do Cartão
  - CVV
  - Valor da Compra
  - Data da Compra
  - Forma de Pagamento (Débito ou Crédito)

  A API valida a existência de dados de conta e saldo suficiente antes de aprovar a transação. Caso haja saldo suficiente, a transação é aprovada e uma mensagem de sucesso é retornada ao front-end. Caso contrário, a transação é rejeitada.

- **PUT:** O endpoint PUT permite a atualização dos dados de um cartão.

- **DELETE:** O endpoint DELETE é usado para excluir um cartão.

## Estrutura do Banco de Dados

Para implementar essas funcionalidades, as seguintes tabelas são necessárias:

- Tabela Pessoa: Armazena informações sobre as pessoas.

- Tabela Conta Corrente: Registra as contas correntes e seus saldos.

- Tabela Cartão: Mantém os detalhes dos cartões associados às contas.

- Tabela Saldo: Armazena informações de saldo da conta corrente.

- Tabela Hist_Transacao: Registra todas as transações, independentemente de serem aprovadas ou não.

Os relacionamentos entre essas tabelas devem ser estabelecidos de forma criativa para atender aos requisitos do sistema.

## Exemplo de Uso

Aqui está um exemplo de como usar os endpoints da WebAPI:

1. Consulta de saldo da conta corrente:

GET /api/contacorrente/saldo

2. Inserir uma nova transação de pagamento:

POST /api/pagamentos
Body da solicitação:
{
"ContaCorrente": "1234567890",
"NumeroCartao": "**** **** **** 1234",
"DataValidadeCartao": "12/25",
"CVV": "123",
"ValorCompra": 100.00,
"DataCompra": "2023-10-17",
"FormaPagamento": "Débito"
}

3. Atualizar dados de um cartão:
PUT /api/cartoes/atualizar/123
Body da solicitação:
{
"NumeroCartao": "**** **** **** 5678",
"DataValidadeCartao": "12/26"
}

4. Excluir um cartão:

DELETE /api/cartoes/excluir/123

## Conclusão

Esta WebAPI fornece funcionalidades de pagamento e gerenciamento de cartões, bem como registro de transações. Certifique-se de configurar adequadamente as tabelas e relacionamentos no banco de dados para que a API funcione conforme esperado.

Sinta-se à vontade para personalizar este README conforme necessário e fornecer informações adicionais sobre como configurar e implantar a WebAPI, bem como outros detalhes relevantes.
