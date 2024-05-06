<div style="text-align: center;">

# Patrón Strategy</div>

### Author: Jheremy Kevin Tancara Zambrana - 5 A

---

El patrón Strategy es un patrón de diseño de comportamiento que permite definir una familia de algoritmos, encapsular cada uno de ellos en una clase separada y hacerlos intercambiables. Esto significa que se puede cambiar la estrategia utilizada para ejecutar un algoritmo en tiempo de ejecución sin modificar el código que utiliza la estrategia.

---

## Explicacion de las clases

- `TravelStrategy.cs`: Define la interfaz `TravelStrategy` para las estrategias de cálculo.
- `AirTravelStrategy.cs`: Implementa la estrategia de cálculo para viajes aéreos.
- `LandTravelStrategy.cs`: Implementa la estrategia de cálculo para viajes terrestres.
- `SeaTravelStrategy.cs`: Implementa la estrategia de cálculo para viajes marítimos.
- `TravelCalculator.cs`: Define una clase `TravelCalculator` que tiene una estrategia de cálculo (`HasA`) y calcula el costo utilizando la estrategia específica.


## Características Importantes

- **Intercambiabilidad**: Las estrategias son intercambiables entre sí, lo que significa que se puede cambiar la estrategia utilizada en tiempo de ejecución sin afectar al código que la utiliza.
- **Encapsulamiento**: Cada estrategia está encapsulada en una clase separada, lo que facilita el mantenimiento y la gestión de las estrategias.
- **Cohesión**: Las estrategias se centran en una tarea específica, lo que mejora la cohesión del código.

## Beneficios

- **Flexibilidad**: Se pueden cambiar las estrategias en tiempo de ejecución, permitiendo una mayor flexibilidad en el comportamiento del programa.
- **Mantenimiento**: Al tener cada estrategia encapsulada en su propia clase, es más fácil mantener y actualizar las estrategias.
- **Modularidad**: Las estrategias están separadas del código que las utiliza, lo que permite que el código sea más modular y organizado.

## Desventajas

- **Complejidad adicional**: Puede añadir complejidad al diseño, especialmente si se tienen muchas estrategias diferentes.
- **Gestión de estrategias**: El código debe manejar la elección de la estrategia adecuada en tiempo de ejecución, lo que puede complicar el código.

## Output

- **Costo de viaje aéreo para 2 pasajeros en 1000 km: 500**
    - La estrategia de viaje aéreo (`AirTravelStrategy`) calcula el costo basándose en una tarifa por kilómetro (0.3) y un costo por pasajero (100 por pasajero).
    - Para un viaje de 1000 km con 2 pasajeros, el costo se calcula como: `(1000 km * 0.3) + (2 pasajeros * 100) = 300 + 200 = 500`.
    - El resultado de 500 es el costo total del viaje aéreo para 2 pasajeros en 1000 km.

- **Costo de viaje terrestre para 2 pasajeros en 1000 km: 170**
    - La estrategia de viaje terrestre (`LandTravelStrategy`) calcula el costo basándose en una tarifa por kilómetro (0.15) y un costo por pasajero (10 por pasajero).
    - Para un viaje de 1000 km con 2 pasajeros, el costo se calcula como: `(1000 km * 0.15) + (2 pasajeros * 10) = 150 + 20 = 170`.
    - El resultado de 170 es el costo total del viaje terrestre para 2 pasajeros en 1000 km.

- **Costo de viaje marítimo para 2 pasajeros en 1000 km: 350**
    - La estrategia de viaje marítimo (`SeaTravelStrategy`) calcula el costo basándose en una tarifa por kilómetro (0.25) y un costo por pasajero (50 por pasajero).
    - Para un viaje de 1000 km con 2 pasajeros, el costo se calcula como: `(1000 km * 0.25) + (2 pasajeros * 50) = 250 + 100 = 350`.
    - El resultado de 350 es el costo total del viaje marítimo para 2 pasajeros en 1000 km.
