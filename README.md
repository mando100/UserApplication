
# Para ejecutar el back end:

1. Ejecutar el script de creacion de la tabla que se encuentra en ".\UserApplicationDAL\Scripts\dboUserCreationScript.sql"
2. Compilar la solucion.
3. Modificar la connection string para la base de datos en el archivo appsettings 
3. Ejecutar la solucion.
4. En caso de que no requiera datos de inicializacion comentar la linea "UserApplicationInitializer.Initialize(context);"


# Para el front end

1. Abrir la carpeta que esta en la ruta ".\UserApplication.WebPresentation\ClientApp"
1. Instalar todos los paquetes de ng
2. Ejecutar ng serve -o


# Pendiente de realizar:

La llamada para la creacion y edicion de un usuario desde el frontend.
Actualizar la lista al eliminar un usuario.
Estilo a los botones Editar y eliminar.
Ocultar grilla en caso de no haber datos.
Validaciones de los campos en el fron.
