CREATE DATABASE db_Aduanas;
GO
USE db_Aduanas;
GO 

CREATE TABLE Paises (
    IdPais INT IDENTITY(1,1) PRIMARY KEY,
    CodigoPais VARCHAR(10) NOT NULL,
    NombrePais VARCHAR(100) NOT NULL,
    Continente VARCHAR(50) NOT NULL,
    IdiomaOficial VARCHAR(50) NOT NULL,
    Activo BIT NOT NULL DEFAULT 1
);

CREATE TABLE Empleados (
    IdEmpleado INT IDENTITY(1,1) PRIMARY KEY,
    NombreCompleto VARCHAR(150) NOT NULL,
    DocumentoIdentidad VARCHAR(20) NOT NULL UNIQUE,
    Cargo VARCHAR(100) NOT NULL,
    SalarioBase DECIMAL(18,2) NOT NULL,
    FechaIngreso DATETIME NOT NULL,
    Activo BIT NOT NULL DEFAULT 1
);

CREATE TABLE NumerosDO (
    IdNumeroDO INT IDENTITY(1,1) PRIMARY KEY,
    NumeroDO VARCHAR(50) NOT NULL UNIQUE,
    IdImportador INT NOT NULL,
    IdExportador INT NOT NULL,
    FechaApertura DATETIME NOT NULL,
    Estado VARCHAR(50) NOT NULL,
    Activo BIT NOT NULL DEFAULT 1
);

CREATE TABLE FacturasVentas (
    IdFacturaVenta INT IDENTITY(1,1) PRIMARY KEY,
    NumeroFactura VARCHAR(50) NOT NULL UNIQUE,
    FechaEmision DATETIME NOT NULL,
    MontoTotal DECIMAL(18,2) NOT NULL,
    Activo BIT NOT NULL DEFAULT 1
);

CREATE TABLE DetallesFacturasVentas (
    IdDetalleFacturaVenta INT IDENTITY(1,1) PRIMARY KEY,
    IdFacturaVenta INT NOT NULL,
    IdProducto INT NOT NULL,
    Cantidad INT NOT NULL,
    PrecioUnitario DECIMAL(18,2) NOT NULL,
    Subtotal AS (Cantidad * PrecioUnitario) PERSISTED,
    CONSTRAINT FK_Detalle_Factura FOREIGN KEY (IdFacturaVenta) REFERENCES dbo.FacturasVentas(IdFacturaVenta)
);

CREATE TABLE ConceptosGastosIngresos (
    IdConceptoGastoIngreso INT IDENTITY(1,1) PRIMARY KEY,
    NombreConcepto VARCHAR(100) NOT NULL,
    Tipo VARCHAR(20) NOT NULL CHECK (Tipo IN ('Gasto', 'Ingreso')),
    Activo BIT NOT NULL DEFAULT 1
);

CREATE TABLE CuentasPucs (
    IdCuentaPuc INT IDENTITY(1,1) PRIMARY KEY,
    CodigoCuenta VARCHAR(20) NOT NULL UNIQUE,
    NombreCuenta VARCHAR(150) NOT NULL,
    TipoCuenta VARCHAR(50) NOT NULL,
    Activo BIT NOT NULL DEFAULT 1
);

CREATE TABLE MediosPago (
    IdMedioPago INT IDENTITY(1,1) PRIMARY KEY,
    NombreMedioPago VARCHAR(100) NOT NULL,
    Activo BIT NOT NULL DEFAULT 1
);

GO
INSERT INTO Paises (CodigoPais, NombrePais, Continente, IdiomaOficial, Activo) VALUES
('COL', 'Colombia', 'América del Sur', 'Español', 1),
('USA', 'Estados Unidos', 'América del Norte', 'Inglés', 1),
('DEU', 'Alemania', 'Europa', 'Alemán', 1),
('JPN', 'Japón', 'Asia', 'Japonés', 1),
('BRA', 'Brasil', 'América del Sur', 'Portugués', 1);

INSERT INTO MediosPago (NombreMedioPago, Activo) VALUES
('Efectivo', 1),
('Transferencia Bancaria', 1),
('Tarjeta de Crédito', 1),
('Cheque', 1);

INSERT INTO CuentasPucs (CodigoCuenta, NombreCuenta, TipoCuenta, Activo) VALUES
('110505', 'Caja General', 'Activo', 1),
('111005', 'Bancos Nacionales', 'Activo', 1),
('130505', 'Clientes Nacionales', 'Activo', 1),
('413505', 'Comercio al por mayor y al por menor', 'Ingreso', 1),
('510506', 'Sueldos', 'Gasto', 1);

INSERT INTO ConceptosGastosIngresos (NombreConcepto, Tipo, Activo) VALUES
('Honorarios Aduaneros', 'Ingreso', 1),
('Almacenamiento', 'Gasto', 1),
('Flete Internacional', 'Gasto', 1),
('Comisión Agencia', 'Ingreso', 1);
GO
