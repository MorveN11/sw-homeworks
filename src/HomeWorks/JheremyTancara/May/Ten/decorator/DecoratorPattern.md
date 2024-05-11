<div style="text-align: center;">

# Decorator Pattern</div>

### Author: Jheremy Kevin Tancara Zambrana - 5 A
---

## Descripción del Patrón
El patrón Decorator permite adjuntar nuevas funcionalidades a un objeto existente de forma dinámica y flexible, sin alterar su estructura básica. Se logra mediante la creación de clases adicionales que envuelven al objeto original y proporcionan funcionalidades adicionales.

## Clases Principales
### Component (Componente)
- Define la interfaz para los objetos que pueden tener responsabilidades adicionales adjuntas dinámicamente.

### ConcreteComponent (Componente Concreto)
- Implementa la interfaz del Componente y define el objeto al que se pueden agregar responsabilidades adicionales.

### Decorator (Decorador)
- Mantiene una referencia a un objeto Componente y define una interfaz que se ajusta a la interfaz del Componente.

### ConcreteDecorator (Decorador Concreto)
- Agrega responsabilidades adicionales al componente.

## Características Importantes
- Permite extender las funcionalidades de los objetos de forma dinámica y flexible.
- Proporciona una alternativa a la subclase para extender funcionalidades.
- Permite que los objetos sean decorados con múltiples responsabilidades adicionales.

---

## Output Esperado del Código
Supongamos que tenemos un objeto básico al que queremos agregar características adicionales utilizando el patrón Decorator.

```plaintext
Descripción: Café, con leche, con chocolate
Costo: $4.50
