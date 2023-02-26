
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/22/2023 22:40:51
-- Generated from EDMX file: C:\Users\jpgod\OneDrive\Escritorio\SGI-View\Models\BD\Model_BD.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BD_CPI];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Tipo_ArticuloEquipoUnico]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EquipoUnico] DROP CONSTRAINT [FK_Tipo_ArticuloEquipoUnico];
GO
IF OBJECT_ID(N'[dbo].[FK_Inventario_LabEquipoUnico]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EquipoUnico] DROP CONSTRAINT [FK_Inventario_LabEquipoUnico];
GO
IF OBJECT_ID(N'[dbo].[FK_EquipoUnicoPrestamo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Prestamo] DROP CONSTRAINT [FK_EquipoUnicoPrestamo];
GO
IF OBJECT_ID(N'[dbo].[FK_Carrera_UsuarioUsuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Usuario] DROP CONSTRAINT [FK_Carrera_UsuarioUsuario];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioPrestamo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Prestamo] DROP CONSTRAINT [FK_UsuarioPrestamo];
GO
IF OBJECT_ID(N'[dbo].[FK_PrestamoRegistro_Estados]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Registro_EstadosSet] DROP CONSTRAINT [FK_PrestamoRegistro_Estados];
GO
IF OBJECT_ID(N'[dbo].[FK_EstadosRegistro_Estados]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Registro_EstadosSet] DROP CONSTRAINT [FK_EstadosRegistro_Estados];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[EquipoUnico]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EquipoUnico];
GO
IF OBJECT_ID(N'[dbo].[Tipo_Articulo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tipo_Articulo];
GO
IF OBJECT_ID(N'[dbo].[Inventario_Lab]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Inventario_Lab];
GO
IF OBJECT_ID(N'[dbo].[Prestamo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Prestamo];
GO
IF OBJECT_ID(N'[dbo].[Usuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuario];
GO
IF OBJECT_ID(N'[dbo].[Carrera_Usuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Carrera_Usuario];
GO
IF OBJECT_ID(N'[dbo].[Registro_EstadosSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Registro_EstadosSet];
GO
IF OBJECT_ID(N'[dbo].[Estados]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Estados];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'EquipoUnico'
CREATE TABLE [dbo].[EquipoUnico] (
    [ID_Equipo] int IDENTITY(1,1) NOT NULL,
    [Num_Serie] nvarchar(max)  NOT NULL,
    [Activo] bit  NOT NULL,
    [Tipo_ArticuloID_Articulo] int  NOT NULL,
    [Inventario_LabID_Lab] int  NOT NULL
);
GO

-- Creating table 'Tipo_Articulo'
CREATE TABLE [dbo].[Tipo_Articulo] (
    [ID_Articulo] int IDENTITY(1,1) NOT NULL,
    [Nom_Articulo] nvarchar(max)  NOT NULL,
    [Activo] bit  NOT NULL
);
GO

-- Creating table 'Inventario_Lab'
CREATE TABLE [dbo].[Inventario_Lab] (
    [ID_Lab] int IDENTITY(1,1) NOT NULL,
    [Nom_Lab] nvarchar(max)  NOT NULL,
    [Activo] bit  NOT NULL
);
GO

-- Creating table 'Prestamo'
CREATE TABLE [dbo].[Prestamo] (
    [ID_Prestamo] int IDENTITY(1,1) NOT NULL,
    [EquipoUnicoID_Equipo] int  NOT NULL,
    [UsuarioID_User] int  NOT NULL,
    [Date_Entrega] datetime  NOT NULL,
    [Date_Vencimiento] datetime  NOT NULL
);
GO

-- Creating table 'Usuario'
CREATE TABLE [dbo].[Usuario] (
    [ID_User] int IDENTITY(1,1) NOT NULL,
    [RUT] nvarchar(max)  NOT NULL,
    [Correo] nvarchar(max)  NOT NULL,
    [Celular] nvarchar(max)  NOT NULL,
    [Carrera_UsuarioID_Carrera] int  NOT NULL,
    [Nom_Usuario] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Carrera_Usuario'
CREATE TABLE [dbo].[Carrera_Usuario] (
    [ID_Carrera] int IDENTITY(1,1) NOT NULL,
    [Nom_Carrera] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Registro_EstadosSet'
CREATE TABLE [dbo].[Registro_EstadosSet] (
    [ID_Reg_Est] int IDENTITY(1,1) NOT NULL,
    [PrestamoID_Prestamo] int  NOT NULL,
    [EstadosID_Estado] int  NOT NULL,
    [Date_Registro] datetime  NOT NULL
);
GO

-- Creating table 'Estados'
CREATE TABLE [dbo].[Estados] (
    [ID_Estado] int IDENTITY(1,1) NOT NULL,
    [Nom_Estado] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID_Equipo] in table 'EquipoUnico'
ALTER TABLE [dbo].[EquipoUnico]
ADD CONSTRAINT [PK_EquipoUnico]
    PRIMARY KEY CLUSTERED ([ID_Equipo] ASC);
GO

-- Creating primary key on [ID_Articulo] in table 'Tipo_Articulo'
ALTER TABLE [dbo].[Tipo_Articulo]
ADD CONSTRAINT [PK_Tipo_Articulo]
    PRIMARY KEY CLUSTERED ([ID_Articulo] ASC);
GO

-- Creating primary key on [ID_Lab] in table 'Inventario_Lab'
ALTER TABLE [dbo].[Inventario_Lab]
ADD CONSTRAINT [PK_Inventario_Lab]
    PRIMARY KEY CLUSTERED ([ID_Lab] ASC);
GO

-- Creating primary key on [ID_Prestamo] in table 'Prestamo'
ALTER TABLE [dbo].[Prestamo]
ADD CONSTRAINT [PK_Prestamo]
    PRIMARY KEY CLUSTERED ([ID_Prestamo] ASC);
GO

-- Creating primary key on [ID_User] in table 'Usuario'
ALTER TABLE [dbo].[Usuario]
ADD CONSTRAINT [PK_Usuario]
    PRIMARY KEY CLUSTERED ([ID_User] ASC);
GO

-- Creating primary key on [ID_Carrera] in table 'Carrera_Usuario'
ALTER TABLE [dbo].[Carrera_Usuario]
ADD CONSTRAINT [PK_Carrera_Usuario]
    PRIMARY KEY CLUSTERED ([ID_Carrera] ASC);
GO

-- Creating primary key on [ID_Reg_Est] in table 'Registro_EstadosSet'
ALTER TABLE [dbo].[Registro_EstadosSet]
ADD CONSTRAINT [PK_Registro_EstadosSet]
    PRIMARY KEY CLUSTERED ([ID_Reg_Est] ASC);
GO

-- Creating primary key on [ID_Estado] in table 'Estados'
ALTER TABLE [dbo].[Estados]
ADD CONSTRAINT [PK_Estados]
    PRIMARY KEY CLUSTERED ([ID_Estado] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

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

-- Creating foreign key on [Inventario_LabID_Lab] in table 'EquipoUnico'
ALTER TABLE [dbo].[EquipoUnico]
ADD CONSTRAINT [FK_Inventario_LabEquipoUnico]
    FOREIGN KEY ([Inventario_LabID_Lab])
    REFERENCES [dbo].[Inventario_Lab]
        ([ID_Lab])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Inventario_LabEquipoUnico'
CREATE INDEX [IX_FK_Inventario_LabEquipoUnico]
ON [dbo].[EquipoUnico]
    ([Inventario_LabID_Lab]);
GO

-- Creating foreign key on [EquipoUnicoID_Equipo] in table 'Prestamo'
ALTER TABLE [dbo].[Prestamo]
ADD CONSTRAINT [FK_EquipoUnicoPrestamo]
    FOREIGN KEY ([EquipoUnicoID_Equipo])
    REFERENCES [dbo].[EquipoUnico]
        ([ID_Equipo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EquipoUnicoPrestamo'
CREATE INDEX [IX_FK_EquipoUnicoPrestamo]
ON [dbo].[Prestamo]
    ([EquipoUnicoID_Equipo]);
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

-- Creating foreign key on [UsuarioID_User] in table 'Prestamo'
ALTER TABLE [dbo].[Prestamo]
ADD CONSTRAINT [FK_UsuarioPrestamo]
    FOREIGN KEY ([UsuarioID_User])
    REFERENCES [dbo].[Usuario]
        ([ID_User])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioPrestamo'
CREATE INDEX [IX_FK_UsuarioPrestamo]
ON [dbo].[Prestamo]
    ([UsuarioID_User]);
GO

-- Creating foreign key on [PrestamoID_Prestamo] in table 'Registro_EstadosSet'
ALTER TABLE [dbo].[Registro_EstadosSet]
ADD CONSTRAINT [FK_PrestamoRegistro_Estados]
    FOREIGN KEY ([PrestamoID_Prestamo])
    REFERENCES [dbo].[Prestamo]
        ([ID_Prestamo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PrestamoRegistro_Estados'
CREATE INDEX [IX_FK_PrestamoRegistro_Estados]
ON [dbo].[Registro_EstadosSet]
    ([PrestamoID_Prestamo]);
GO

-- Creating foreign key on [EstadosID_Estado] in table 'Registro_EstadosSet'
ALTER TABLE [dbo].[Registro_EstadosSet]
ADD CONSTRAINT [FK_EstadosRegistro_Estados]
    FOREIGN KEY ([EstadosID_Estado])
    REFERENCES [dbo].[Estados]
        ([ID_Estado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EstadosRegistro_Estados'
CREATE INDEX [IX_FK_EstadosRegistro_Estados]
ON [dbo].[Registro_EstadosSet]
    ([EstadosID_Estado]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------