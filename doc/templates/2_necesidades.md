# ESTUDO DE NECESIDADES E MODELO DE NEGOCIO

## Xustificación das necesidades detectadas que cubre o sistema a desenvolver

Nos sectores secundario e terciario, a informatización da xestión da empresa está moi implantada desde fai tempo, pero esta claro que no sector primario existe pero non está tan extendida. Así, no medio rural, en canto a informatización de ganderías de gando vacún, obsérvase varios tipos de ganderías:
- Ganderías grandes (máis de 200 vacas) con toda a súa xestión informatizada.
- Ganderías medianas (entre 100 e 200 vacas) con parte da súa xestión informatizada.
- Ganderías pequenas (menos de 100 vacas) que levan a súa xestión da forma antiga.

No caso das ganderías grandes, xa existen programas profesionais que lle permiten levar toda esta xestión, pero teñen a unha persoa que dedica toda ou parte da súa actividade laboral a levar todo ao día.

A necesidade xorde observando as ganderías medianas: estas ganderías teñen, en moitos casos, implantados os programas profesionais de xestión que teñen as ganderías grandes, pero só utilizan as funcionalidades máis útiles destes, aínda que paguen o programa completo. Isto débese a que non lles é posible pagar a unha persoa que lles leve toda a xestión ao día, ou os propios gandeiros non poden invertir o tempo necesario en levar iso ao día, polo que utilizan as funcionalidades do programa que sí lles resulta moi útil.

Estas ganderías as funcionalidades que máis utilizan destes programas son sin dúbida as relacionadas ca reproducción das vacas, pois resúltalles cómdo apuntar os procesos do ciclo de reproducción polos que vai pasando cada animal, e que o programa lle avise en qué momento da xestación e que procesos ten que levar a cabo o gandeiro con cada animal.

Estes programas cubren esta funcionalidade, pero de forma moi complexa, polo que as veces lles complica bastante a vida aos gandeiros que en moitos casos non teñen coñecementos de informática e o que precisan é un programa que lles cubra esta necesidade pero dunha forma máis sinxela e clara.

No caso de que se cubrira esta necesidade, moitas ganderías pequenas estarían interesadas en informatizar esta parte da súa xestión, pois actualmente utilizan uns calendarios con símbolos donde van apuntando o proceso polo que pasa cada vaca, pero seríalle moito máis cómodo ter toa a información da vaca xunto ca información da reproducción da vaca, pois neste tipo de ganderías, ao ser de producción limitada, apóstase moitas veces pola calidade do leite en vez de pola cantidade, e para iso é moi importante a reproducción. A estas vacas fáiselle unha proba xenética onde aparecen todas as súas mellores cualidades xenéticas, así como as súas debilidades (problemas ou enfermidades xenéticas que aparecen nos seus xenes) e desta forma búscase o toro que xeneticamente encaixe mellor con ela, é dicir, que complemente as súas mellores cualidades e cubra as debilidades para que a descendencia teña a mellor parte dos dous. O poder ter toda esta información informatizada sería unha gran comodidade, en lugar de buscar papeles en arquivadores para buscar toda a información de cada vaca. 

Desta forma, un programa que sexa capaz de levar toda esta xestión dunha forma sinxela e clara, sería moi ben recibido polas ganderías de pequeno e mediano tamaño.

O programa debe ter dúas funcionalidades básicas que deben ser fáciles de visualizar, entender e utilizar:
- Creación, Modificación, Consulta e Borrado dos datos de cada vaca, que permitirá ademais de consultar os datos básicos de cada animal, poder engadir a carta de rexistro, a proba de xenómica e a proba de acoplamento, todas estas en formato PDF e poder consultalas cando sexa necesario.
- Rexistrar inseminacións, revisións, secados e partos de cada vaca así como consultar o seus historial de rexistros. Tamén sería necesario poder eliminar rexistros en caso de que se introduza mal algún dato deste.

A idea deste programa leva a pensar na posibilidade de crear un proxecto maior que sexa modular, é dicir, este sería un módulo que se podería acoplar con outros módulos ou non, pois pode funcionar de forma independiente a igual que os outros módulos, de forma que cada módulo se encargue dunha parte da xestión da explotación, e así os gandeiros merquen e utilicen os módulos que lles sexan útiles ou necesarios, e así evitar que teñan que facer un desenvolvo grande por programas dos que non se aproveitan todas as funcionalidades.

Para a creación da versión beta do primeiro programa necesítanse unhas 30 horas aproximadamente, polo que se conta sobradamente co tempo que se necesita, e o tempo restante será útil para realizar as probas necesarias con datos reais.

## Posibilidades de comercialización (viabilidade, competidores…).

### Viabilidade

O desenvolvemento do proxecto non tería en principio ningún tipo de obstáculo técnico, pois non sería necesario nada máis que un pc con Visual Studio, un Sistema Xestor de Bases de Datos, que neste caso é MySql e os coñecementos técnicos para a creación, despregamento e posta en marcha do programa.

Existen certas complicacións polas que o proxecto se desenvolve desta forma, pois hai certas cousas que se poderían mellorar pero que non é posible para esta versión do programa pois require máis tempo e máis coñecementos técnicos, que se podería desenvolver en futuras versións do programa. Unha funcionalidade que estaría ben desenvolver no futuro con máis tempo e máis coñecementos técnicos sería a posibilidade de dar de alta novas vacas: cando nace un animal o gandeiro ten a obriga de rexistralo, é decir, dalo de alta como novo animal da gandería na Oficina Virtual de Gandería, páxina responsabilidade da Consellería do Medio Rural. Estes teñen unha base de datos con todos os animais da gandería, de tal forma que se a aplicación se poidera conectar a ela, non faría falta dar de alta ou de baixa ningún animal pois xa estaría feito na base de datos da Consellería.

O mesmo pasaría cos outros documentos que o gandeiro tería que descargar a man e engadir no programa para cada animal: o ficheiro de xenómica e o de acoplamento.

Porén, estas funcionalidades non serían fundamentais para o programa inicial, pois dar de alta e engadir o ficheiro de xenómica faríase unha vez na vida do animal. Non así o ficheiro de acoplamento que se poderían engadir varios para cada animal (cada vez que se queira inseminar pódese solicitar un fichero de acoplamento), pero isto non sei fai case nunca, só se solicita para vacas moi concretas.

En canto a viabilidade económica do proxecto, este programa ten unha licencia de software comercial, de forma que o gandeiro que quixera instalalo tería que pagar por el. Os neste proxecto estarían fundamentalmente na parte de distribución e promoción de software, que serían gastos moi específicos que se explicarán máis adiante, polo que o gasto non será alto. Desta forma, o prezo do producto pode ser máis asequible para que aos gandeiros non lles supoña un gasto importante acceder a el, como ocorre actualmente. Desta forma espérase que o número de compras sexa maior e esta financiación axude a desenvolver outros módulos para o programa. 

### Competencia

Todas os programas coñecidos e extendidos ata agora son programas de moita complexidade, no que se pode xestionar todos os aspectos dunha explotación gandeira. Isto, para ganderías grandes que se poidan permitir a unha persoa dedicada en levar toda esta xestión ao día, é moi útil e moi produtivo, pois ter toda esta xestión en papeis e arquivadores sería moi tedioso á hora de querer ver toda a información dun animal ou facer algun tipo de trámite ou rexistro.

O programa máis extendido é UNIFORM-Repro, que permite levar o control da reprodución, da produción de leite, dos gastos, dos tratamentos...

Lóxicamente, este proxecto non pretende competir con programas como UNIFORM-Repro, pois a intención é simplificalo e recoller só os servicios fundamentais que necesiten os gandeiros medianos e pequenos. Este proxecto ten como obxectivo as pequenas e medianas ganderías, polo que para iso si sería un produto competitivo, debido que se axusta máis ás necesidades deste: funcionalidades fundamentais, fácil de utilizar e precio asequible.


## Ideas para a súa comercialización.

### Promoción

Está claro que o programa está enfocado a un nicho de mercado moi definido: gandeiros de vacún. Por iso, a promoción será moi específica, conseguindo así a máxima difusión dentro do noso público obxectivo por un custo reducido. A promoción centrarase en 4 puntos:
- Feiras de gando ou agrícolas: un porcentaxe moi elevado de xente que acude a este tipo de eventos son gandeiros, polo que montar un stand polo que pasa a xente e poder explicar e mostrar a este público o funcionamento do programa e ademais facer algún tipo de promoción de compra na que se faga unha pequena rebaixa para atraer ao público sería unha peza fundamental para a promoción. Feiras como a Semana Verde de Silleda ou o Concurso Nacional de Frisona de Gijón, son eventos aos que acode un número importante de gandeiros, polo que serían as opcións principais.
- Creación dunha páxina web: nela daríaselle información a todo aquel que desexe descargar a nosa aplicación, e sería tamén o punto de venta e descarga da nosa aplicación, polo que é importante que a imaxe e contido desta esté moi coidado e se vexa o máis profesional posible.
- Revistas, Redes Sociais e Páxinas Web de asociacións de gandeiros: en xeral, os gandeiros a miúdo len estas revistas ou visitan as redes sociais deste tipo de asociacións pois nelas encontran noticias, avances ou melloras que lles poden interesar aplicar na súa explotación, polo que pagar por publicitarse nelas sería unha boa oportunidade de promoción. Tamén está a posibilidade de chamar aos responsables das revistas e explicarlle o proxecto para intentar conseguir un artículo falando do noso programa. A revista de CONAFE ( Confederación de Asociacións de Frisona Española) é unha das principais no sector, polo que sería interesante poñerse en contacto cos responsables desta revista e mirar cal sería a forma máis adecuada de publicitarnos.
- Reunións e conferencias de asociacións relacionadas con gando vacún: estas asociacións, como pode ser Xóvenes Gandeiros ou FEFRIGA (Federación de Frisona Galega) organizan conferencias ou reunións con gandeiros frecuentemente, para explicarlles algún avance que lles poida interesar para a súa gandería, polo que sería unha boa forma de promoción conseguir que se interesasen polo noso programa.

### Modelo de negocio

Este proxecto poderíaselle aplicar diferentes modelos de negocio, pero como a idea é que este programa sexa o primeiro de varios módulos creados co obxectivo de facilitar a forma de xestión da gandería, o modelo aplicado sería un modelo de pago, polo que o gandeiro pagaría por cada un dos módulos que necesite. Este primeiro programa tería un prezo que o gandeiro pagaría, e con estes beneficios poderíase seguir desenvolvendo outros módulos doutras partes das ganderías.

Tal e como está actualmente o mercado en relación aos prezos de aplicacións de xestión de ganderías, a utilidade do noso programa sería moi específico e moi reducido comparado cos outros, pero sería moito mais barato, polo que para o nicho de mercado ao que intentamos acceder sería unha opción pola que optarían.

Desta forma, con este modelo de negocio conseguimos seguir sendo competitivos nese nicho de mercado e ter beneficios para futuros proxectos.
