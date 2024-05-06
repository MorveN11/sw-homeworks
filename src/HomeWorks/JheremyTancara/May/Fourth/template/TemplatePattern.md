<div style="text-align: center;">

# Patrón Template</div>

### Author: Jheremy Kevin Tancara Zambrana - 5 A

El patrón Template Method es un patrón de diseño de comportamiento que define el esqueleto de un algoritmo en un método y delega algunos pasos a subclases. Esto permite que las subclases redefinan ciertos pasos del algoritmo sin cambiar su estructura general.

## Explicación de las clases

- **`ReportGenerator.cs`**: Define una clase abstracta `ReportGenerator` que contiene un método `GenerateReport`, que actúa como el método plantilla. Este método contiene la estructura general para generar un informe, delegando algunos pasos a métodos abstractos que deben ser implementados por las subclases.

- **`SalesReportGenerator.cs`**: Implementa la generación de un informe de ventas. Hereda de `ReportGenerator` y proporciona implementaciones específicas de los métodos abstractos para inicializar, cargar datos, formatear y exportar el informe de ventas.

- **`CustomerReportGenerator.cs`**: Implementa la generación de un informe de clientes. Hereda de `ReportGenerator` y proporciona implementaciones específicas de los métodos abstractos para inicializar, cargar datos, formatear y exportar el informe de clientes.

- **`InventoryReportGenerator.cs`**: Implementa la generación de un informe de inventario. Hereda de `ReportGenerator` y proporciona implementaciones específicas de los métodos abstractos para inicializar, cargar datos, formatear y exportar el informe de inventario.

## Características Importantes

- **Reutilización de código**: Los pasos comunes del algoritmo se definen en la clase base (`ReportGenerator`), lo que permite reutilizar el código en las subclases.
- **Consistencia**: El algoritmo es consistente en todas las subclases, ya que la estructura general está definida en el método plantilla (`GenerateReport`).
- **Flexibilidad**: Los pasos específicos del algoritmo pueden ser redefinidos por las subclases, permitiendo la personalización del comportamiento.

## Beneficios

- **Facilidad de mantenimiento**: Los pasos comunes están centralizados en la clase base, lo que facilita el mantenimiento y la actualización del código.
- **Simplicidad en las subclases**: Las subclases se centran en implementar los pasos específicos del algoritmo, reduciendo la complejidad.
- **Consistencia de flujo**: El flujo del algoritmo es consistente entre todas las subclases, lo que ayuda a mantener un comportamiento predecible.

## Desventajas

- **Rigidez**: Las subclases están limitadas por la estructura definida en el método plantilla, lo que puede limitar su flexibilidad en algunos casos.
- **Sobrecarga inicial**: La implementación inicial puede requerir más esfuerzo para definir el método plantilla y las subclases necesarias.

## Output

- **Generando informe de ventas:**
    - **Inicializando informe de ventas...**
        - Este paso prepara el informe para su generación, configurando información inicial necesaria.
    - **Cargando datos de ventas...**
        - Los datos de ventas se cargan desde la fuente de datos correspondiente.
    - **Formateando informe de ventas...**
        - Los datos de ventas se formatean según los requisitos del informe.
    - **Exportando informe de ventas a PDF...**
        - El informe de ventas se exporta a un archivo PDF.

- **Generando informe de clientes:**
    - **Inicializando informe de clientes...**
        - Se prepara el informe para su generación, configurando información inicial necesaria.
    - **Cargando datos de clientes...**
        - Los datos de clientes se cargan desde la fuente de datos correspondiente.
    - **Formateando informe de clientes...**
        - Los datos de clientes se formatean según los requisitos del informe.
    - **Exportando informe de clientes a Excel...**
        - El informe de clientes se exporta a un archivo Excel.

- **Generando informe de inventario:**
    - **Inicializando informe de inventario...**
        - Se prepara el informe para su generación, configurando información inicial necesaria.
    - **Cargando datos de inventario...**
        - Los datos de inventario se cargan desde la fuente de datos correspondiente.
    - **Formateando informe de inventario...**
        - Los datos de inventario se formatean según los requisitos del informe.
    - **Exportando informe de inventario a CSV...**
        - El informe de inventario se exporta a un archivo CSV.

Estos outputs muestran cómo se generan los informes para diferentes tipos de datos (ventas, clientes e inventario) utilizando el método plantilla definido en `ReportGenerator` y personalizado por las subclases `SalesReportGenerator`, `CustomerReportGenerator` e `InventoryReportGenerator`. Cada subclase implementa los métodos abstractos de `ReportGenerator` para proporcionar su propia lógica para cargar datos, formatear el informe y exportar el resultado. Esto demuestra cómo el patrón Template Method permite la reutilización de código y la consistencia en la estructura de los algoritmos, mientras que también permite la flexibilidad en las implementaciones específicas de las subclases.
