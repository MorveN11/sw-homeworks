<div style="text-align: center;">

# Patrón Mediator</div>

### Author: Jheremy Kevin Tancara Zambrana - 5 A

---

El patrón Mediator es un patrón de diseño de comportamiento que promueve el acoplamiento débil entre objetos al eliminar las dependencias directas entre ellos y permitirles comunicarse a través de un objeto mediador. En lugar de que los objetos se comuniquen directamente entre sí, lo hacen a través del mediador, lo que reduce la complejidad y la dependencia en el sistema.


## Características

### Buenas

1. **Desacoplamiento**: Reduce el acoplamiento entre objetos al eliminar las dependencias directas entre ellos.
2. **Centralización**: Centraliza la comunicación entre objetos en un único lugar, lo que facilita la gestión y el mantenimiento del sistema.
3. **Flexibilidad**: Permite modificar la interacción entre objetos sin cambiar su lógica interna.

### Malas

1. **Complejidad adicional**: Introducir un mediador puede agregar complejidad al diseño del sistema, especialmente si no se maneja correctamente.
2. **Responsabilidades adicionales**: El mediador puede volverse sobrecargado si se le asignan demasiadas responsabilidades.

## Ejemplo de Implementación

En el código proporcionado, se muestra un ejemplo de implementación del patrón Mediator en un sistema de chat. La interfaz `IChatMediator` define cómo los usuarios pueden enviar mensajes a través del mediador. La clase `ChatMediator` actúa como el mediador concreto y gestiona la comunicación entre usuarios. La interfaz `IUser` define la interfaz para los usuarios del sistema de chat, mientras que la clase `User` implementa esta interfaz y utiliza el mediador para enviar y recibir mensajes.

Al utilizar el patrón Mediator en este ejemplo, se logra un acoplamiento débil entre los usuarios del sistema de chat. Los usuarios no necesitan conocerse directamente, ya que toda la comunicación se realiza a través del mediador, lo que facilita la escalabilidad y la extensibilidad del sistema.

