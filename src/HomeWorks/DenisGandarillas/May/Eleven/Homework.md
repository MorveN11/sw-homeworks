# <div align="center">SINGLETON ANTIPATRON</h1>
## <div align="center">PATTERN DESIGN</div>
### Denis Jorge Gandarillas Delgado

## POR QUE?

* *ACOPLAMIENTO:* Es fuertemente acoplado, lo que significa que llega a que el codigo sea poco flexible y màs dificil de mantener, debido a que cualquier cambio puede afectar a multiples partes del codigo.

* *TESTING:* Al poder ser accedido desde diferentes partes del codigo llega a ser dificultoso al momento de realizar TESTING y obstaculizar la deteccion de errores.

* *GLOBAL:* Al tener una instancia global puede conllevar a problemas de concurrencia en entornos multi-hilo donde varios procesos realizan cambios dentro de el.

* *LECTURA:* Su instanciacion global puede llevar a la poca facilidad de entender las dependencias y la estructura del programa.

* *REFACTORIZACION:* Al realizar cambios puede ser dificil, ya que requiere cambios extras en diferentes partes del codigo.

* *SOBRECARGA:* Al ser instanciados cuando la aplicacion inicia o la primera vez en ser accedida, puede llevar a la sobrecarga de inicializacion temprana en la aplicacion.