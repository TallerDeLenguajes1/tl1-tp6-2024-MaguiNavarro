// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;
 a=10;
 b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b); 


Console.WriteLine("Ingrese un Numero:");
string entrada = Console.ReadLine(); 
bool anda= int.TryParse(entrada, out int num);


if (anda)

{
int invertido= 0;
 while (num > 0)
{
    int dig= num % 10;
    invertido= (invertido * 10) + dig;
    num = num / 10;
}
Console.WriteLine("El numero invertido es:" +invertido);
}


//Calculadora V1
int opcion;
double num1,num2, resultado;

Console.WriteLine("1-Sumar");
Console.WriteLine("2-Restar");
Console.WriteLine("3-Dividir");
Console.WriteLine("4-Multiplicar");

Console.WriteLine("Ingrese una Opcion: ");

int.TryParse(Console.ReadLine(),out opcion);

switch (opcion)
{
      case 1:
    Console.WriteLine("Ingrese los numeros");
    double.TryParse(Console.ReadLine(),out num1);
    double.TryParse(Console.ReadLine(),out num2);
    resultado= num1 + num2;
    Console.WriteLine("El resultado es : " +resultado);
    break;
     case 2:
    Console.WriteLine("Ingrese los numeros");
    double.TryParse(Console.ReadLine(),out num1);
    double.TryParse(Console.ReadLine(),out num2);
    resultado= num1 - num2;
    Console.WriteLine("El resultado es : " +resultado);
    break;
     case 3:
    Console.WriteLine("Ingrese los numeros");
    double.TryParse(Console.ReadLine(),out num1);
    double.TryParse(Console.ReadLine(),out num2);
    resultado= num1 / num2;
    Console.WriteLine("El resultado es : " +resultado);
    break;
     case 4:
    Console.WriteLine("Ingrese los numeros");
    double.TryParse(Console.ReadLine(),out num1);
    double.TryParse(Console.ReadLine(),out num2);
    resultado= num1 * num2;
    Console.WriteLine("El resultado es : " +resultado);
    break;

 }










