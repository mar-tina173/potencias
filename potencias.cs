// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int MultPorSumas(int num1, int num2)
{
    int resultado = 0;
    for (int i = 0; i < num2; i++)
    {
        resultado = resultado + num1;
    }
    return resultado;
}

void multi()
{
    Console.WriteLine("Ingrese el primer número:");
    int n1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese el segundo número:");
    int n2 = Convert.ToInt32(Console.ReadLine());

    int resultado = MultPorSumas(n1, n2);
    Console.WriteLine("El resultado de la multiplicación es: " + resultado);
}

void potencia()
{
    Console.WriteLine("ingrese la base:");
    int n1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("ingrese el exponente:");
    int n2 = Convert.ToInt32(Console.ReadLine());
    int resultado = 1;

    for (int i = 0; i < n2; i++)
    {
        resultado = MultPorSumas(resultado, n1);
    }
    Console.WriteLine($"El resultado de {n1}^{n2} es: {resultado}");
}
potencia();

