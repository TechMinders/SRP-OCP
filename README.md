Esta es una adaptación del ejercicio original: https://github.com/Steve-Fenton/TarnishedRose

Ejercicio
Partimos de un "Legacy Code" que sabemos que funciona gracias a una bateria de pruebas y que debemos refactorizar.

Los pasos a seguir son los siguientes:

Pasar los test en verde.
Refactorizar aplicando SOLID.
Volver a pasar los test en verde.
Requerimientos
Hola y bienvenidos al equipo de Gilded Rose. Como saben, somos una pequeña posada con una ubicación privilegiada en una ciudad prominente dirigida por una amigable posadera llamada Allison. También compramos y vendemos los mejores productos. Desafortunadamente, nuestros productos están degradando constantemente su calidad a medida que se acercan a su fecha de venta. Tenemos un sistema que actualiza nuestro inventario. Fue desarrollado por un tipo sin sentido llamado César, que se ha ido a dar la vuelta al mundo. Vuestra tarea es refactorizar nuestro sistema para allanar el camino para la introducción de próximos artículos. Primero una introducción a nuestro sistema:

Todos los artículos tienen un valor "SellIn" que indica la cantidad de días que tenemos para vender el artículo.
Todos los artículos tienen un valor "Quality" que indica lo valioso que es el artículo.
Al final de cada día, nuestro sistema reduce ambos valores para cada artículo.
El precio de los artículos se actualiza en base a su calidad multiplicado por un valor constante.
Bastante simple, ¿No? Bueno, aquí es donde se pone interesante:

Una vez que la fecha de caducidad ha pasado, la calidad se degrada el doble de rápido.
La calidad de un artículo nunca es negativa.
"Aged Brie" en realidad aumenta en calidad cuanto más viejo se hace.
La calidad de un artículo nunca supera los 50.
El artículo "Aged Brie", aumenta la calidad a medida que se acerca el valor de "SellIn";
Solo para aclarar, un artículo nunca puede aumentar su calidad por encima de 50.

Solución:
En esta solución he implementado el patrón Factory Method
