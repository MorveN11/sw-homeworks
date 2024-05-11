# Patrón Builder

## Descripción del Patrón
El patrón Builder se utiliza para construir objetos complejos paso a paso. Permite crear diferentes tipos y representaciones de un objeto utilizando el mismo proceso de construcción.

## Clases Principales
### Builder (Constructor)
- Define una interfaz para crear partes de un objeto complejo.

### ConcreteBuilder (Constructor Concreto)
- Implementa la interfaz del Constructor y construye y ensambla las partes del objeto bajo la dirección del Director.

### Director
- Construye un objeto utilizando el Constructor.

### Producto
- Representa el objeto complejo que se está construyendo.

## Características Importantes
- Separa la construcción de un objeto complejo de su representación.
- Permite construir objetos con diferentes representaciones utilizando el mismo proceso de construcción.
- Facilita la construcción de objetos paso a paso.

## Output Esperado del Código
Supongamos que queremos construir un objeto `Pizza` utilizando el patrón Builder.

```plaintext
Pizza: Margarita
- Masa: Delgada
- Salsa: Tomate
- Queso: Mozzarella
- Toppings: Albahaca, Tomate
