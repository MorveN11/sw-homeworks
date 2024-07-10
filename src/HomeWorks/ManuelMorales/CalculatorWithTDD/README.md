# Calculator with TDD - Manuel Morales

Esta es mi Calculadora aplicando todos los principios y practicas aprendidas
durante todo el transcuro de la asignatura de Software Development 5, Al mismo
tiempo Aplica TDD (Test Driven Development) para la creación de la misma.

Todos los tests son segregados y mockeados como se solicita en el enunciado del
trabajo.

## Cumplimientos

- La calculadora funciona tanto con operaciones de dos operandos como de una
  como ser `+` y `^` (ambas nacen de la misma interfaz `IOperation`).
- La calculadora ordena la operacion por prioridad en dos lista, una de
  operandos y otra de operadores.
- La calculadora para ejecutar toda la operacion lo hace de acuerdo al orden de
  prioridad que es el siguiente

  - `~` (Raiz Cuadrada) - Operacion de un solo operando como ser: `~ 4` = 2 ->
    Prioridad 6
  - `^` (Cuadrado) - Operacion de un solo operando como ser: `^ 3` = 9 ->
    Prioridad 5
  - `*` (Multiplicacion) - Operacion de dos operandos como ser: `3 * 2` = 6 ->
    Prioridad 4
  - `/` (Division) - Operacion de dos operandos como ser: `6 / 2` = 3 ->
    Prioridad 3
  - `+` (Suma) - Operacion de dos operandos como ser: `3 + 2` = 5 -> Prioridad 2
  - `-` (Resta) - Operacion de dos operandos como ser: `3 - 2` = 1 -> Prioridad
    1

- La operacion para ser ejectuda se envuelve en un arbol de operaciones donde
  para lograr el resultado se ejecuta de manera recursiva.
- La calculadora tiene un metodo `Calculate` que recibe un string con la
  operacion a realizar y devuelve el resultado de la misma de manera.
