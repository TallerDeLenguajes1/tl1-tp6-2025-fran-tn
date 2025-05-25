[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/24pP-Pw_)
# Ejercicio 4

## ¿String es una tipo por valor o un tipo por referencia?

### El String es un tipo por referencia

## ¿Qué secuencias de escape tiene el tipo string?

### \'	Comilla simple:	No es estrictamente necesaria en cadenas, pero útil en char literales.
### \"	Comilla doble:	Inserta una comilla doble dentro de una cadena.
### \\	Barra invertida:	Inserta una barra invertida literal.
### \0	Carácter nulo:	El carácter con valor ASCII 0 (terminador de cadena en algunos contextos).
### \a	Alerta (campana):	Genera un sonido de alerta (raramente usado).
### \b	Retroceso:	Mueve el cursor un carácter hacia atrás.
### \f	Salto de página:	Salto de página (form feed).
### \n	Nueva línea	Salto de línea (line feed): Este es el más común para nuevas líneas.
### \r	Retorno de carro:	Mueve el cursor al principio de la línea actual.
### \t	Tabulación horizontal:	Inserta un tabulador.
### \v	Tabulación vertical:	Inserta un tabulador vertical.
### \u	Unicode (4 dígitos):	Representa un carácter Unicode usando su código hexadecimal de 4 dígitos (p. ej., \u00A9 para ©).
### \x	Unicode (1-4 dígitos):	Representa un carácter Unicode usando su código hexadecimal de 1 a 4 dígitos (similar a \u).

## ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
### El @ le dice al compilador de C# que ignore las secuencias de escape de barra invertida (\)
### El $ antes de una cadena literal la convierte en una cadena interpolada. Esto te permite incrustar expresiones de C# (variables, llamadas a métodos, operaciones matemáticas, etc.) directamente en la cadena, encerrándolas entre llaves {}. El compilador evaluará esas expresiones y convertirá sus resultados a sus representaciones de cadena.