Agustín Said Bazze Götte
Legajo N° 113009

1) ¿Qué diferencia hay entre un error de sintaxis y un error de lógica (falla)?

Los errores de sintaxis son fáciles de corregir ya que el mismo entorno de desarrollo nos marca donde hemos escrito mal la sentencia o también nos marca el error al momento de querer compilar nuestro programa.

Los errores de lógica son más difíciles de detectar ya que la sintaxis es correcta y el programa se compila y ejecuta correctamente. Este tipo de errores se deben a que hemos desarrollado un algoritmo incorrecto en lo que a su resolución se refiere y por lo tanto no nos arroja el resultado esperado. Un ejemplo de esto es si queremos calcular el perímetro de un rectángulo, esto se calcula sumando los cuatro lados o multiplicando el lado lateral por dos (lado A) y sumándolo al lado superior por dos (lado B)  Ax2 + Bx2.
Acá podríamos tener un error de lógica si al desarrollar el algoritmo la fórmula fuera Ax2 + B. En este caso el sistema se compilaría y ejecutaría correctamente pero el resultado arrojado no sería el esperado.

2) ¿Cuáles son los operadores de una expresión lógica?

Los operadores son:
	- Disyunción && (Y)
	- Conjunción || (O)
	- Negación ! (NOT)

3) La refactorización de código: ¿Agrega/quita funcionalidad al programa?

La refactorización de código no agrega ni quita funcionalidades, como tampoco corrige errores. La refactorización se usa para
mejorar el código, modificando la estructura del código sin modificar el comportamiento del sistema. Gracias a esto se facilita la
comprensión y el mantenimiento del código.

4) Dentro de un ArrayList: ¿se pueden insertar valores de distinto tipo?

Sí. El ArrayList es una lista dinámica que nos permite agregar datos del mismo tipo o de distintos tipos.
Estos tipos de datos pueden ser string, int, float, bool, etc.