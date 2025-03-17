# NoteCat

## Descripción

NoteCat es una aplicación de gestión de tareas desarrollada en C# con Windows Forms. Permite a los usuarios crear, editar y eliminar tareas, organizándolas por categorías y estados. La aplicación utiliza una base de datos SQL Server para almacenar la información de las tareas, usuarios, categorías y estados.

## Características

*   *Inicio de Sesión:*
    *   Permite a los usuarios ingresar con sus credenciales (nombre de usuario y contraseña).
    *   Valida las credenciales contra una base de datos SQL Server.
    *   Muestra mensajes de error si las credenciales son incorrectas.
*   *Gestión de Tareas:*
    *   Permite agregar nuevas tareas con título, descripción, categoría y estado.
    *   Permite editar tareas existentes.
    *   Permite eliminar tareas.
    *   Muestra una lista de tareas en un DataGridView, incluyendo título, descripción, categoría y estado.
*   *Categorías y Estados:*
    *   Utiliza tablas separadas para categorías y estados, conectadas a la tabla de tareas mediante claves foráneas.
    *   Permite seleccionar categorías y estados desde ComboBoxes.
*   *Interfaz de Usuario:*
    *   Interfaz gráfica intuitiva y fácil de usar.
    *   Mensajes de confirmación y error para mejorar la experiencia del usuario.
    *   Cerrar sesion.

## Requisitos

*   Windows (sistema operativo)
*   .NET Framework (versión compatible)
*   SQL Server (con una base de datos configurada)
*   Cadena de conexión configurada en el archivo App.config.

## Instalación

1.  *Clonar el Repositorio:*
    *   Si el código está en un repositorio (por ejemplo, GitHub), clónalo a tu máquina local.
2.  *Configurar la Base de Datos:*
    *   Asegúrate de que tienes una instancia de SQL Server en funcionamiento.
    *   Crea una base de datos llamada "TareasDB" (o el nombre que hayas configurado en App.config).
    *   Crea las tablas "Usuarios", "Tareas", "Categorias" y "Estados" con las columnas correspondientes.
    *   Asegurate de que las tablas de categorias y estados tengan datos.
3.  *Configurar la Cadena de Conexión:*
    *   Abre el archivo App.config y actualiza la cadena de conexión "TareasDB" con los detalles de tu base de datos SQL Server.
4.  *Abrir el Proyecto en Visual Studio:*
    *   Abre el archivo de solución (.sln) en Visual Studio.
5.  *Compilar y Ejecutar:*
    *   Compila el proyecto y ejecuta la aplicación.

## Uso

1.  *Inicio de Sesión:*
    *   Ingresa tu nombre de usuario y contraseña en la pantalla de inicio de sesión.
    *   Haz clic en el botón "Ingresar".
2.  *Interfaz Principal:*
    *   Verás la lista de tareas en el DataGridView.
    *   Haz clic en el botón "Agregar Tarea" para crear una nueva tarea.
    *   Haz clic en el boton "Borrar" para eliminar una tarea previamente seleccionada.
    *   Haz clic en el boton "Editar" para editar una tarea previamente seleccionada.
    *   Haz clic en el linklabel "Cerrar Sesion" para cerrar sesion.
3.  *Agregar/Editar Tareas:*
    *   Completa los campos de título, descripción, categoría y estado.
    *   Haz clic en el botón "Agregar Tarea" o "Editar Tarea" para guardar los cambios.
    *   Haz clic en el boton "Cancelar" para cancelar la operacion.

## Estructura del Código

*   *Login.cs:*
    *   Maneja la lógica de inicio de sesión.
    *   Conecta con la base de datos SQL Server.
    *   Valida las credenciales del usuario.
*   *Agregar.cs:*
    *   Permite agregar nuevas tareas a la base de datos.
    *   Valida los datos ingresados por el usuario.
    *   Limpia los campos después de agregar una tarea.
*   *Interfaz.cs:*
    *   Muestra la interfaz principal de la aplicación.
    *   Carga y muestra las tareas desde la base de datos.
    *   Permite borrar y editar tareas.
    *   Maneja el cierre de sesión.
    *   Maneja la logica de mostrar y ocultar los campos de edicion.
*   *App.config:*
    *   Contiene la cadena de conexión a la base de datos SQL Server.

## Contribución

Si deseas contribuir a NoteCate, puedes:

*   Reportar errores.
*   Sugerir nuevas características.
*   Enviar solicitudes de extracción con mejoras de código.

## Licencia

Este proyecto es de uso libre ya que esta hecho con fines meramente educativos.