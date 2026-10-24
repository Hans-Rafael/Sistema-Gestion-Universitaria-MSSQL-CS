# Sistema de Gestión Universitaria

<div align="center">

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![.NET 4.8](https://img.shields.io/badge/.NET-4.8-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![WinForms](https://img.shields.io/badge/WinForms-Application-0078D4?style=for-the-badge)
![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white)
![MIT License](https://img.shields.io/badge/License-MIT-green?style=for-the-badge)

</div>

Sistema de gestión universitaria desarrollado en C# con Microsoft .NET Framework 4.8, utilizando WinForms y conexión a una base de datos SQL Server. Este proyecto fue realizado como Trabajo Práctico N°2 para el manejo de alumnos y materias, con la posibilidad de listar registros, seleccionar datos desde grillas y registrar inscripciones.

## Descripción general

La aplicación permite administrar la relación entre alumnos y materias dentro de una universidad. A través de una interfaz gráfica, el usuario puede:

- listar alumnos
- listar materias
- visualizar alumnos inscriptos por materia
- seleccionar un alumno y una materia desde las grillas
- cargar los datos en los `TextBox`
- registrar la inscripción en la base de datos
- actualizar la grilla de registros
- manejar errores de la base de datos con mensajes visibles

## Objetivos del trabajo práctico

1. Conectarse a la base de datos `GestionUniversitaria` mediante una clase estática `Conexion`.
2. Listar las tablas `alumno`, `materia` y `alumno_materia` al cargar el formulario.
3. Cargar los `TextBox` `txtAlumno` y `txtMateria` con datos de la grilla.
4. Guardar los IDs seleccionados en variables globales.
5. Registrar la inscripción del alumno en la materia usando el evento `btnRegistrar_Click`.
6. Actualizar la grilla de alumnos por materia luego del alta.

## Tecnologías empleadas

- C#
- .NET Framework 4.8
- WinForms
- SQL Server
- ADO.NET
- `SqlConnection`
- `SqlCommand`
- `SqlDataReader`

## Funcionalidades principales

- Carga inicial de tablas al abrir la aplicación.
- Doble clic sobre una fila de `dgvAlumnos` para seleccionar un alumno.
- Doble clic sobre una fila de `dgvMaterias` para seleccionar una materia.
- Validación antes de registrar la inscripción.
- Confirmación antes de guardar.
- Manejo de errores de SQL Server.
- Actualización automática de la grilla principal de inscripciones.

## Estructura del proyecto

```text
Sistema-Gestion-Universitaria-MSSQL-CS/
├── Database/
│   └── script_inicial.sql
├── TP2DB1/
│   └── Sistema-Gestion-universitaria/
│       ├── App.config
│       ├── Conexion.cs
│       ├── Form1.cs
│       ├── Form1.Designer.cs
│       ├── Form1.resx
│       ├── Program.cs
│       ├── Sistema-Gestion-universitaria.csproj
│       └── Properties/
├── .gitignore
├── LICENSE
├── README.md
├── TP2DB1.slnx
└── .gitattributes
```

## Base de datos

El proyecto utiliza la base de datos:

```sql
GestionUniversitaria
```

El script SQL con la creación de la base y las tablas está en:

```text
Database/script_inicial.sql
```

Las principales tablas del sistema son:

- `alumno`
- `materia`
- `carrera`
- `profesor`
- `alumno_materia`
- `estado_academico`
- `tipo_acceso`
- `documentacion_alumno`

## Configuración de conexión

La conexión a SQL Server está definida en `App.config`:

```xml
<connectionStrings>
  <add name="GestionUniversitaria"
       connectionString="Server=.\SQLEXPRESS;Database=GestionUniversitaria;Integrated Security=True;TrustServerCertificate=True;"
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

Si la instancia de SQL Server no es `SQLEXPRESS`, deberás modificar el valor de `Server` según tu entorno local.

## Requisitos previos

Antes de ejecutar el proyecto, verificá que tengas instalado:

- Visual Studio 2019 o superior
- .NET Framework 4.8
- SQL Server Express o SQL Server local
- permisos para crear o acceder a la base `GestionUniversitaria`

## Instrucciones de ejecución

1. Cloná el repositorio.
2. Abrí la solución o el proyecto en Visual Studio.
3. Ejecutá el script ubicado en `Database/script_inicial.sql` para crear la base de datos.
4. Verificá que exista la base `GestionUniversitaria`.
5. Compilá y ejecutá la aplicación.
6. En la interfaz, seleccioná un alumno y una materia con doble clic.
7. Presioná el botón de registrar para agregar la inscripción.

## Flujo de uso

1. Al abrir la aplicación, se cargan los alumnos y materias.
2. Se hace doble clic en la grilla de alumnos para cargar el `TextBox` correspondiente.
3. Se hace doble clic en la grilla de materias para cargar el `TextBox` correspondiente.
4. Se confirma la inscripción.
5. El sistema guarda la tupla `alumno + materia + fecha + estado` en la base de datos.
6. La grilla de alumnos por materia se actualiza.

## Archivos principales

- `TP2DB1/Sistema-Gestion-universitaria/Conexion.cs` → lógica de conexión con SQL Server.
- `TP2DB1/Sistema-Gestion-universitaria/Form1.cs` → lógica principal de la interfaz y operaciones de base de datos.
- `TP2DB1/Sistema-Gestion-universitaria/Program.cs` → punto de entrada de la aplicación.
- `TP2DB1/Sistema-Gestion-universitaria/App.config` → configuración de la conexión.
- `Database/script_inicial.sql` → script de la base de datos.

## Capturas de pantalla recomendadas

Se recomienda guardar 3 imágenes en una carpeta `docs/screenshots/` con estos nombres:

```text
docs/screenshots/01-carga-inicial.png
docs/screenshots/02-seleccion-alumno-materia.png
docs/screenshots/03-error-validacion.png
```

Descripción:

- `01-carga-inicial.png`: aplicación abriéndose y cargando alumnos y materias.
- `02-seleccion-alumno-materia.png`: doble clic en alumno y materia para cargar los `TextBox`.
- `03-error-validacion.png`: popup con un error de validación o conexión.

## Licencia

Este proyecto está bajo la licencia MIT. Consulta el archivo `LICENSE` para más información.

## Autor

Hans-Rafael

## Estado del proyecto

Trabajo práctico finalizado sobre listado y alta de alumnos a materias utilizando C#, WinForms y SQL Server.
