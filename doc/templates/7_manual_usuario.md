# MANUAL DE USUARIO

Nesta sección explícase con detalle as funcionalidades da aplicación e como utilizala.

## Pantalla principal:
A pantalla principal é a que se abre cando se executa a aplicación, donde se pode ver :
- Tabla con todas as vacas e novillas rexistradas e os seus datos.
- A información de cada vaca
- Os botóns para abrir os PDF de carta de rexistro, ficheiro de xenómica e ficheiro de acoplamento de cada vaca.
- Botón para abrir a pantalla de modificar o animal seleccionado.
- Botón para eliminar o animal seleccionado.
- Botón para eliminar o último rexistro feito da vaca.
- Botón para ver todos os rexistros da vaca.
- Botón para engadir o rexistro a vaca.
- Menú para ir a:
    - Crear un novo animal
    - Xestión de toros
    - Ver as próximas tarefas
![Pantalla principal da aplicación ](doc/img/img_manual/pantallaPrincipal.png)

## Pantalla de creación de novo animal
Nesta pantalla podemos engadir os datos dun animal novo:
![Pantalla creación de animal da aplicación ](doc/img/img_manual/pantallaNovoAnimal.png)

Ademais, nesta pantalla pódese engadir os PDF correspondentes a cada un dos documentos que se necesita gardar do animal:
![Pantalla engadir documentos ](doc/img/img_manual/pantallaEngadirDocumento.png)

## Pantalla de modificación do animal
Esta pantalla ábrese ao pulsar o botón Modificar situado na sección de información do animal na pantalla principal.
Nesta pantalla pódese modificar os datos do animal, así como cambiar os documentos deste:
![Pantalla modificar animal ](doc/img/img_manual/pantallaModificarAnimal.png)

## Pantalla de eliminación de animal
Ao pulsar o botón Eliminar animal na pantalla principal. Sacará un mensaxe preguntando se de verdade se quere eliminar.
![Pantalla eliminar animal ](doc/img/img_manual/pantallaBorrarAnimal.png)

## Pantalla de creación dun rexistro
Ao pulsar no botón de Engadir rexistro, ábrese unha pantalla nova para o seguinte rexistro que lle toque a esa vaca en concreto:
- Se non hai ningún rexistro, abrirá o rexistro de unha inseminación
- Se o último rexistro é unha inseminación, abrirá o rexistro de 1ª revisión.
- Se o último rexistro é unha 1ª revisión:
    - Abrirá o rexistro de inseminación se o resultado da 1ª revisión foi negativo.
    - Abrirá o rexistro de 2ª revisión se o resultado da 1ª revisión foi positivo.
- Se o último rexistro é unha 2ª revisión:
    - Abrirá o rexistro de inseminación se o resultado da 2ª revisión foi negativo.
    - Abrirá o rexistro de secado se o resultado da 1ª revisión foi positivo.
- Se o último rexistro é un secado, abrirá o formulario de parto.
- Se o último rexistro é un parto, abrirá o rexistro dunha nova inseminación.

![Pantalla novo rexistro ](doc/img/img_manual/pantallaEngadirRexistro.png)

## Pantalla de visualización de rexistros
Esta pantalla ábrese ao pulsar o botón Ver rexistros na pantalla principal, que mostrará todos os rexistros desa vaca separados por tipos de rexistros.

![Pantalla ver rexistros ](doc/img/img_manual/pantallaVerRexistros.png)

## Pantalla de eliminación de rexistro
Ao pulsar o botón de eliminar rexistro, abrirá unha ventana que preguntará se o usuario está seguro de borrar o último rexistro da vaca

![Pantalla eliminar rexistro ](doc/img/img_manual/pantallaBorrarRexistro.png)

## Pantalla de xestión de toros
Esta pantalla ábrese ao pulsar no item Toros no menú da pantalla principal. Nesta pantalla xestiónase todo o que ten que ver cos toros:
- Tabla do rexistro de toros
- Información do toro
- Botón de modificar toro
- Botón de eliminar toro
- Item no menu de novo toro
![Pantalla xestión toros ](doc/img/img_manual/pantallaToros.png)

## Pantalla de Novo toro
Esta pantalla ábrese ao pulsar o item "Novo toro" do menu, e nela pódese crear un toro novo con toda a información deste
![Pantalla eliminar toro ](doc/img/img_manual/pantallaNovoToro.png)

## Pantalla Modificar toro
Esta pantalla ábrese ao pulsar no botón modificar da pantalla de xestión de toros, e nela pódese modificar a información do último toro seleccionado.
![Pantalla modificar toro ](doc/img/img_manual/pantallaModificarToro.png)

## Pantalla Eliminar toro
Ao pulsar no botón eliminar da pantalla de xestión de toros, abrirase unha ventana que preguntará se se quere eliminar realmente o toro seleccionado.
![Pantalla eliminar toro ](doc/img/img_manual/pantallaBorrarToro.png)

## Pantalla Próximas Tarefas
Ao pulsar o item Próximas tarefas abrirase unha ventana de impresión previa pra axustar a impresión do informe das próximas tarefas, ao pulsar o botón aceptar abrirase a vista previa do informe onde aparecerán:
- As vacas listas para inseminar
- As novillas listas para inseminar
- As vacas e novillas listar para a 1ª revisión
- As vacas e novillas listas para a 2ª revisión
- As vacas listas para o secado
- As vacas listas para parir

![Pantalla Proximas tarefas ](doc/img/img_manual/pantallaAbrirTarefas.png)

## Pantalla de ver documentos
Na pantalla principal existen 3 botóns na sección de información da vaca, onde se pode abrir cada un dos PDF que foron gardados na información da vaca.
