Aplicación Web creada con C# .net
Base de datos creada en PostgresSQL

La conexión a la base de datos se encuentra en el archivo Web.config, dentro de la sección ConnectionStrings
Cambiar el nombre de server, port, nombre de la base, nombre de usuario y contraseña segun se requiera

En el archivo QueryCreateTable.txt se encuentra el query para poder crear la tabla
En el archivo TablaEmpleado.csv se encuentran los datos preestablecidos de la tabla, no son necesarios para su funcionalidad

Para importar este archivo es necesario:

Hacer click derecho sobre la tabla a modificar
Click en Import/Export
Click en la sección de opciones, hacer click en el toggle de Import/Export, dejandolo en Import
Seleccionar el archivo TablaEmpleado.csv
Seleccionar las siguientes opciones:

	Formato: CSV
	Encoding: UTF8
	OID: No
	Header: Yes
	Delimiter: |
	Quote: "
	Escape: '

Hacer click en OK debería importar la información

