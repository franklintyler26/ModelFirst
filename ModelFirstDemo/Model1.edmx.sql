
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/30/2025 10:45:41
-- Generated from EDMX file: C:\Users\s.franklinmanogar\source\repos\ModelFirstDemo\ModelFirstDemo\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [PizzaDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Pizzas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pizzas];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Pizzas'
CREATE TABLE [dbo].[Pizzas] (
    [PizzaID] int IDENTITY(1,1) NOT NULL,
    [PizzaName] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [Price] nvarchar(max)  NOT NULL,
    [Toppings] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Books'
CREATE TABLE [dbo].[Books] (
    [BookID] int  NOT NULL,
    [BookName] varchar(20)  NOT NULL,
    [Author] nvarchar(40)  NOT NULL,
    [Price] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [PizzaID] in table 'Pizzas'
ALTER TABLE [dbo].[Pizzas]
ADD CONSTRAINT [PK_Pizzas]
    PRIMARY KEY CLUSTERED ([PizzaID] ASC);
GO

-- Creating primary key on [BookID] in table 'Books'
ALTER TABLE [dbo].[Books]
ADD CONSTRAINT [PK_Books]
    PRIMARY KEY CLUSTERED ([BookID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------