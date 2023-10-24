# Sistema de Fichas em C# Windows Forms
Feito e desenvolvido por Matheus Duarte Barros

Este é um sistema de gerenciamento de fichas desenvolvido em C# com Windows Forms no Visual Studio. Ele permite registrar informações relacionadas a clientes, como ofertas, visitas técnicas agendadas e outros detalhes importantes. O projeto segue a arquitetura MVC (Model-View-Controller) e oferece operações CRUD (Create, Read, Update e Delete).

## Funcionalidades

### Autenticação de Usuário

- O sistema permite autenticação de usuário com segurança.
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
2. Script do Banco de dados. SQL SERVER

CREATE TABLE [dbo].[Usuarios] (
    [Id]             INT           IDENTITY (1, 1) NOT NULL,
    [Nome]           NVARCHAR (55) NOT NULL,
    [Sobrenome]      NVARCHAR (55) NOT NULL,
    [Email]          NVARCHAR (55) NOT NULL,
    [Senha]          NVARCHAR (20) NOT NULL,
    [Usuario]        NVARCHAR (55) NULL,
    [Perfil]         NVARCHAR (50) NOT NULL,
    [Status]         NVARCHAR (20) NOT NULL,
    [DataCadastro]   DATETIME      NULL,
    [DataNascimento] DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT UQ_Usuarios_Usuario UNIQUE ([Usuario])
);
CREATE TABLE [dbo].[Clientes] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [Nome]      NVARCHAR (55)  NOT NULL,
    [Documento] NVARCHAR (20)  NOT NULL,
    [Telefone]  NVARCHAR (15)  NOT NULL,
    [Email]     NVARCHAR (55)  NOT NULL,
    [Cep]       NVARCHAR (10)  NOT NULL,
	[Cidade]    NVARCHAR (100)  NOT NULL,
	[Bairro]    NVARCHAR (100)  NOT NULL,
    [Logradouro]  NVARCHAR (100) NOT NULL,
	[Uf]    NVARCHAR (3)  NOT NULL,
    [Numero]    INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
CREATE TABLE [dbo].[Fichas] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [ClienteId]   INT             NOT NULL,
    [UsuarioId]   INT             NOT NULL,
    [DataCriacao] DATETIME        NULL,
    [Descricao]   NVARCHAR (1500) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([ClienteId]) REFERENCES [dbo].[Clientes] ([Id]),
    FOREIGN KEY ([UsuarioId]) REFERENCES [dbo].[Usuarios] ([Id])
);
