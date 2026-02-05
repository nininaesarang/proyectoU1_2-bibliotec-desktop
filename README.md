# 💻 BiblioTec - Sistema de Gestión de Inventarios (Escritorio)

Versión de escritorio de la plataforma BiblioTec, desarrollada como una aplicación nativa robusta para la administración centralizada de inventarios. Este proyecto representa la primera iteración del sistema, enfocada en el rendimiento y la gestión de datos relacionales en entornos locales.

## 🏗️ Arquitectura y Tecnologías
Este sistema fue construido utilizando el ecosistema .NET, priorizando la estabilidad y la integración con herramientas empresariales:

* **Lenguaje:** **C#** (Programación Orientada a Objetos para la lógica de negocio).
* **Framework UI:** **Windows Forms (.NET)** para el diseño de una interfaz gráfica de usuario (GUI) funcional y amigable.
* **Base de Datos:** **Microsoft SQL Server**.
    * Diseño de esquema relacional normalizado.
    * Gestión de la persistencia de datos mediante consultas directas y procedimientos almacenados.
    * **Conexión:** Implementación de cadenas de conexión seguras para vincular la aplicación con el servidor de base de datos.

## 🚀 Funcionalidades
* **CRUD Completo:** Altas, Bajas, Modificaciones y Consultas de artículos en el inventario.
* **Interfaz Validada:** Controles de Windows Forms (TextBox, DataGridView, ComboBox) programados para validar la entrada de datos del usuario y prevenir errores.
* **Reportes Visuales:** Visualización de datos en tiempo real mediante grillas interactivas.

## 🛠️ Requisitos de Ejecución
* Sistema Operativo Windows.
* .NET Framework instalado.
* Instancia local o remota de SQL Server configurada con el script de base de datos adjunto (`db_schema.sql`).
