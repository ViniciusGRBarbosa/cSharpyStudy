using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;

SByte x = 100; // a mesma coisa que sbyte, porem ele petence ao use system do .Net, já o minusculo já vem com C#
Console.WriteLine(x);

byte n1 = 255;// não aceita número negativo e não pode passar o 255  
Console.WriteLine(n1);

int cont = 255;// 
//Overflow = quando o programa estrapola o valor máximo que a variavel pode receber 
while(cont < 257){
    n1++;
    cont++;
    Console.WriteLine(n1);
}
//O valor da variavel vai para o sentido oposto quando estrapolado

int n2 = 1000; // número inteiro de 4bits
Console.WriteLine(n2);

int n3 = 2147483647; //Valor máximo do int
n3++;
Console.WriteLine(n3);


long n4 = 1000; // número inteiro de 8bits
Console.WriteLine(n4);

long n5 = 9223372036854775807; //Valor máximo do long 
n5++;
Console.WriteLine(n5);

bool completo = false;

System.Console.WriteLine(completo);

char genero = 'F'; //Caracter unicode
char generoUnicode = '\u0041' ;
System.Console.WriteLine( genero);
System.Console.WriteLine( generoUnicode);

float n6 = 4.5f ; //número com ponto flutuante 4 bytes

double n7 = 4.5 ; //número com ponto flutuante 8 bytes

System.Console.WriteLine(n6);
System.Console.WriteLine(n7);

string nome = "maria"; //string é representada com aspas dulpas e quando for char aspas simples
System.Console.WriteLine( nome );

//string não é considerado um tipo básico, é uma cadeia de caracteres unicode, não se pode mudar ela, ou seja é imutavel

 object obj1 = "Alex"; // é um tipo genérico, aceita qualquer entrada 
 object obj2 = 4.5F;

 System.Console.WriteLine( obj2);
 System.Console.WriteLine( obj1);

 int n8 = int.MinValue;//Valor máximo que um inteiro pode ser 
 int n9 = int.MaxValue;//Valor minimo que um inteiro pode ser 

 System.Console.WriteLine(n8);
 System.Console.WriteLine(n9);