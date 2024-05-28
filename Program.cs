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


//Calculadora V2
// int opcion;
// double num1,num2, resultado;

// Console.WriteLine("1-Sumar");
// Console.WriteLine("2-Restar");
// Console.WriteLine("3-Dividir");
// Console.WriteLine("4-Multiplicar");
// Console.WriteLine("5-Valor Absoluto");
// Console.WriteLine("6-cuadrado");
// Console.WriteLine("7-raiz cuadrada");
// Console.WriteLine("8-Seno");
// Console.WriteLine("9-Coseno");
// Console.WriteLine("10-Parte entera");
// Console.WriteLine("Ingrese una Opcion: ");

// int.TryParse(Console.ReadLine(),out opcion);

// switch (opcion)
// {
//       case 1:
//     Console.WriteLine("Ingrese los numeros");
//     double.TryParse(Console.ReadLine(),out num1);
//     double.TryParse(Console.ReadLine(),out num2);
//     resultado= num1 + num2;
//     Console.WriteLine("El resultado es : " +resultado);
//     break; 
//      case 2:
//     Console.WriteLine("Ingrese los numeros");
//     double.TryParse(Console.ReadLine(),out num1);
//     double.TryParse(Console.ReadLine(),out num2);
//     resultado= num1 - num2;
//     Console.WriteLine("El resultado es : " +resultado);
//     break;
//      case 3:
//     Console.WriteLine("Ingrese los numeros");
//     double.TryParse(Console.ReadLine(),out num1);
//     double.TryParse(Console.ReadLine(),out num2);
//     resultado= num1 / num2;
//     Console.WriteLine("El resultado es : " +resultado);
//     break;
//      case 4:
//     Console.WriteLine("Ingrese los numeros");
//     double.TryParse(Console.ReadLine(),out num1);
//     double.TryParse(Console.ReadLine(),out num2);
//     resultado= num1 * num2;
//     Console.WriteLine("El resultado es : " +resultado);
//     break;

//       case 5:
//     Console.WriteLine("Ingrese el numero 1");
//     double.TryParse(Console.ReadLine(),out num1);
//     resultado= Math.Abs(num1);
//     Console.WriteLine("El resultado es : " +resultado);
//     break;
//       case 6:
//     Console.WriteLine("Ingrese el numero 1");
//     double.TryParse(Console.ReadLine(),out num1);
//     resultado= Math.Pow(num1,2);
//     Console.WriteLine("El resultado es : " +resultado);
//     break;
//       case 7:
//     Console.WriteLine("Ingrese el numero 1");
//     double.TryParse(Console.ReadLine(),out num1);
//     resultado= Math.Sqrt(num1);
//     Console.WriteLine("El resultado es : " +resultado);
//     break;
//       case 8:
//     Console.WriteLine("Ingrese el numero 1");
//     double.TryParse(Console.ReadLine(),out num1);
//     resultado= Math.Sin(num1);
//     Console.WriteLine("El resultado es : " +resultado);
//     break;
//        case 9:
//     Console.WriteLine("Ingrese el numero 1");
//     double.TryParse(Console.ReadLine(),out num1);
//     resultado= Math.Cos(num1);
//     Console.WriteLine("El resultado es : " +resultado);
//     break;
//       case 10:
//     Console.WriteLine("Ingrese el numero 1");
//     double.TryParse(Console.ReadLine(),out num1);
//     resultado= Math.Floor(num1);
//     Console.WriteLine("La parte entera del numero es : " +resultado);
//     break;
// }


//String
Console.WriteLine("Ingrese una frase para saber su longitud");
string texto= Console.ReadLine();

int longitud= texto.Length;
Console.WriteLine($"La longitud es: {longitud}");

Console.WriteLine("Ingrese otra frase para concatenar con la anterior");
string texto2= Console.ReadLine();
string concatenada= texto + texto2;

Console.WriteLine($"La Concatenacion es {concatenada}");

//extraer una subcadena
string subcadena= texto2.Substring(1,3);
Console.WriteLine("La subcadena es desde 1 hasta 3 letra de la frase: "+subcadena);

//Recorrer la cadena de texto con un ciclo Foreach
foreach (char caracter in texto)
{
    Console.WriteLine(caracter);
}
Console.WriteLine("Ingrese la palabra a buscar");
string buscar= Console.ReadLine();
 int posicion= texto.IndexOf(buscar,StringComparison.OrdinalIgnoreCase );

 if (posicion!= -1)
 {
    Console.WriteLine($"La palabra '{buscar}' se encontró en la posición {posicion}.");
        }
        else
        {
            Console.WriteLine($"La palabra '{buscar}' no se encontró en el texto.");
        }
 
 // Ingrese una cadena separada por caracteres que usted determine y muestre por
//pantalla los resultados
char separador= ' ';
string [] frase= concatenada.Split(separador);
foreach (string parte in frase)
{
  Console.WriteLine(parte);
}




