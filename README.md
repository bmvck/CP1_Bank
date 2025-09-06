# 🏦 CP1 - Sistema Bancário - WebAPI

## 📋 Informações do Grupo

**Disciplina**: CP1 — Modelo Entidade-Relacionamento (MER) e Criação do Projeto WebAPI  
**Curso**: FIAP Software Engineering  
**Período**: 2025  

### 👥 Integrantes do Grupo
- **Nome**: Édipo Borges de Carvalho - **RM**: RM 567164
- **Nome**: Guilherme Jun Conheci - **RM**: RM 559986  

## 🎯 Domínio Escolhido

**Sistema Bancário** - Gerenciamento de agências, clientes, contas, transações e titularidade de contas.

## 🏗️ Entidades Modeladas

### 1. Branch (Agência)
- **PK**: `BranchId` (GUID)
- **Atributos**: 
  - `Code` (string, obrigatório) - Código da agência
  - `Name` (string, obrigatório) - Nome da agência
  - `Address` (string, opcional) - Endereço da agência

### 2. Customer (Cliente)
- **PK**: `CustomerId` (GUID)
- **Atributos**:
  - `Name` (string, obrigatório) - Nome completo
  - `CPF` (string, obrigatório, único) - CPF do cliente
  - `Email` (string, opcional) - Email com validação
  - `Phone` (string, opcional) - Telefone

### 3. Account (Conta)
- **PK**: `AccountId` (GUID)
- **FK**: `BranchId` (GUID, obrigatório)
- **Atributos**:
  - `Number` (string, obrigatório, único) - Número da conta
  - `Type` (AccountType, obrigatório) - Tipo: Corrente/Poupança
  - `OpenedAt` (DateTime, obrigatório) - Data de abertura
  - `Status` (AccountStatus, obrigatório) - Status: Active/Blocked/Closed

### 4. Transaction (Transação)
- **PK**: `TransactionId` (GUID)
- **FK**: `AccountId` (GUID, obrigatório)
- **Atributos**:
  - `Type` (TransactionType, obrigatório) - Tipo: Credit/Debit
  - `Amount` (decimal, obrigatório) - Valor da transação
  - `PerformedAt` (DateTime, obrigatório) - Data/hora da transação
  - `Description` (string, opcional) - Descrição da transação

### 5. AccountHolder (Titularidade)
- **PK Composta**: `AccountId` + `CustomerId` (GUID)
- **Atributos**:
  - `Role` (AccountHolderRole, obrigatório) - Papel: PRIMARY/JOINT
  - `Since` (DateTime, opcional) - Data desde quando é titular

## 🔗 Resumo dos Relacionamentos

### Cardinalidades
1. **Branch 1:N Account**
   - Uma agência tem muitas contas
   - Toda conta pertence a uma agência (obrigatório)

2. **Account 1:N Transaction**
   - Uma conta tem muitas transações
   - Toda transação pertence a uma conta (obrigatório)

3. **Customer N:N Account (via AccountHolder)**
   - Um cliente pode ter várias contas (0..N)
   - Uma conta pode ter vários titulares (1..N)
   - Mínimo 1 titular por conta

### Opcionalidade
- **Branch → Account**: Obrigatório (Account.BranchId required)
- **Account → Transaction**: Obrigatório (Transaction.AccountId required)
- **Customer → AccountHolder**: Opcional (cliente pode não ter conta)
- **Account → AccountHolder**: Obrigatório (conta deve ter pelo menos 1 titular)

## 🛠️ Tecnologias Utilizadas

- **.NET 8** - Framework principal
- **ASP.NET Core WebAPI** - Estrutura da API
- **C#** - Linguagem de programação
- **Data Annotations** - Validações e configurações
- **Swagger/OpenAPI** - Documentação da API

## 📁 Estrutura do Projeto

```
CP1_Bank/
├── Entities/                    # Entidades do domínio
│   ├── Branch.cs               # Entidade Agência
│   ├── Customer.cs             # Entidade Cliente
│   ├── Account.cs              # Entidade Conta
│   ├── Transaction.cs          # Entidade Transação
│   └── AccountHolder.cs        # Entidade Titularidade
├── Models/                     # Enums e modelos auxiliares
│   ├── AccountType.cs          # Enum tipos de conta
│   ├── AccountStatus.cs        # Enum status da conta
│   ├── TransactionType.cs      # Enum tipos de transação
│   └── AccountHolderRole.cs    # Enum papéis do titular
├── Program.cs                  # Configuração da WebAPI
├── CP1_Bank.csproj            # Arquivo do projeto
└── README.md                  # Este arquivo
```

## 🚀 Como Executar

1. **Pré-requisitos**:
   - .NET 8 SDK instalado
   - Visual Studio 2022 ou VS Code

2. **Execução**:
   ```bash
   dotnet restore
   dotnet build
   dotnet run
   ```

3. **Acesso**:
   - API: `https://localhost:7000`
   - Swagger: `https://localhost:7000/swagger`

## 📊 Características da Implementação

### ✅ Implementado
- ✅ Estrutura WebAPI em .NET 8
- ✅ 5 entidades modeladas com validações
- ✅ 4 enums para tipagem forte
- ✅ Relacionamentos configurados
- ✅ Data Annotations para validação
- ✅ Propriedades de navegação
- ✅ Documentação completa

### ❌ Não Implementado (Conforme Restrições)
- ❌ CRUD operations
- ❌ Controllers
- ❌ Endpoints
- ❌ Entity Framework Core
- ❌ Migrations
- ❌ Banco de dados

## 📝 Observações

- **Foco**: Apenas modelagem de entidades e estrutura do projeto
- **Escalabilidade**: Código preparado para futuras implementações
- **Manutenibilidade**: Estrutura bem organizada e documentada
- **Extensibilidade**: Fácil adição de novas funcionalidades

---

**Desenvolvido para o CP1 - FIAP Software Engineering 2025**
