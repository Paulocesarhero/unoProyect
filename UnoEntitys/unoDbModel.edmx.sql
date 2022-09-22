
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/20/2022 14:03:15
-- Generated from EDMX file: C:\Users\paulo\source\repos\unoProyect\UnoEntitys\unoDbModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [unodb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'playerSet'
CREATE TABLE [dbo].[playerSet] (
    [IdPlayer] int IDENTITY(1,1) NOT NULL,
    [wins] nvarchar(max)  NOT NULL,
    [losts] nvarchar(max)  NOT NULL,
    [player2_IdPlayer] int  NOT NULL
);
GO

-- Creating table 'credentialsSet'
CREATE TABLE [dbo].[credentialsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [password] nvarchar(max)  NOT NULL,
    [username] nvarchar(max)  NOT NULL,
    [email] nvarchar(max)  NOT NULL,
    [player_IdPlayer] int  NOT NULL
);
GO

-- Creating table 'imagesSet'
CREATE TABLE [dbo].[imagesSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [path] nvarchar(max)  NOT NULL,
    [player_IdPlayer] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdPlayer] in table 'playerSet'
ALTER TABLE [dbo].[playerSet]
ADD CONSTRAINT [PK_playerSet]
    PRIMARY KEY CLUSTERED ([IdPlayer] ASC);
GO

-- Creating primary key on [Id] in table 'credentialsSet'
ALTER TABLE [dbo].[credentialsSet]
ADD CONSTRAINT [PK_credentialsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'imagesSet'
ALTER TABLE [dbo].[imagesSet]
ADD CONSTRAINT [PK_imagesSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [player_IdPlayer] in table 'credentialsSet'
ALTER TABLE [dbo].[credentialsSet]
ADD CONSTRAINT [FK_credentialsplayer]
    FOREIGN KEY ([player_IdPlayer])
    REFERENCES [dbo].[playerSet]
        ([IdPlayer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_credentialsplayer'
CREATE INDEX [IX_FK_credentialsplayer]
ON [dbo].[credentialsSet]
    ([player_IdPlayer]);
GO

-- Creating foreign key on [player_IdPlayer] in table 'imagesSet'
ALTER TABLE [dbo].[imagesSet]
ADD CONSTRAINT [FK_imagesplayer]
    FOREIGN KEY ([player_IdPlayer])
    REFERENCES [dbo].[playerSet]
        ([IdPlayer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_imagesplayer'
CREATE INDEX [IX_FK_imagesplayer]
ON [dbo].[imagesSet]
    ([player_IdPlayer]);
GO

-- Creating foreign key on [player2_IdPlayer] in table 'playerSet'
ALTER TABLE [dbo].[playerSet]
ADD CONSTRAINT [FK_friends]
    FOREIGN KEY ([player2_IdPlayer])
    REFERENCES [dbo].[playerSet]
        ([IdPlayer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_friends'
CREATE INDEX [IX_FK_friends]
ON [dbo].[playerSet]
    ([player2_IdPlayer]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------