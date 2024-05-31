<div style="text-align: center;">

# Patrón Chain of Responsibility</div>

### Author: Jheremy Kevin Tancara Zambrana - 5 A

---

El patrón Chain of Responsibility es un patrón de diseño comportamental que permite pasar solicitudes a lo largo de una cadena de manejadores. Cuando se recibe una solicitud, cada manejador decide si la procesa o la pasa al siguiente manejador en la cadena.

## Características

- **Desacoplamiento:** Permite que el remitente de una solicitud no necesite conocer qué objeto la manejará, y viceversa.
- **Flexibilidad:** Puede agregar o eliminar fácilmente nuevos manejadores o cambiar el orden de la cadena sin afectar al cliente.
- **Reusabilidad:** Los manejadores individuales pueden ser reutilizados en diferentes cadenas o contextos.

## Ventajas

- **Desacoplamiento:** Permite una interacción flexible y desacoplada entre objetos.
- **Responsabilidad única:** Cada manejador se centra en una tarea específica, lo que facilita la modificación y el mantenimiento del código.
- **Encapsulamiento:** Cada manejador encapsula su lógica de manejo, lo que facilita la comprensión y la gestión del código.

## Desventajas

- **Complejidad:** A medida que aumenta el número de manejadores y la complejidad de las cadenas, la gestión y el seguimiento pueden volverse difíciles.
- **Procesamiento garantizado:** No hay garantía de que una solicitud será manejada, lo que puede llevar a situaciones en las que ninguna cadena puede procesar la solicitud.

## Cuándo Usarla

- **Encadenamiento de Operaciones:** Cuando se necesita procesar una solicitud a través de una serie de pasos o etapas.
- **Gestión de Eventos:** Para gestionar eventos en orden secuencial o jerárquico.
- **Desacoplamiento de Componentes:** Para desacoplar el emisor de una solicitud de sus posibles destinatarios y permitir configuraciones flexibles de manejo.

El patrón Chain of Responsibility es especialmente útil en escenarios donde múltiples objetos pueden manejar una solicitud, pero no se conoce de antemano cuál será el objeto responsable en cada caso.
