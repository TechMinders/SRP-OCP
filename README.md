Esta es una adaptación del ejercicio original: https://github.com/Steve-Fenton/TarnishedRose

## Ejercicio

Partimos de un "Legacy Code" que sabemos que funciona gracias a una bateria de pruebas y que debemos refactorizar.

Los pasos a seguir son los siguientes:
1. Pasar los test en verde.
2. Refactorizar aplicando SOLID.
3. Volver a pasar los test en verde.

## Requerimientos
Hola y bienvenidos al equipo de Gilded Rose. Como saben, somos una pequeña posada con una ubicación privilegiada en una ciudad prominente dirigida por una amigable posadera llamada Allison. También compramos y vendemos los mejores productos. Desafortunadamente, nuestros productos están degradando constantemente su calidad a medida que se acercan a su fecha de venta. Tenemos un sistema que actualiza nuestro inventario. Fue desarrollado por un tipo sin sentido llamado César, que se ha ido a dar la vuelta al mundo. Vuestra tarea es refactorizar nuestro sistema para allanar el camino para la introducción de próximos artículos. Primero una introducción a nuestro sistema:

- Todos los artículos tienen un valor "SellIn" que indica la cantidad de días que tenemos para vender el artículo.
- Todos los artículos tienen un valor "Quality" que indica lo valioso que es el artículo.
- Al final de cada día, nuestro sistema reduce ambos valores para cada artículo.
- El precio de los artículos se actualiza en base a su calidad multiplicado por un valor constante.

Bastante simple, ¿No? Bueno, aquí es donde se pone interesante:

 - Una vez que la fecha de caducidad ha pasado, la calidad se degrada el doble de rápido.
 - La calidad de un artículo nunca es negativa.
 - "Aged Brie" en realidad aumenta en calidad cuanto más viejo se hace.
 - La calidad de un artículo nunca supera los 50.
 - El artículo "Aged Brie", aumenta la calidad a medida que se acerca el valor de "SellIn";

Solo para aclarar, un artículo nunca puede aumentar su calidad por encima de 50.



Solución ejercicio:

La refactorización se ha basado en la creación de una clase para cada producto que herada de la clase Item. Esta clase implementa tres nuevas propiedades para cada uno de los comportamientos de Quality, SellIn y Price. Los mismo sucede para los tipos de comportamiento Quality, SellIn y Price.
Implementamos también una clase time que es la encarga que transcurra el tiempo y por tanto la de implementar el paso del tiempo para Quality, SellIn y Price.

De esta forma hemos conseguido desaclopar el comportamiento de Quality, SellIn y Price tanto entre ellas como de los propios productos. Lo que nos permite que ante la necesidad de implementar un nuevo producto que solo sea necesario indicarle el tipo de Quality, SellIn y Price que requiera, sin necesidad de escrivir código de nuevo. En el caso de la necidad de implementar un nuevo tipo de Quality, SellIn y Price, solo debemos crear su correspondiente clase y modificar la calse Quality.

Debemos destacar que existe un smell o rotura del principio open/close ante la necesidad de implementar un nuevo tipo de Quality, SellIn y Price tanto en las mismas clases como en la clase Time, que resolveremos en futuros meetups mediante el principio de inversión de dependencias.

Debemos destacar que después de refactorizar y testear nuestro código con los testcases iniciales, hemos implementado una nueva red de testcase basados en la nueva arquitectura de clases. Esta modificación nos permite el testeo unitario de cada clase independientemente y podemos dejar como deperecated los antiguos testcases basados en un código legacy. De esta forma cualquier modificación que hagamos en una clase será fácilmente testeable, no a nivel de cobertura de testcase, sino a nivel funcional de la misma modificación.
