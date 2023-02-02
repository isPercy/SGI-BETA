
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/07/2023 17:27:12
-- Generated from EDMX file: C:\Users\jpgod\OneDrive\Escritorio\CPI Project\SGI-View\Models\sgi_bd\SGI_bd.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SGI_BD];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Inventario_CarreraEquipoUnico]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EquipoUnico] DROP CONSTRAINT [FK_Inventario_CarreraEquipoUnico];
GO
IF OBJECT_ID(N'[dbo].[FK_Tipo_ArticuloEquipoUnico]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EquipoUnico] DROP CONSTRAINT [FK_Tipo_ArticuloEquipoUnico];
GO
IF OBJECT_ID(N'[dbo].[FK_EquipoUnicoPrestamo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Prestamo] DROP CONSTRAINT [FK_EquipoUnicoPrestamo];
GO
IF OBJECT_ID(N'[dbo].[FK_PrestamoNav_EstadoPrestamo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Nav_EstadoPrestamo] DROP CONSTRAINT [FK_PrestamoNav_EstadoPrestamo];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioPrestamo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Prestamo] DROP CONSTRAINT [FK_UsuarioPrestamo];
GO
IF OBJECT_ID(N'[dbo].[FK_EstadosNav_EstadoPrestamo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Nav_EstadoPrestamo] DROP CONSTRAINT [FK_EstadosNav_EstadoPrestamo];
GO
IF OBJECT_ID(N'[dbo].[FK_Carrera_UsuarioUsuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Usuario] DROP CONSTRAINT [FK_Carrera_UsuarioUsuario];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Inventario_Carrera]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Inventario_Carrera];
GO
IF OBJECT_ID(N'[dbo].[EquipoUnico]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EquipoUnico];
GO
IF OBJECT_ID(N'[dbo].[Tipo_Articulo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tipo_Articulo];
GO
IF OBJECT_ID(N'[dbo].[Prestamo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Prestamo];
GO
IF OBJECT_ID(N'[dbo].[Nav_EstadoPrestamo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Nav_EstadoPrestamo];
GO
IF OBJECT_ID(N'[dbo].[Estados]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Estados];
GO
IF OBJECT_ID(N'[dbo].[Carrera_Usuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Carrera_Usuario];
GO
IF OBJECT_ID(N'[dbo].[Usuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuario];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Inventario_Carrera'
CREATE TABLE [dbo].[Inventario_Carrera] (
    [ID_Inventario_Carrera] int IDENTITY(1,1) NOT NULL,
    [Nom_Carrera] nvarchar(max)  NOT NULL,
    [Activo] bit  NOT NULL
);
GO

-- Creating table 'EquipoUnico'
CREATE TABLE [dbo].[EquipoUnico] (
    [ID_Serie] int  NOT NULL,
    [Activo] bit  NOT NULL,
    [Inventario_CarreraID_Inventario_Carrera] int  NOT NULL,
    [Tipo_ArticuloID_Articulo] int  NOT NULL,
    [Codigo_Serie] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Tipo_Articulo'
CREATE TABLE [dbo].[Tipo_Articulo] (
    [ID_Articulo] int IDENTITY(1,1) NOT NULL,
    [Nom_Articulo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Prestamo'
CREATE TABLE [dbo].[Prestamo] (
    [ID_Prestamo] int IDENTITY(1,1) NOT NULL,
    [Date_Entrega] datetime  NOT NULL,
    [Date_Vencimiento] datetime  NOT NULL,
    [Date_Devolucion] datetime  NOT NULL,
    [EquipoUnicoID_Serie] int  NOT NULL,
    [UsuarioID] int  NOT NULL
);
GO

-- Creating table 'Nav_EstadoPrestamo'
CREATE TABLE [dbo].[Nav_EstadoPrestamo] (
    [ID_Seguimiento_Estado] int IDENTITY(1,1) NOT NULL,
    [PrestamoID_Prestamo] int  NOT NULL,
    [EstadosID_Estado] int  NOT NULL
);
GO

-- Creating table 'Estados'
CREATE TABLE [dbo].[Estados] (
    [ID_Estado] int IDENTITY(1,1) NOT NULL,
    [Nom_Estado] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Carrera_Usuario'
CREATE TABLE [dbo].[Carrera_Usuario] (
    [ID_Carrera] int IDENTITY(1,1) NOT NULL,
    [Nom_Carerra] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Usuario'
CREATE TABLE [dbo].[Usuario] (
    [ID] int  NOT NULL,
    [Carrera_UsuarioID_Carrera] int  NOT NULL,
    [Correo] nvarchar(max)  NOT NULL,
    [Num_Cell] nvarchar(max)  NOT NULL,
    [RUT] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID_Inventario_Carrera] in table 'Inventario_Carrera'
ALTER TABLE [dbo].[Inventario_Carrera]
ADD CONSTRAINT [PK_Inventario_Carrera]
    PRIMARY KEY CLUSTERED ([ID_Inventario_Carrera] ASC);
GO

-- Creating primary key on [ID_Serie] in table 'EquipoUnico'
ALTER TABLE [dbo].[EquipoUnico]
ADD CONSTRAINT [PK_EquipoUnico]
    PRIMARY KEY CLUSTERED ([ID_Serie] ASC);
GO

-- Creating primary key on [ID_Articulo] in table 'Tipo_Articulo'
ALTER TABLE [dbo].[Tipo_Articulo]
ADD CONSTRAINT [PK_Tipo_Articulo]
    PRIMARY KEY CLUSTERED ([ID_Articulo] ASC);
GO

-- Creating primary key on [ID_Prestamo] in table 'Prestamo'
ALTER TABLE [dbo].[Prestamo]
ADD CONSTRAINT [PK_Prestamo]
    PRIMARY KEY CLUSTERED ([ID_Prestamo] ASC);
GO

-- Creating primary key on [ID_Seguimiento_Estado] in table 'Nav_EstadoPrestamo'
ALTER TABLE [dbo].[Nav_EstadoPrestamo]
ADD CONSTRAINT [PK_Nav_EstadoPrestamo]
    PRIMARY KEY CLUSTERED ([ID_Seguimiento_Estado] ASC);
GO

-- Creating primary key on [ID_Estado] in table 'Estados'
ALTER TABLE [dbo].[Estados]
ADD CONSTRAINT [PK_Estados]
    PRIMARY KEY CLUSTERED ([ID_Estado] ASC);
GO

-- Creating primary key on [ID_Carrera] in table 'Carrera_Usuario'
ALTER TABLE [dbo].[Carrera_Usuario]
ADD CONSTRAINT [PK_Carrera_Usuario]
    PRIMARY KEY CLUSTERED ([ID_Carrera] ASC);
GO

-- Creating primary key on [ID] in table 'Usuario'
ALTER TABLE [dbo].[Usuario]
ADD CONSTRAINT [PK_Usuario]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Inventario_CarreraID_Inventario_Carrera] in table 'EquipoUnico'
ALTER TABLE [dbo].[EquipoUnico]
ADD CONSTRAINT [FK_Inventario_CarreraEquipoUnico]
    FOREIGN KEY ([Inventario_CarreraID_Inventario_Carrera])
    REFERENCES [dbo].[Inventario_Carrera]
        ([ID_Inventario_Carrera])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Inventario_CarreraEquipoUnico'
CREATE INDEX [IX_FK_Inventario_CarreraEquipoUnico]
ON [dbo].[EquipoUnico]
    ([Inventario_CarreraID_Inventario_Carrera]);
GO

-- Creating foreign key on [Tipo_ArticuloID_Articulo] in table 'EquipoUnico'
ALTER TABLE [dbo].[EquipoUnico]
ADD CONSTRAINT [FK_Tipo_ArticuloEquipoUnico]
    FOREIGN KEY ([Tipo_ArticuloID_Articulo])
    REFERENCES [dbo].[Tipo_Articulo]
        ([ID_Articulo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Tipo_ArticuloEquipoUnico'
CREATE INDEX [IX_FK_Tipo_ArticuloEquipoUnico]
ON [dbo].[EquipoUnico]
    ([Tipo_ArticuloID_Articulo]);
GO

-- Creating foreign key on [EquipoUnicoID_Serie] in table 'Prestamo'
ALTER TABLE [dbo].[Prestamo]
ADD CONSTRAINT [FK_EquipoUnicoPrestamo]
    FOREIGN KEY ([EquipoUnicoID_Serie])
    REFERENCES [dbo].[EquipoUnico]
        ([ID_Serie])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EquipoUnicoPrestamo'
CREATE INDEX [IX_FK_EquipoUnicoPrestamo]
ON [dbo].[Prestamo]
    ([EquipoUnicoID_Serie]);
GO

-- Creating foreign key on [PrestamoID_Prestamo] in table 'Nav_EstadoPrestamo'
ALTER TABLE [dbo].[Nav_EstadoPrestamo]
ADD CONSTRAINT [FK_PrestamoNav_EstadoPrestamo]
    FOREIGN KEY ([PrestamoID_Prestamo])
    REFERENCES [dbo].[Prestamo]
        ([ID_Prestamo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PrestamoNav_EstadoPrestamo'
CREATE INDEX [IX_FK_PrestamoNav_EstadoPrestamo]
ON [dbo].[Nav_EstadoPrestamo]
    ([PrestamoID_Prestamo]);
GO

-- Creating foreign key on [UsuarioID] in table 'Prestamo'
ALTER TABLE [dbo].[Prestamo]
ADD CONSTRAINT [FK_UsuarioPrestamo]
    FOREIGN KEY ([UsuarioID])
    REFERENCES [dbo].[Usuario]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioPrestamo'
CREATE INDEX [IX_FK_UsuarioPrestamo]
ON [dbo].[Prestamo]
    ([UsuarioID]);
GO

-- Creating foreign key on [EstadosID_Estado] in table 'Nav_EstadoPrestamo'
ALTER TABLE [dbo].[Nav_EstadoPrestamo]
ADD CONSTRAINT [FK_EstadosNav_EstadoPrestamo]
    FOREIGN KEY ([EstadosID_Estado])
    REFERENCES [dbo].[Estados]
        ([ID_Estado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EstadosNav_EstadoPrestamo'
CREATE INDEX [IX_FK_EstadosNav_EstadoPrestamo]
ON [dbo].[Nav_EstadoPrestamo]
    ([EstadosID_Estado]);
GO

-- Creating foreign key on [Carrera_UsuarioID_Carrera] in table 'Usuario'
ALTER TABLE [dbo].[Usuario]
ADD CONSTRAINT [FK_Carrera_UsuarioUsuario]
    FOREIGN KEY ([Carrera_UsuarioID_Carrera])
    REFERENCES [dbo].[Carrera_Usuario]
        ([ID_Carrera])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Carrera_UsuarioUsuario'
CREATE INDEX [IX_FK_Carrera_UsuarioUsuario]
ON [dbo].[Usuario]
    ([Carrera_UsuarioID_Carrera]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------