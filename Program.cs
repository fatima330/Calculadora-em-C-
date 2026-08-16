
Console.WriteLine("********** Bem vindo á Calculadora em C# **********\n");

string resposta = "s";
do
{
    Console.Write("Digite o primeiro número: ");
    double num1 = double.TryParse(Console.ReadLine(), out double result1) ? result1 : 0;
    Console.WriteLine();

    Console.WriteLine("Escolha uma operação:");
    Console.WriteLine("1 - Adição +");
    Console.WriteLine("2 - Subtração -");
    Console.WriteLine("3 - Multiplicação *");
    Console.WriteLine("4 - Divisão /");
    Console.WriteLine();

    int operacao = int.TryParse(Console.ReadLine(), out int result) ? result : 0;

    Console.WriteLine();

    Console.Write("Digite o segundo número: ");
    double num2 = double.TryParse(Console.ReadLine(), out double result2) ? result2 : 0;
    Console.WriteLine();

    switch (operacao)
    {
        case 1:
            Console.WriteLine("1 - Adição + \n");
            var resultado = num1 + num2;
            Console.WriteLine($"Resultado: {num1} + {num2} = {resultado}");
            break;
        case 2:
            Console.WriteLine("2 - Subtração - \n");
            resultado = num1 - num2;
            Console.WriteLine($"Resultado: {num1} - {num2} = {resultado}");
            break;
        case 3:
            Console.WriteLine("3 - Multiplicação * \n");
            resultado = num1 * num2;
            Console.WriteLine($"Resultado: {num1} × {num2} = {resultado}");
            break;
        case 4:
            Console.WriteLine("4 - Divisão / \n");
            resultado = num1 / num2;
            Console.WriteLine($"Resultado: {num1} ÷ {num2} = {resultado}");
            break;
    }

    Console.Write("\nDeseja fazer outra operação? (s/n): ");
    resposta = Console.ReadLine();
   
}
while (resposta == "s ");
Console.WriteLine("\n ********** Ate Logo !! **********");