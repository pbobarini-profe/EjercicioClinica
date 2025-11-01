Este trabajo es para evaluar la aplicacion correcta de los contenidos vistos sobre arquitectura de 3 capas en una aplicacion Windows Form. Las temáticas fueron sugeridas por los alumnos.  
A tener en cuenta:  
1-No vamos a usar Entity Framework, por lo que les pido que me envien los comandos para sql server de los create de las tablas. Por defecto si son varchar comunes (no esta comentado en la clase varchar max) los varchar seran de 120 caracteres.  
2-Debe funcionar completo el CRUD - SOLO DEBEN TOCAR LOS ARCHIVOS DE LAS CLASES QUE LES FUERON DADAS - NO TOCAR ARCHIVO DE LOS OTROS.  
3-Como implica que varios alumnos van a necesitar funciones y metodos de otras clases que le corresponde a otro compañero, vamos a simplificar y van a poder hacer JOIN y crear los objetos que necesite el modelo elegido. Esto, si bien no es lo optimo, en terminos prácticos va a simplificar los posibles conflictos en la cooperacion.  
4-Deben presentar un reporte en RDLC. Los dejo a criterio de ustedes. Ese tema lo vamos a ver la clase del 01/11.  
5-Cada alumno debe pasarme su link de cuenta de github para que yo lo agregue como colaborador.  
6-Tema manejo de ramas que no pudimos ver en clase. Antes de comenzar a editar deben crear una rama haciendo click en donde dice master en la esquina inferior derecha del visual studio. Ahi les saldra estas opciones:  
<img width="625" height="436" alt="image" src="https://github.com/user-attachments/assets/ca2281f5-bc50-45e2-8b81-d1a298d7e701" />
Ponen nueva rama y le colocan su nombre.  
Siempre que esten desarrollando asegurense tener su rama seleccionada. Cualquier duda la vemos en clase  
// Tablas

-- Pacientes


CREATE TABLE dbo.Pacientes (
    id               INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    dni              NVARCHAR(50) NULL,
    nombre           NVARCHAR(100) NULL,
    apellido         NVARCHAR(100) NULL,
    telefono         NVARCHAR(50) NULL,
    genero           INT NOT NULL,
    fechaNacimiento  DATETIME2(7) NOT NULL
);

-- Medicos


CREATE TABLE dbo.Medicos (
    id               INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    dni              NVARCHAR(50) NULL,
    nombre           NVARCHAR(100) NULL,
    apellido         NVARCHAR(100) NULL,
    telefono         NVARCHAR(50) NULL,
    genero           INT NOT NULL,
    fechaNacimiento  DATETIME2(7) NOT NULL
);

-- TipoEventos


CREATE TABLE dbo.TipoEventos (
    id           INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    descripcion  NVARCHAR(200) NULL
);

-- Eventos


CREATE TABLE dbo.Eventos (
    id           INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    descripcion  NVARCHAR(200) NULL,
    tipoEventoId INT NOT NULL,
    CONSTRAINT FK_Eventos_TipoEventos
        FOREIGN KEY (tipoEventoId) REFERENCES dbo.TipoEventos(id)
);

-- Medicamentos


CREATE TABLE dbo.Medicamentos (
    id           INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    descripcion  NVARCHAR(200) NULL,
    eventoId     INT NOT NULL,
    CONSTRAINT FK_Medicamentos_Eventos
        FOREIGN KEY (eventoId) REFERENCES dbo.Eventos(id)
);
-- HistoriasClinicas


CREATE TABLE dbo.HistoriasClinicas (
    id           INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    pacienteId   INT NOT NULL,
    descripcion  NVARCHAR(MAX) NULL,
    fechaInicio  DATETIME2(7) NOT NULL,
    CONSTRAINT FK_HistoriasClinicas_Pacientes
        FOREIGN KEY (pacienteId) REFERENCES dbo.Pacientes(id)
);

-- Turnos


CREATE TABLE dbo.Turnos (
    id           INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    pacienteId   INT NOT NULL,
    medicoId     INT NOT NULL,
    fecha        DATETIME2(7) NOT NULL,
    comentarios  NVARCHAR(MAX) NULL,
    CONSTRAINT FK_Turnos_Pacientes FOREIGN KEY (pacienteId) REFERENCES dbo.Pacientes(id),
    CONSTRAINT FK_Turnos_Medicos   FOREIGN KEY (medicoId)   REFERENCES dbo.Medicos(id)
);
-- PagosTurnos


CREATE TABLE dbo.PagosTurnos (
    id         INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    fechaPago  DATETIME2(7) NOT NULL,
    turnoId    INT NOT NULL,
    monto      DECIMAL(18,2) NOT NULL,
    CONSTRAINT FK_PagosTurnos_Turnos
        FOREIGN KEY (turnoId) REFERENCES dbo.Turnos(id)
);
-- TiposResultadosTratamientos


CREATE TABLE dbo.TiposResultadosTratamientos (
    id           INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    descripcion  NVARCHAR(200) NULL
);


-- DetallesHistoriasClinicas


CREATE TABLE dbo.DetallesHistoriasClinicas (
    id                 INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    fecha              DATETIME2(7) NOT NULL,
    historiaClinicaId  INT NOT NULL,
    medicoId           INT NOT NULL,
    tipoEventoId       INT NOT NULL,
    descripcion        NVARCHAR(MAX) NULL,
    CONSTRAINT FK_DHC_HistoriasClinicas FOREIGN KEY (historiaClinicaId) REFERENCES dbo.HistoriasClinicas(id),
    CONSTRAINT FK_DHC_Medicos           FOREIGN KEY (medicoId)          REFERENCES dbo.Medicos(id),
    CONSTRAINT FK_DHC_Eventos           FOREIGN KEY (tipoEventoId)      REFERENCES dbo.Eventos(id)
);

-- Tratamiento


CREATE TABLE dbo.Tratamiento (
    id                       INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    detalleHistoriaClinicaId INT NOT NULL,
    medicamentoId            INT NOT NULL,
    peso                     DECIMAL(18,2) NOT NULL,
    fechaInicio              DATETIME2(7) NOT NULL,
    descripcion              NVARCHAR(MAX) NULL,
    resultadoId              INT NOT NULL,
    CONSTRAINT FK_Tratamiento_DHC   FOREIGN KEY (detalleHistoriaClinicaId) REFERENCES dbo.DetallesHistoriasClinicas(id),
    CONSTRAINT FK_Tratamiento_Meds  FOREIGN KEY (medicamentoId)            REFERENCES dbo.Medicamentos(id),
    CONSTRAINT FK_Tratamiento_Tipos FOREIGN KEY (resultadoId)              REFERENCES dbo.TiposResultadosTratamientos(id)
);


-- Especializaciones

CREATE TABLE dbo.Especializaciones (
    id           INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    descripcion  NVARCHAR(200) NULL
);

-- ActividadesClientes

CREATE TABLE dbo.ActividadesClientes (
    id            INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    actividadId   INT NOT NULL,   -- HistoriasClinicas
    clienteId     INT NOT NULL,   -- Pacientes
    fechaInicio   DATETIME2(7) NOT NULL,
    vigente       INT NOT NULL,   -- 1-Vigente | 2-Caducado
    CONSTRAINT FK_ActCli_HistoriasClinicas FOREIGN KEY (actividadId) REFERENCES dbo.HistoriasClinicas(id),
    CONSTRAINT FK_ActCli_Pacientes         FOREIGN KEY (clienteId)   REFERENCES dbo.Pacientes(id)
);


-- EspecializacionesMedicos

CREATE TABLE dbo.EspecializacionesMedicos (
    id                 INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    medicoId           INT NOT NULL,  -- Medicos
    especializacionId  INT NOT NULL,  -- Especializaciones
    fechaTitulacion    DATETIME2(7) NOT NULL,
    otros              NVARCHAR(MAX) NULL,
    CONSTRAINT FK_EspMed_Medicos           FOREIGN KEY (medicoId)          REFERENCES dbo.Medicos(id),
    CONSTRAINT FK_EspMed_Especializaciones FOREIGN KEY (especializacionId) REFERENCES dbo.Especializaciones(id)
);
