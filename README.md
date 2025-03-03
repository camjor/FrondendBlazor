# 🚀 Proyecto Blazor Server - Gestión de Personas y Tareas

## 📌 Requisitos Previos

Para utilizar este proyecto, es necesario cumplir con los siguientes requisitos:  

1. Tener **Blazor Server** correctamente instalado.  
2. Ejecutar el backend **Personas API**, ya que este frontend realiza peticiones a sus endpoints.  
3. Contar con **SQL Server** configurado con las tablas necesarias (`Personas` y `Tareas`).  
4. Tener **Postman** u otra herramienta para probar los endpoints de manera independiente, si es necesario.  

## 🖥️ Funcionalidades Principales

- 🌐 **Interfaz Web con Blazor Server**  
  - En la barra de navegación (`NavMenu`), se encuentran dos botones principales:  
    - **Tareas** 📝: Permite realizar operaciones **CRUD** sobre las tareas almacenadas en la base de datos.  
    - **Personas** 👤: Gestiona los usuarios, permitiendo su creación, edición y eliminación.  

- 🔗 **Integración con el Backend**  
  - El proyecto realiza peticiones a los endpoints del backend **Personas API**.  
  - Se recomienda probar los endpoints directamente en **Postman** o herramientas similares para validar su funcionamiento.  

## ⚙️ Configuración y Uso

1. Clonar este repositorio y abrir el proyecto en **Visual Studio**.  
2. Asegurar que el backend de **Personas API** está en ejecución.  
3. Configurar la conexión a **SQL Server** si es necesario.  
4. Ejecutar el proyecto Blazor Server y acceder a la interfaz web.  

## 🚀 Recomendaciones

- Asegurarse de que el backend y la base de datos están correctamente configurados antes de ejecutar el proyecto.  
- Verificar los logs de la consola en caso de errores al conectar con los endpoints.  
- Probar las operaciones **CRUD** desde Postman para asegurarse de que los datos se están almacenando correctamente en SQL Server.  
