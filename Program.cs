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









