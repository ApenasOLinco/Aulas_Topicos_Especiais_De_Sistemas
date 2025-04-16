/*
    Crie um menu com as opções:
        1 - Celsius para Fahrenheit
        2 - Fahrenheit para Celsius
        3 - Sair
    Use switch e while para manter o menu ativo até o usuário sair
*/

while (true)
{
    float unconverted = 0;

    Console.WriteLine(
    """
    1 - Celsius para Fahrenheit
    2 - Fahrenheit para Celsius
    3 - Sair
    """
    );

    int opcao = int.Parse(Console.ReadLine());

    if(opcao != 3) {
        Console.WriteLine($"Insira o valor a ser convertido: ");
        unconverted = float.Parse(Console.ReadLine());
    }

    float result = 0;
    switch (opcao)
    {
        case 1:
            result = (unconverted * 1.8F) + 32F;
            break;

        case 2:
            result = (unconverted - 32F) / 1.8F;
            break;

        case 3:
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine($"Entrada inválida! Escolha uma das opções disponíveis.");
            continue;
    }

    Console.WriteLine($"{unconverted}°{(opcao == 1 ? "C" : "F")} = {result}°{(opcao == 1 ? "F" : "C")}");
}