<div style="text-align: center;">

# Patrón Abstract Factory</div>

### Author: Jheremy Kevin Tancara Zambrana - 5 A

---

El patrón Abstract Factory proporciona una interfaz para crear familias de objetos relacionados o dependientes sin especificar sus clases concretas. Se basa en el principio de diseño de interfaces, no en implementaciones, lo que permite que las fábricas concretas produzcan productos compatibles sin especificar sus clases concretas.

## Características

- **Abstracción de Fábrica:** Permite la creación de objetos relacionados sin la necesidad de conocer las clases concretas.
- **Familias de Productos:** Proporciona una interfaz para crear familias de productos relacionados.
- **Desacoplamiento:** Promueve el desacoplamiento entre el cliente y las clases concretas de productos.

## Ventajas

- **Flexibilidad:** Permite cambiar fácilmente la familia de productos que se están utilizando.
- **Escalabilidad:** Permite agregar nuevas variantes de productos sin modificar el código existente.
- **Desacoplamiento:** Reduce la dependencia entre el cliente y las clases concretas de productos.

## Desventajas

- **Complejidad:** Añade complejidad al código al introducir múltiples jerarquías de abstracción y múltiples implementaciones.
- **Diseño Adicional:** Requiere la creación de múltiples interfaces y clases concretas adicionales.
- **Posible Sobrecarga:** Puede haber una sobrecarga de clases e interfaces si no se utiliza correctamente.

## Cuándo Usarla

- **Múltiples Familias de Productos:** Cuando el sistema necesita soportar múltiples familias de productos y se quiere evitar el acoplamiento entre el cliente y las clases concretas.
- **Escalabilidad:** Cuando se espera que el conjunto de productos cambie o crezca con el tiempo, y se desea una estructura de código flexible y extensible.

El patrón Abstract Factory es especialmente útil en sistemas donde la creación de objetos es una parte central y compleja del diseño, como en aplicaciones de interfaz de usuario y juegos. Permite una fácil expansión y mantenimiento del código a medida que el sistema evoluciona.
