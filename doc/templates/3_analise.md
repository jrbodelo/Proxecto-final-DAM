# REQUIRIMENTOS DO SISTEMA
Este documento describe os requirimentos para **ReproCow** especificando que funcionalidade ofrecerá e de que xeito.

## Descrición Xeral

Este proxecto consiste nunha aplicación informática que ten como obxectivo xestionar a parte de reprodución dunha gandería de ganado vacún, onde se atopará tanto información necesaria de cada animal como o seu estado no ciclo de reprodución e un histórico de todos os procesos polos que pasou anteriormente. 

## Funcionalidades

O uso principal desta aplicación é para consulta de datos ou estados das vacas principalmente, de forma que toda aplicación está traballando cunha base de datos donde garda, mostra, modifica ou elimina os datos que o gandeiro introduce, consulta, modifica ou borra.

As funcionalidades da aplicación pódense dividir en dous apartados:
1. **Datos persoais do animal**: neste apartado pódense distinguir as seguintes funcionalidades, todas elas relacionadas ca base de datos mencionada:
- Dar de alta / modificar / consultar / eliminar unha vaca ou novilla, do que se garda toda a súa información persoal (data de nacemento, nome, apelidos, crotal..) e tamén permite engadir ou eliminar os ficheiros que se necesitan del: carta de rexistro (como un pasaporte animal), ficheiro de xenómica (resultado das probas xenéticas) e ficheiro de acoplamento (listado de toros dispoñibles cos que o animal é compatible xenéticamente). Deste último permite gardar varios, pois dependendo do ano, haberá dispoñibles uns ou outros.

- Dar de alta / modificar / consultar / eliminar un toro, do que se garda a súa información persoal: crotal, nome, apelidos e número de dosis que hai en stock na gandería. Desta forma cada vez que se utilice unha dosis de un toro para inseminar a unha vaca, descontarase do seu stock.

2. **Estados da vaca**: na base de datos hai tablas que se utilizan para:
- Dar de alta / modificar / consultar / eliminar unha inseminación: neste rexistro indicarase tamén o toro co que foi inseminada.
- Dar de alta / modificar / consultar / eliminar unha revisión: a vaca fánselle 2 revisións durante o ciclo de reprodución, unha aos 30 días e outra aproximandamente aos 90 días da inseminación. Nesta última revisión poderá indicarse o número de crías en caso de que sexa máis de 1 e o sexo destas. Nas dúas revisións poderá indicarse se o resultado da proba de embarazo é positivo ou negativo. No caso de ser negativo a vaca pasaría a estar outra vez lista para inseminar.
- Dar de alta / modificar / consultar / eliminar un secado: aos 7 meses da inseminación, no caso de que sexa positivo o resultado das revisións, poderase secar a vaca, gardando o rexistro aquí.
- Dar de alta / modificar / consultar / eliminar un parto: aos 9 meses a aplicación avisará de que a vaca saliu de contas, e permitirá gardar un rexistro do parto, onde se anotará o número de crías, o sexo de cada cría e o tamaño.

Ademais destas funcionalidades, a aplicación terá a funcionalidade de imprimir informes, nos que según o día que se imprime, terá anotadas as vacas que están listas para inseminar, pendentes da 1ª revisión, pendentes da 2ª revisión, pendentes de secado e listas para parir nos próximos días. Esta funcionalidade é moi útil, pois permite imprimir en papel todo isto, ir con este papel á gandería e ter unha lista de que lle hai que facer a cada vaca, por exemplo cando o veterinario quere facer as revisións.

## Tipos de usuarios

Só existirá un tipo de usuario da aplicación, que poderá engadir, modificar, consultar e eliminar os datos que necesite sen ningún impedimento. Desta forma, a diferencia de outros programas similares comentados anteriormente, este permitiría ao usuario realizar as xestións que necesite libremente. Esta liberdade que se lle permite ao usuario é outro dos factores distintivos desta aplicación.
 
## Entorno operacional

### Hardware requerido

O tamaño da aplicación e o nivel de procesamento que necesita é moi reducido, polo que calquera ordenador actual será capaz de soster o funcionamento desta aplicación. 

### Software

Esta aplicación só pode ser instalada e utilizada en Windows, polo que será necesario ter este sistema operativo, a partir da versión Windows XP, esta incluída.
Para utilizar a aplicación será necesario instalala utilizando o instalador descargado.

Ademais, será preciso ter instalado o MySql Server e o MySql Workbench para crear a base de datos.

## Interfaces externos

### Interfaces de usuario

A aplicación consta de varias pantallas coas funcionalidades descritas anteriormente:
- A pantalla principal que mostrará un listado das vacas gardadas na base de datos e a información máis relevante sobre cada unha Contará tamén cun unha opción no menú, de engadir vaca, que abrirá unha pantalla nova para dar de alta unha vaca.
- Ao pinchar en cada vaca a pantalla cambia e mostrará todos os datos da vaca, así como :
  - Os botóns necesarios para abrir os pdf explicados con anterioridade.
  - Modificar ou borrar a vaca
  - Engadir un rexistro, que abrirá unha pantalla ca información necesaria para engadir o seguinte rexistroq que lle toca a esa vaca (por exemplo, se o último rexistro  é unha inseminación, abrirase un formulario para engadir unha 1ª Revisión).
  - Ver todos os rexistros, que abrirá unha pantalla nova na que aparecerán todos os rexistros desa vaca, separados por tipos.
  - Eliminar último rexistro: no caso de que o gandeiro se equivoque introducindo os datos, ten así a opción de borrar o rexistro e volver a crealo.
- Este menú tamen conta ca opción de **Tarefas pendentes**, unha opción importante e que é de gran utilidade, ca que outros programas existentes non contan. Ao pinchar nesta opción, abrirase outra pantalla, na que aparecerá en forma de informe as tarefas que ten pendentes o gandeiro:
  - Vacas listas para inseminar
  - Vacas listas para a 1ª revisión
  - Vacas listas para a 2ª revisión
  - Vacas listas para o secado
  - Vacas listas para parir nos próximos 15 días.
- A aplicación consta tamén no seu menú dunha opción **Toros**, que ao pinchar abre outro formulario onde aparece unha táboa con todos os toros, e ao pinchar en cada un, mostra a información do toro. Conta tamén con botóns para engadir, modificar e borrar o toro.

### Interfaces hardware

As interfaces hardware cas que contará o usuario son as dun ordenador normal: monitor, teclado e rato.

### Interfaces software


## Melloras futuras

Como a intención desta aplicación é simplificar o máximo posible toda a xestión descrita, as melloras que se lle pode facer a esta van orientadas a seguir simplificándoa e automatizándoa. Así, as melloras máis solicitadas para futuras versións desta aplicación están centradas en automatizar o rexistro de vacas e novillas. Acceder á base de datos da Consellería de Medio Rural permitiríanos procesar todos os datos que hai gardados dos animais de unha gandería, evitando que o gandeiro teña que facer o rexistro dun animal na aplicación. Ademáis, desta forma podería gardar todos os datos do animal, en lugar de gardar un pdf con todos estes datos como fai actualmente, e desta forma poderíanse procesar para facer estadísticas ou outras operacións de interés con eles. O mesmo se podería facer co ficheiro de xenómica e o de acoplamento.

Unha das aplicacións que se poderían facer nun futuro e que máis solicitada está pois non existe ningún no mercado que realice este proceso, sería unha aplicación que descargue da base de datos de CONAFE (onde se garda a producción de leite de cada vaca dunha gandería) os litros que dou unha vaca nun período de producción (desde o parto ata o seguinte secado) ademais das calidades do leite producido (niveles de grasa, proteína e fibra). Estes datos servirían para calcular o beneficio económico que ten cada vaca, pois utilizando o contrato de compra de leite (onde aparece o prezo base do leite e as primas por niveles de grasa e proteína) permitiría saber exactamente canto lle reporta cada vaca ao gandeiro por período de producción. Desta forma é máis fácil ver se unha vaca que produce menos leite pero mellores calidades lle reporta máis beneficio que unha que produza máis litros pero de menos calidade, segundo o nivel de calidades e o contrato que teña vixente o gandeiro ca empresa leiteira.

Esta aplicación sería un novo módulo que o gandeiro podería comprar e despregar no seu ordenador da mesma forma que a de xestión da reproducción. O seu nome provisional sería **BenefitCow**.
