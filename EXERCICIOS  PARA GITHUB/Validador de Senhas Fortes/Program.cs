/*
    Peça ao usuário que digite uma senha e verifique se ela atende aos seguintes critérios:
        • Mínimo de 8 caracteres
        • Pelo menos uma letra maiúscula
        • Pelo menos um número
        • Pelo menos um caractere especial (ex: !, @, #)
*/

while (true)
{
    Console.WriteLine("Digite uma senha: ");
    string senha = Console.ReadLine();

    // Senha deve existir
    if (senha is null)
    {
        Console.WriteLine("Insira a senha para continuar!");
        continue;
    }

    // Mínimo de 8 caracteres
    if (senha.Length <= 8)
    {
        Console.WriteLine("Senha muito curta!");
        continue;
    }

    // Pelo menos uma letra maiúscula
    if (!senha.Any(char.IsUpper))
    {
        Console.WriteLine("É necessária pelo menos uma letra maiúscula em sua senha!");
        continue;
    }

    // Pelo menos um número
    if (!senha.Any(char.IsDigit))
    {
        Console.WriteLine("É necessário pelo menos um número!");
        continue;
    }

    // Pelo menos um caractere especial (ex: !, @, #)
    if (!senha.Any(character => !char.IsLetterOrDigit(character) && !char.IsControl(character)))
    {
        Console.WriteLine("É necessário pelo menos um caractere especial! (ex: !, @, #)");
        continue;
    }

    Console.WriteLine("Boa senha. Parabéns!");
    break;
}