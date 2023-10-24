# Sistema de Fichas em C# Windows Forms
Feito e desenvolvido por Matheus Duarte Barros

Este é um sistema de gerenciamento de fichas desenvolvido em C# com Windows Forms no Visual Studio. Ele permite registrar informações relacionadas a clientes, como ofertas, visitas técnicas agendadas e outros detalhes importantes. O projeto segue a arquitetura MVC (Model-View-Controller) e oferece operações CRUD (Create, Read, Update e Delete).

## Funcionalidades

### Autenticação de Usuário

- O sistema permite autenticação de usuário com segurança.
- Usuário padrão: "admin" com senha "admin".
- As senhas são criptografadas para garantir a segurança.

### Gerenciamento de Usuários

- Cadastro de novos usuários.
- Consulta de usuários por código, nome ou e-mail.
- Realização de operações CRUD em contas de usuário.

### Gerenciamento de Clientes

- Cadastro de clientes.
- Consulta de clientes por código, nome ou documento (CPF/CNPJ).
- Realização de operações CRUD em informações de clientes.
- Validação de CPF/CNPJ e preenchimento automático de endereço através do CEP.

### Registro de Fichas

- Cada ficha é automaticamente vinculada ao usuário que a criou.
- Consulta de fichas por código, usuário ou cliente.
- As fichas registram informações como ofertas, visitas técnicas, ou detalhes importantes sobre os clientes.

## Pré-requisitos

- Visual Studio instalado.
- Banco de dados configurado (configure as credenciais no arquivo de configuração).

## Instalação

1. Clone o repositório:

   ```bash
   git clone https://github.com/seuusuario/seuprojeto.git
