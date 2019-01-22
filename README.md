# API REST

Api REST FULL 
Consulta los registros de una Base de datos donde realiza las siguientes operaciones:

+ GET: Obtiene toda las tareas. 

   ruta: /api/v1/Tarea

+ GET(id): Obtiene una tarea.   

   ruta: /api/v1/Tarea/id

+ POST: Agrega nuevas tareas.   
   
   ruta: /api/v1/Tarea

+ PUT: Actualiza una tarea.     

   ruta: /api/v1/Tarea

+ DELETE  Elimina una tarea.    
   ruta: /api/v1/Tarea

# Tecnologias
+ .NET

   Se desarollo en el entorno de Visual Stdio, en C#
+ SQL

      Se creo una sola tabla con la siguiente estructura:
   
      CREATE TABLE Tarea
   
      (
   
      ID int primary key identity(1,1),
    
      descripcion varchar(max),
    
      estado bit
    
      );
  
+ Azure

Se desplego tanto la base de datos como la aplicacion en los servicios de azure


