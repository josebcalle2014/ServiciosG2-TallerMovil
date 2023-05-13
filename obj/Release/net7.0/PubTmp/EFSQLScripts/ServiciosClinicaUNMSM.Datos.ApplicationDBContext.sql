IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230511235856_AgregarBaseDatos')
BEGIN
    CREATE TABLE [Usuarios] (
        [id_usuario] int NOT NULL IDENTITY,
        [nombre] nvarchar(30) NOT NULL,
        [apellidoPaterno] nvarchar(30) NOT NULL,
        [apellidoMaterno] nvarchar(30) NOT NULL,
        [correo] nvarchar(70) NOT NULL,
        [contrasenia] nvarchar(18) NOT NULL,
        [fechaCreacion] datetime2 NOT NULL,
        [fechaActualizacion] datetime2 NOT NULL,
        [imagen] nvarchar(max) NOT NULL,
        [estado] int NOT NULL,
        CONSTRAINT [PK_Usuarios] PRIMARY KEY ([id_usuario])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230511235856_AgregarBaseDatos')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230511235856_AgregarBaseDatos', N'7.0.5');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230512001748_AlimentarTablaUsuario')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id_usuario', N'apellidoMaterno', N'apellidoPaterno', N'contrasenia', N'correo', N'estado', N'fechaActualizacion', N'fechaCreacion', N'imagen', N'nombre') AND [object_id] = OBJECT_ID(N'[Usuarios]'))
        SET IDENTITY_INSERT [Usuarios] ON;
    EXEC(N'INSERT INTO [Usuarios] ([id_usuario], [apellidoMaterno], [apellidoPaterno], [contrasenia], [correo], [estado], [fechaActualizacion], [fechaCreacion], [imagen], [nombre])
    VALUES (1, N''Soraluz'', N''Calle'', N''12345'', N''jose.callesoraluz@unmsm.edu.pe'', 1, ''2023-05-11T19:17:48.5229827-05:00'', ''2023-05-11T19:17:48.5229817-05:00'', N'''', N''Jose Bryan'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'id_usuario', N'apellidoMaterno', N'apellidoPaterno', N'contrasenia', N'correo', N'estado', N'fechaActualizacion', N'fechaCreacion', N'imagen', N'nombre') AND [object_id] = OBJECT_ID(N'[Usuarios]'))
        SET IDENTITY_INSERT [Usuarios] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230512001748_AlimentarTablaUsuario')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230512001748_AlimentarTablaUsuario', N'7.0.5');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230512013658_AgregaTablaNoticias')
BEGIN
    EXEC(N'UPDATE [Usuarios] SET [fechaActualizacion] = ''2023-05-11T20:36:58.5573813-05:00'', [fechaCreacion] = ''2023-05-11T20:36:58.5573793-05:00''
    WHERE [id_usuario] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230512013658_AgregaTablaNoticias')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230512013658_AgregaTablaNoticias', N'7.0.5');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230512014024_AgregaTablaNoticias2')
BEGIN
    CREATE TABLE [Noticias] (
        [id_noticia] int NOT NULL IDENTITY,
        [url_noticia] nvarchar(500) NOT NULL,
        [img_noticia] nvarchar(500) NOT NULL,
        [estado] int NOT NULL,
        CONSTRAINT [PK_Noticias] PRIMARY KEY ([id_noticia])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230512014024_AgregaTablaNoticias2')
BEGIN
    EXEC(N'UPDATE [Usuarios] SET [fechaActualizacion] = ''2023-05-11T20:40:24.4682069-05:00'', [fechaCreacion] = ''2023-05-11T20:40:24.4682039-05:00''
    WHERE [id_usuario] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230512014024_AgregaTablaNoticias2')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230512014024_AgregaTablaNoticias2', N'7.0.5');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230513081843_Se modificarion servicios de Login y Noticias')
BEGIN
    EXEC(N'DELETE FROM [Usuarios]
    WHERE [id_usuario] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230513081843_Se modificarion servicios de Login y Noticias')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230513081843_Se modificarion servicios de Login y Noticias', N'7.0.5');
END;
GO

COMMIT;
GO

