# Portfolio Web

Este proyecto fue desarrollado con **ASP.NET Core MVC 9**, utilizando la [CLI de .NET](https://learn.microsoft.com/en-us/dotnet/core/tools/).  
Su propósito principal es **demostrar mis habilidades técnicas y mi proceso de aprendizaje** en el desarrollo de aplicaciones web con el patrón MVC.

## 🎯 Descripción

Se trata de un proyecto creado como parte de mi formación en el curso de Udemy *"Aprende ASP.NET Core MVC 9 haciendo proyectos desde cero"*, impartido por Felipe Gavilán.  
Más allá de ser un ejercicio académico, este proyecto representa un espacio donde aplico los conocimientos adquiridos y muestro mi evolución como desarrollador.

## 🚀 Tecnologías y Herramientas Utilizadas

- **ASP.NET Core MVC 9** – para la estructura y lógica del proyecto.  
- **C#** – como lenguaje principal de programación.  
- **HTML y CSS** – para la construcción y estilizado de las vistas.  
- **Bootstrap** – para el diseño responsivo y el uso de íconos.  
- **Vistas parciales** – para mejorar la modularidad y reutilización de componentes.  

## ⚙️ Configuración y Ejecución en Modo Desarrollo

Sigue estos pasos para poner el proyecto en marcha en tu entorno local:

1. **Funcionalidad del Formulario de Contacto**  
   Edita el archivo `appsettings.Development.json` y agrega tus credenciales:  

   ```json
   "EMAIL": "tu_correo_electronico",
   "PASSWORD": "tu_password"
   ```

2. Inicio del Servidor Local

    ```bash
    dotnet watch
    ```

Una vez que el servidor esté activo, abre tu navegador web y navega a http://localhost:5051/. La aplicación se recargará automáticamente cada vez que realices modificaciones en el código fuente.