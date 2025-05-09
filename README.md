# 🎲 Yahtzee/Generala - Juego de Dados en Windows Forms

es una aplicación de escritorio en **C# con Windows Forms**, que permite disfrutar del juego de dados **Generala** en modo **individual o multijugador**, con almacenamiento de puntuaciones en una **base de datos**.

## 🚀 Propósito del Proyecto
Esta aplicación proporciona:
- **🎮 Simulación digital de Generala** con reglas estándar.
- **👥 Soporte para juego individual o dos jugadores**.
- **🎲 Mecánica de lanzamiento de dados** con representación visual.
- **📊 Cálculo y almacenamiento de puntajes** en base de datos.
- **📜 Interfaz intuitiva** con controles accesibles.

## 🏗️ Arquitectura del Sistema
El proyecto sigue una estructura modular basada en **Windows Forms**, con una capa de acceso a datos para almacenar resultados:
1. **🔹 Interfaz de usuario:** Formularios de juego, selección de jugadores y historial.
2. **🔹 Lógica del juego:** Mecánicas de lanzamiento, puntuación y reglas.
3. **🔹 Persistencia de datos:** Base de datos Microsoft Access.

## 📜 Componentes Principales
| Componente | Propósito |
|------------|----------|
| `Jugadores Form` | Configuración de jugadores |
| `Juego Form` | Pantalla principal del juego |
| `Historial Form` | Consulta de partidas previas |

## 🎲 Flujo de Juego
El usuario sigue este proceso:
1. **Lanzar la aplicación** (`Program.cs`).
2. **Seleccionar jugadores** (`Jugadores Form`).
3. **Jugar y registrar puntuaciones** (`Juego Form`).
4. **Guardar resultados en la base de datos** (`Historial.mdb`).
5. **Consultar historial de partidas** (`Historial Form`).

## 💾 Base de Datos
La aplicación almacena los puntajes en **Microsoft Access** (`Historial.mdb`), utilizando clases para gestión de datos:
- `ConectaDB.cs`: Manejo de conexión y ejecución de consultas.
- `DB.cs`: Gestión de objetos de conexión.

## 🔗 Tecnologías Utilizadas
| Componente | Tecnología |
|------------|------------|
| **Interfaz** | Windows Forms |
| **Base de datos** | Microsoft Access |
| **Framework** | .NET Framework 4.0 |
| **Gráficos** | System.Drawing (dados) |


