# blanco-clases-objetos
# Control de Inventario - TecnoPunto

## Datos del presentante
* **Nombre:** Britney Blanco
* **Matrícula:** 2025-3111
* **Asignatura:** Programación Básica
* **Profesor:** Gamalier Reyes del Carmen

## Descripción del programa
Desarrolle Aplicación de consola en C# para gestionar el inventario de la tienda **TecnoPunto**. El programa modela la entidad `Producto` Para lograrlo, diseñé la clase Producto aplicando encapsulamiento mediante campos privados y propiedades públicas con validaciones en sus bloques `set`, además de una propiedad de solo lectura que calcula automáticamente el valor total de cada artículo en existencia.

## Datos de entrada
Por cada uno de los 3 productos registrados, el usuario ingresa por teclado:
* **Código (`string`):** Identificador del producto.
* **Nombre (`string`):** Nombre o descripción del producto (no puede estar vacío).
* **Precio (`double`):** Precio unitario del artículo (debe ser mayor que `0`).
* **Cantidad (`int`):** Cantidad disponible en inventario (debe ser mayor o igual a `0`).

## Datos que procesa
**Validación de integridad:** Verifico tanto en los bloques `set` de las propiedades como en los bucles de entrada en `Main` que el nombre contenga texto, el precio sea mayor que `0` y la cantidad sea mayor o igual a `0`, pidiendo nuevamente el dato si hay algún error sin que el programa se cierre.
* **Cálculo de valor en existencia:** Multiplico el `Precio` por la `Cantidad` dentro de la propiedad de solo lectura `ValorTotal`.

  
## Datos de salida
Una vez que termino de registrar los 3 productos, muestro en la consola la información completa de cada objeto mediante el método `MostrarInfo()`:
* Código del producto
* Nombre del producto
* Precio unitario
* Cantidad en existencia
* Valor total en inventario (`Precio * Cantidad`)
  
## Capturas de la ejecución


<img width="1135" height="703" alt="Screenshot (140)" src="https://github.com/user-attachments/assets/a17da65a-1570-4f90-bc33-419ee85b78eb" />




<img width="1366" height="768" alt="Screenshot (146)" src="https://github.com/user-attachments/assets/15447200-45f2-4c63-bd44-25787106203c" />



<img width="1366" height="768" alt="Screenshot (145)" src="https://github.com/user-attachments/assets/61ad9ce7-6825-4e9d-b784-a78d856e7914" />
