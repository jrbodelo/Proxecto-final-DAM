# FASE DE IMPLANTACIÓN

## Manual técnico:

### Requerimentos hardware

Serán necesarios para o despregue desta aplicación (instalación de todos os programas que necesita e a propia aplicación):
- 2GB de RAM ou máis.
- 3GB de Disco duro libres.


### Requerimentos software
Esta aplicación só pode ser despregada nun ordenador con sistema operativo Windows.

Será necesario ter dous programas pre instalados para poder levar acabo a instalación e posta en marcha desta aplicación:
- Adobe Reader
>https://get.adobe.com/es/reader/

- Microsoft Visual C++ Redistributable for Visual Studio
>https://support.microsoft.com/es-es/help/2977003/the-latest-supported-visual-c-downloads

### Información relativa á instalación

Para levar a cabo a instalación desta aplicación será necesario seguir os seguintes pasos, nos que se explica a instalación varios programas necesarios para poder implantar ReproCow, así como a instalación do propio programa.

#### Instalación de MySql Server e MySql Workbench
- **Paso 1**: Descargar na seguinte páxina o instalador de MySql (recomendamos descargar o paquete completo, a segunda opción):
    >https://dev.mysql.com/downloads/windows/installer/8.0.html

- **Paso 2**: Executar o instalador dende a carpeta na que foi descargado.

Realizar unha instalación configurando todo o que nos pidan nas diferentes ventanas por defecto, excepto o máis importante:
- **Server name**: ten que chamarse **"localhost"**
- **Contrasinal do usuario root**: o contrasinal ten que ser **"abc123.,"**


#### Creación da base de datos
- **Paso 1**: Abrir o MySql Workbench e crear unha nova conexión
![Crear conexión](doc/img/img_implantacion/pantallaInstalar1.png)
![Probar conexión](doc/img/img_implantacion/pantallaInstalar2.png)

- **Paso 2**: Abrir o script SQL do proxecto:
![Ir ao script](doc/img/img_implantacion/pantallaInstalar3.png)
![Abrir script](doc/img/img_implantacion/pantallaInstalar4.png)

- **Paso 3**: Seleccionar todo o texto do script e executalo:
![Executar script](doc/img/img_implantacion/pantallaInstalar5.png)

#### Instalación da aplicación

- **Paso 1**: Abrir o proxecto e executar o ReproCowSetup, instalar todo por defecto, sin cambiar nada.
![Executar setup](doc/img/img_implantacion/pantallaInstalar6.png)

- **Paso 2**: No escritorio crearase un acceso directo para executar a aplicación
![Executar aplicación](doc/img/img_implantacion/pantallaInstalar7.png)


## Xestión de incidencias

En calquera tipo de incidencia, contactar por correo a a17juanbl@iessanclemente.net


## Manual de usuario
Para consultar o manual de usuario da aplicación, pulse [**aquí**](doc/templates/7_manual_usuario.md)