# Trabajo practico TL1, TP6
oal profe todo goti?

## Ejercicio 4
¿String es una tipo por valor o un tipo por referencia?: Es un tipo de referencia

¿Qué secuencias de escape tiene el tipo string?:
- `\'` Comilla simple
- `\"` Comilla doble
- `\\` Barra invertida
- `\0` Nulo
- `\a` Alerta
- `\b` Retroceso
- `\e` Escapar
- `\f` Avance de página
- `\n` Nueva línea
- `\r` Retorno de carro
- `\t` Tabulación horizontal
- `\v` Tabulación vertical
- `\u` Secuencia de escape Unicode (UTF-16)
- `\U` Secuencia de escape Unicode (UTF-32)
- `\x` Secuencia de escape Unicode similar a "\u" excepto con longitud variable

¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
- Con `@` hace que no se interprete los `\` y permite escribir mas lineas
```c#
string Path = @"c:\Program Files\Microsoft Visual Studio 9.0";
string Desc = @"Mi nombre es Javier
    un gusto conocerte
    saludos";
```
- Con `$` sirve para concatenar con `{}` de forma mas legible
```c#
string Nombre = "Javier"
int Edad = 20
string Message = $"Mi nombre es {Nombre} y tengo {Edad} años"
Console.WriteLine(Message)
```