<div style="text-align: center;">

# Factory Pattern</div>

### Author: Jheremy Kevin Tancara Zambrana - 5 A
---

## Descripción del Patrón
El patrón Factory se utiliza para crear objetos sin especificar la clase exacta del objeto que se creará. Define una interfaz para crear objetos, pero permite a las subclases alterar el tipo de objetos que se crearán.

## Clases Principales
### Product
- Define la interfaz de los objetos que se crearán.

### ConcreteProduct
- Implementa la interfaz `Product` y representa objetos específicos que se crearán.

### Factory
- Crea objetos `Product` sin especificar su clase concreta.

## Características Importantes
- Abstrae la creación de objetos del código que los utiliza.
- Permite la creación de objetos de diferentes tipos mediante el uso de una única interfaz.
- Oculta la lógica de creación de objetos a los clientes que los utilizan.

---

## Output Esperado del Código
Supongamos que tenemos un sistema de creación de objetos utilizando el patrón Factory.

```plaintext
Producto creado: ConcreteProductA
Producto creado: ConcreteProductB
