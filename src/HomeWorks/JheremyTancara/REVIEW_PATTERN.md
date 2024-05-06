<div style="text-align: center;">

# REVIEW PATTERN</div>

### Author: Jheremy Kevin Tancara Zambrana - 5 A

## Conclusión del patrón Strategy

El patrón Strategy es una excelente opción cuando se busca flexibilidad para cambiar comportamientos en tiempo de ejecución. Permite definir diferentes estrategias o algoritmos y cambiarlos según las necesidades del programa sin modificar el código que las utiliza.

## Conclusión del patrón Template

El patrón Template es útil cuando se quiere definir el esqueleto de un algoritmo, delegando algunos pasos a las subclases. Esto permite que las subclases personalicen partes específicas del algoritmo, proporcionando flexibilidad y promoviendo la reutilización del código.

## Patrón Strategy

- **Tipo**: Composición (`HasA`).
- **Descripción**: Permite encapsular diferentes estrategias (algoritmos) en clases separadas, y luego utilizarlas de forma intercambiable.
- **Enfoque**: Las estrategias se encapsulan como objetos distintos y se pueden cambiar en tiempo de ejecución según las necesidades del programa.

## Patrón Template Method

- **Tipo**: Herencia (`IsA`).
- **Descripción**: Define un esqueleto de un algoritmo en una clase abstracta y permite que las subclases implementen pasos específicos.
- **Enfoque**: Se establece una estructura común en una clase base, y las subclases heredan y personalizan ciertos pasos del algoritmo.

## Herencia vs. Composición

- **IsA (Herencia)**: En este caso, la relación se establece cuando una clase hereda de otra, lo que significa que es una forma de establecer una relación de "es un". Por ejemplo, `CustomerReportGenerator` es una subclase de `ReportGenerator`, lo que significa que `CustomerReportGenerator` "es un" tipo de `ReportGenerator`.

- **HasA (Composición)**: Se refiere a una relación donde una clase contiene una instancia de otra clase, estableciendo una relación de "tiene un". Por ejemplo, `TravelCalculator` tiene un objeto de `TravelStrategy`, lo que significa que `TravelCalculator` tiene una estrategia de viaje (HasA).

La diferencia entre herencia y composición radica en que la herencia establece una relación jerárquica entre clases, donde una hereda propiedades y comportamientos de la otra. Por otro lado, la composición establece una relación entre objetos, donde una clase contiene a otra como miembro.

Ambos patrones tienen su propio enfoque y uso, y se pueden aplicar en diferentes contextos según los requisitos del proyecto.
