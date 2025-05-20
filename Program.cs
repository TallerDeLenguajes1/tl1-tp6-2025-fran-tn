// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
int b;
a= 10;
b =a;
Console.WriteLine("Valor de a: " +a);
Console.WriteLine("Valor de b: " +b);

Console.WriteLine("Ingresa un numero: "); //Escsuario a uribe un mensaje
string auxliar = Console.ReadLine();  //Guarda en la variable lo que ingrese el usuario
int ingresar; //Declaracion de variables
double inverso;
int.TryParse(auxliar, out ingresar); //Pasa el texto ingresado por el usuario, si es posible
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
