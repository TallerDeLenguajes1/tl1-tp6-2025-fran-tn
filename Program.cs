﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
int b;
a= 10;
b =a;
Console.WriteLine("Valor de a: " +a);
Console.WriteLine("Valor de b: " +b);


Console.WriteLine("~~~~~~~~~Ejercicio 1~~~~~~~~~~~~~~~");
Console.WriteLine("Ingresa un numero: "); //Escribe un mensaje
string auxiliar = Console.ReadLine();  //Guarda en la variable lo que ingrese el usuario
int ingresar; //Declaracion de variables
double inverso;
if (int.TryParse(auxiliar, out ingresar))
{
    int.TryParse(auxiliar, out ingresar); //Pasa el texto ingresado por el usuario, si es posible
    Console.WriteLine("El numero ingresado es: " + ingresar);

    if (ingresar != 0)
    {
        inverso = 1.0/ingresar;
        Console.WriteLine("El numero invertido  es : " + inverso);
    }
    else
    {
        Console.WriteLine("No se puede invertir el numero cero");
    }
    
}

Console.WriteLine("~~~~~~~~~Ejercicio 2~~~~~~~~~~~");
int iterar = 1, operacion, num1, num2, resultado;
while (iterar != 0)
{
    Console.WriteLine("Seleccione la operacion que va a realizar:");
    Console.WriteLine("1)SUMA");
    Console.WriteLine("2)RESTA");
    Console.WriteLine("3)PRODUCTO");
    Console.WriteLine("4)DIVISION");
    auxiliar = Console.ReadLine();
    if (int.TryParse(auxiliar, out operacion))
    {
        while (operacion < 1 || operacion > 4)
        {
            Console.WriteLine("Seleccione la operacion que va a realizar:");
            Console.WriteLine("1)SUMA");
            Console.WriteLine("2)RESTA");
            Console.WriteLine("3)PRODUCTO");
            Console.WriteLine("4)DIVISION");
            auxiliar = Console.ReadLine();
            int.TryParse(auxiliar, out operacion);
        }

        Console.WriteLine("Ingrese el numero 1");
        auxiliar = Console.ReadLine();
        int.TryParse(auxiliar, out num1);

        Console.WriteLine("Ingrese el numero 2");
        auxiliar = Console.ReadLine();
        int.TryParse(auxiliar, out num2);

        switch (operacion)
        {
            case 1:
                resultado = num1 + num2;
                Console.WriteLine("El resultado es: " + resultado);
                break;

            case 2:
                resultado = num1 - num2;
                Console.WriteLine("El resultado es: " + resultado);
                break;

            case 3:
                resultado = num1 * num2;
                Console.WriteLine("El resultado es: " + resultado);
                break;

            default:
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                    Console.WriteLine("El resultado es: " + resultado);
                }
                else
                {
                    Console.WriteLine("No se puede dividir por 0");
                }
                break;
        }

    }

    Console.WriteLine("Desea realizar otra operacion?");
    Console.WriteLine("0)NO");
    Console.WriteLine("1)SI");
    auxiliar = Console.ReadLine();
    int.TryParse(auxiliar, out iterar);
    while (iterar != 1 && iterar != 0)
    {
        Console.WriteLine("Desea realizar otra operacion?");
        Console.WriteLine("0)NO");
        Console.WriteLine("1)SI");
        auxiliar = Console.ReadLine();    
        int.TryParse(auxiliar, out iterar);
    }

}

Console.WriteLine("~~~~~~~+Ejercicio 3~~~~~~~+");
Console.WriteLine("Ingrese un numero");
auxiliar = Console.ReadLine();
int comparar1, comparar2;
double num3, resultadoEjercicio3;
if (double.TryParse(auxiliar, out num3))
{
    double.TryParse(auxiliar, out num3);
    Console.WriteLine("Seleccione la operacion:");
    Console.WriteLine("1)Valor absoluto");
    Console.WriteLine("2)Cuadrado de " + num3);
    if (num3 >= 0)
    {
        Console.WriteLine("3)Raiz cuadrada de " + num3);
    }
    Console.WriteLine("4)Seno (radianes) de " + num3);
    Console.WriteLine("5)Coseno (radianes) de " + num3);
    Console.WriteLine("6)Parte entera de " + num3);
    auxiliar = Console.ReadLine();
    int.TryParse(auxiliar, out operacion);

    while (operacion < 1 || operacion > 6)
    {
        Console.WriteLine("Seleccione la operacion:");
        Console.WriteLine("1)Valor absoluto");
        Console.WriteLine("2)Cuadrado de " + num3);
        Console.WriteLine("3)Raiz cuadrada de " + num3);
        Console.WriteLine("4)Seno de " + num3);
        Console.WriteLine("5)Coseno de " + num3);
        Console.WriteLine("6)Parte entera de " + num3);
        auxiliar = Console.ReadLine();
        int.TryParse(auxiliar, out operacion);
    }

    switch (operacion)
    {
        case 1:
            resultadoEjercicio3 = Math.Abs(num3);
            break;
        case 2:
            resultadoEjercicio3 = num3 * num3;
            break;
        case 3:
            resultadoEjercicio3 = Math.Sqrt(num3);
            break;
        case 4:
            resultadoEjercicio3 = Math.Sin(num3);
            break;
        case 5:
            resultadoEjercicio3 = Math.Cos(num3);
            break;
        default:
            resultadoEjercicio3 = Math.Truncate(num3);
            break;
    }

    Console.WriteLine("El resultado es: " + resultadoEjercicio3);
}
else
{
    Console.WriteLine("Entrada incorrecta");
}

Console.WriteLine("Ingrese un numero");
auxiliar = Console.ReadLine();
if (int.TryParse(auxiliar, out comparar1))
{
    int.TryParse(auxiliar, out comparar1);
    Console.WriteLine("Ingrese un segundo numero");
    auxiliar = Console.ReadLine();
    if (int.TryParse(auxiliar, out comparar2))
    {
        int.TryParse(auxiliar, out comparar2);
        if (comparar1 > comparar2)
        {
            Console.WriteLine("Numero Mayor: " + comparar1);
            Console.WriteLine("Numero Menor: " + comparar2);
        }
        else
        {
            if (comparar1 == comparar2)
            {
                Console.WriteLine("Los numeros son iguales");
            }
            else
            {
                Console.WriteLine("Numero Mayor: " + comparar2);
                Console.WriteLine("Numero Menor: " + comparar1);
            }
        }
    }
    else
    {
        Console.WriteLine("Entrada incorrecta");
    }
}
else
{
    Console.WriteLine("Entrada incorrecta");
}