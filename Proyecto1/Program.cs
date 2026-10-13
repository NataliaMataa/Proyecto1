using System.Numerics;

float num1, num2, op, resultado;
char operador = ' ';
int contador = 3;
int contnivel = 0;

num1 = 0;
num2 = 0;
op = 0;
resultado = 0;
int N = 10;



do
{
    if (contnivel >= 3 && contnivel < 6)
    {
        Console.WriteLine("Has subido de nivel");
        N = 101;
    } else if (contnivel >= 6)
    {
        Console.WriteLine("Has subido de nivel");
        N = 1001;
    }
    

    num1 = Random.Shared.Next(1, N); // Generates a random number between 1 and N (inclusive)
    num2 = Random.Shared.Next(1, N);

op = Random.Shared.Next(1, 5); // Generates a random number between 1 and 4 (inclusive) to represent the 

switch (op)
{
        case 1:
            resultado = num1 + num2;
            operador = '+';
            break;
        case 2:
            resultado = num1 - num2;
            operador = '-';
            break;
        case 3:
            resultado = num1 * num2;
            operador = '*';
            break;
        case 4:
            resultado = num1 / num2;
            operador = '/';
            break;
}

    Console.WriteLine($"{num1} {operador} {num2} = ?");
    Console.WriteLine($"Digite el resultado");
    float.TryParse(Console.ReadLine(), out float usuariorespuesta);


    if (usuariorespuesta == resultado)
    {
        Console.WriteLine("¡Correcto!");

    }
    else
    {
        Console.WriteLine("Incorrecto. La respuesta correcta es: " + resultado);
        contador++;
    }
} while (contador < 3);

Console.WriteLine("Juego terminado.");