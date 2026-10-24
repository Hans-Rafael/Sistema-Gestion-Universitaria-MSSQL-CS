# Sistema de Gestión Universitaria

Sistema de gestión universitaria desarrollado en C# con .NET Framework 4.8, utilizando WinForms y Microsoft SQL Server. El proyecto permite gestionar alumnos, materias, inscripción académica y estados de cursado a través de una interfaz gráfica simple y funcional.

## Descripción

Esta aplicación está pensada como una solución de administración académica para una universidad o institución educativa. Incluye una base de datos relacional con entidades como:

- Alumnos
- Profesores
- Carreras
- Materias
- Inscripciones de alumnos a materias
- Estados académicos
- Accesos por tipo de usuario
- Documentación de alumnos

La lógica de acceso a datos está separada en una clase `Conexion`, y la interfaz principal está desarrollada en `Form1` usando WinForms.

## Tecnologías

- C#
- .NET Framework 4.8
- WinForms
- SQL Server / SQL Server Express
- ADO.NET `SqlConnection`, `SqlCommand`, `SqlDataReader`
- SQL Server Management Studio / scripts SQL

## Funcionalidades principales

- Listado de estudiantes
- Listado de materias
- Visualización de alumnos por materia
- Inscripción de alumnos a materias
- Carga de estado académico:
  - Aprobado
  - Regular
  - Desaprobado
- Validación de datos antes de registrar información
- Manejo de errores con mensajes amigables para el usuario
- Conexión a base de datos mediante `App.config`

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
└── TP2DB1.slnx
```

## Base de datos

La base de datos se encuentra en `Database/script_inicial.sql`.

Ese script crea la base de datos `GestionUniversitaria` y las tablas principales del sistema:

- `alumno`
- `profesor`
- `carrera`
- `materia`
- `alumno_materia`
- `alumno_materia_notas`
- `estado_academico`
- `tipo_acceso`
- `acceso_alumno`
- `acceso_profesores`
- `acceso_administrador`
- `documentacion_alumno`

El script incluye:

- creación de la base de datos
- creación de tablas
- claves primarias y foráneas
- restricciones y checks
- valores por defecto

## Requisitos previos

Antes de ejecutar la aplicación debes tener instalado:

- Visual Studio 2019 o superior
- .NET Framework 4.8
- SQL Server Express o SQL Server local
- acceso a una instancia con SQL Server disponible

## Configuración de la conexión

El archivo `TP2DB1/Sistema-Gestion-universitaria/App.config` contiene la cadena de conexión:

```xml
<connectionStrings>
  <add name="GestionUniversitaria"
       connectionString="Server=.\SQLEXPRESS;Database=GestionUniversitaria;Integrated Security=True;TrustServerCertificate=True;"
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

Asegúrate de que:

- el nombre de la base sea `GestionUniversitaria`
- la instancia de SQL Server sea accesible
- el usuario del sistema tenga permisos para conectarse
- si usás otra instancia, actualizá `Server=...`

## Instalación y ejecución

1. Cloná el repositorio:

```bash
git clone https://github.com/Hans-Rafael/Sistema-Gestion-Universitaria-MSSQL-CS.git
```

2. Abrí la solución `TP2DB1.slnx` o el proyecto `Sistema-Gestion-universitaria.csproj` en Visual Studio.

3. Ejecutá el script SQL ubicado en:

```text
Database/script_inicial.sql
```

4. Verificá que la base `GestionUniversitaria` exista en SQL Server.

5. Compilá y ejecutá la aplicación desde Visual Studio.

## Flujo de uso

1. La aplicación carga automáticamente los alumnos y las materias al iniciar.
2. El usuario selecciona un alumno y una materia haciendo doble clic sobre las grillas.
3. Se elige el estado académico.
4. Se confirma la inscripción.
5. El sistema registra la relación en la tabla `alumno_materia`.
6. La vista de alumnos por materia se actualiza para reflejar el cambio.

## Archivos importantes

- `Conexion.cs`: encapsula la conexión a SQL Server
- `Form1.cs`: lógica principal de la interfaz y operaciones CRUD/consultas
- `Program.cs`: punto de entrada de la aplicación
- `Database/script_inicial.sql`: definición completa de la base de datos
- `App.config`: configuración del acceso a datos

## Notas de desarrollo

El proyecto sigue una estructura sencilla basada en WinForms y acceso directo a base de datos con ADO.NET. Aunque la aplicación aún se encuentra en una fase inicial, representa una base sólida para ampliar funciones como:

- gestión de profesores
- carga de notas
- cumplimiento documental
- autenticación de usuarios
- reportes y consultas avanzadas
- arquitectura por capas / patrón repositorio

## Licencia

Este proyecto está licenciado bajo la licencia MIT. Consulta el archivo `LICENSE` para más información.

## Autor

Hans-Rafael

## Estado del proyecto

Proyecto académico / demostrativo de gestión universitaria con SQL Server y C#.

---

Si querés, también puedo dejarte una versión más "profesional" del README con:

- badges de tecnologías
- capturas de pantalla
- sección de screenshots
- tabla de funcionalidades
- instrucciones para SQL Server Express con autenticación de Windows
- una versión en inglés
