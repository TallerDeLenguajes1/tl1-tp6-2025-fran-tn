// See https://aka.ms/new-console-template for more information
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

Console.WriteLine("~~~~~~~~~~Ejercicio 4~~~~~~~~~~~~");

string cadena = "Texto de ejmeplo ";
int longitud = cadena.Length;
Console.WriteLine("Longitud de la primera cadena: " + longitud);

Console.WriteLine("Ingrese una cadena de caracteres");
string cadena2 = Console.ReadLine();
string concatenacion = $"{cadena}{cadena2}";
Console.WriteLine("Cadena concatenada: " + concatenacion);

if (cadena2.Length > 5)
{
    string extraer = cadena2.Substring(5); //Extraera desde la posicion 5 en adelante 
    Console.WriteLine("Cadena extraida: " + extraer);
}


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
                    Console.WriteLine($"La suma de {num1} y {num2} es: " + resultado.ToString());
                    break;

                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine($"La resta de  {num1} y {num2} es: " + resultado.ToString());
                    break;

                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine($"El producto de {num1} y {num2} es: " + resultado.ToString());
                    break;

                default:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"El cociente entre {num1} y {num2} es: " + resultado.ToString());
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por 0");
                    }
                    break;
            }

    }

int contador = 0;
foreach (char elemento in cadena2)
{
    Console.WriteLine($"Elemento en posicion {contador}: " + elemento);
    contador++;
}



Console.WriteLine("Ingrese la palabra que desea buscar en la cadena que ingreso anteriormente");
string buscar = Console.ReadLine();

if (cadena2.Contains(buscar))
{
    Console.WriteLine("La palabra SI se encuentra en la cadena");
}
else
{
    Console.WriteLine("La palabra NO se encuentra en la cadena");
}

string cadenaTransformada;

cadenaTransformada  = cadena2.ToUpper();
Console.WriteLine("Cadena transformada en mayusculas: " + cadenaTransformada);

cadenaTransformada = cadena2.ToLower();
Console.WriteLine("Cadena transformada en minusculas: " + cadenaTransformada);

string[] palabraSeparada = cadena2.Split(' '); //Separa la cadena2 en subcadenas que terminan en un espacio
contador = 0;
foreach (string mostrar in palabraSeparada) //Recorre cada subcadena
{
    contador++;
    Console.WriteLine($"Subcadena {contador}: " + mostrar);
}

Console.WriteLine("Ingrese una ecuacion");
string ecuacion = Console.ReadLine();               //RECIBO LA CADENA DE CARACTERES
int operar1 = 0, operar2 = 0, signo = 0, aux;       //INICIALIZO CONTADORES
string signoDeOperacion = "x";                      //SE GUARDARA EL SIGNO DE LA OPERACION ARITMETICA
string cadenaAuxiliar;                              //SE UTILIZARA PARA PODER UTILIZAR TryParse
foreach (char digito in ecuacion)                   //RECORRERA CADA CARACTER DE LA CADENA DE CARACTERES, TRABAJARE CON TIPO char
{
    cadenaAuxiliar = digito.ToString();             //PASO EL char A string para poder utilizar TryParse
    
        if (int.TryParse(cadenaAuxiliar, out aux) && signo == 0)  //VEO SI EL DIGITO SE PUEDE PASAR A ENTERO
        {
            int.TryParse(cadenaAuxiliar, out aux);  //PASO EL DIGITO DE string A int
            operar1 = (operar1 * 10) + aux;         //MULTIPLICO POR 10 PARA QUE SE SUME EL NUEVO DIGITO COMO UNIDAD
        }
        else
        {
            if (signo != 1)
            {
                signo = 1;                              //SI NO SE PUEDE PASAR EL DIGITO A ENTERO, INDICO QUE YA SE LEYO EL PRIMER NUMERO DE LA ECUACION
                signoDeOperacion = cadenaAuxiliar;      //GUARDO EL SIGNO QUE INDICA LA OPERACION QUE SE DEBE REALIZAR
            }
                        
        }
    

        if (int.TryParse(cadenaAuxiliar, out aux) && signo == 1) //COMO SE LLEGO AL FINAL DEL PRIMER NUMERO, COMIENZO A AGREGAR EL VALOR DEL SEGUNDO NUMERO
        {
            int.TryParse(cadenaAuxiliar, out aux);
            operar2 = (operar2 * 10) + aux;
        }
}

switch (signoDeOperacion)
{
    case "+":
        Console.WriteLine($"La suma entre {operar1} y {operar2} es: {operar1 + operar2}");
        break;
    case "-":
        Console.WriteLine($"La resta entre {operar1} y {operar2} es: {operar1 - operar2}");
        break;
    case "*":
        Console.WriteLine($"El producto entre {operar1} y {operar2} es: {operar1 * operar2}");
        break;
    case "/":
        if (operar2 != 0)
        {
            Console.WriteLine($"El cociente entre {operar1} y {operar2} es: {operar1 / operar2}");
        }
        else
        {
            Console.WriteLine("No se puede dividir por 0");
        }
        break;
    default:
        Console.WriteLine("No se pudo realizar la operacion");
        break;
}