-- PG
CREATE TABLE [funcionarios] (
	[CPF] nvarchar(11) NOT NULL UNIQUE,
	[Nome] nvarchar(67) NOT NULL UNIQUE,
	[Cargo] nvarchar(20),
	[Email] nvarchar(50) NOT NULL UNIQUE,
	[Telefone] nvarchar(15) UNIQUE,
	[Datadenascimento] date NOT NULL UNIQUE,
	[RG] nvarchar(9) NOT NULL UNIQUE,
	[Cargahoraria] nvarchar(10) UNIQUE,
	[Endereço] nvarchar(100) NOT NULL,
	[DataContratação] datetime NOT NULL UNIQUE,
	[Gênero] nvarchar(50) UNIQUE,
	PRIMARY KEY ([CPF])
);
CREATE TABLE [cliente] (
	[CPF] nvarchar(11) NOT NULL UNIQUE,
	[Nome] nvarchar(100) NOT NULL UNIQUE,
	[Email] nvarchar(100) NOT NULL UNIQUE,
	[Telefone] nvarchar(15) UNIQUE,
	[DataCadastro] datetime NOT NULL UNIQUE,
	[Gênero] nvarchar(50) UNIQUE,
	[DataNascimento] date NOT NULL UNIQUE,
	PRIMARY KEY ([CPF])
);
CREATE TABLE [produto] (
	[id_produto] int IDENTITY(1,1) NOT NULL UNIQUE,
	[Lote] nvarchar(2) NOT NULL,
	[Nome] nvarchar(5000) NOT NULL,
	[datavalidade] date NOT NULL UNIQUE,
	[codbarras] nvarchar(13) NOT NULL UNIQUE,
	[datafabircação] datetime NOT NULL UNIQUE,
	[CNPJ] int NOT NULL,
	PRIMARY KEY ([id_produto])
);
CREATE TABLE [fornecedor] (
	[CNPJ] int IDENTITY(1,1) NOT NULL UNIQUE,
	[NomeFantasia] nvarchar(35) NOT NULL UNIQUE,
	[telefone] nvarchar(15) NOT NULL,
	[Endereço] int NOT NULL,
	[Representante] nvarchar(max),
	[Nacionalidade] nvarchar(50) NOT NULL UNIQUE,
	[Emailcontato] nvarchar(30) NOT NULL,
	[Contrato] nvarchar(200) NOT NULL UNIQUE,
	PRIMARY KEY ([CNPJ])
);
ALTER TABLE [produto] ADD CONSTRAINT [produto_fk6] FOREIGN KEY ([CNPJ]) REFERENCES [fornecedor]([CNPJ]);
EXEC sys.sp_addextendedproperty @name = N'MS_Description', @value = 'PG', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = 'funcionarios';