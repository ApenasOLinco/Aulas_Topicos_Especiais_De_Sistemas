/*
Peça ao usuário para digitar uma palavra ou frase e verifique se ela é um palíndromo
(lê-se igual de frente para trás e de trás para frente, desconsiderando espaços e acentos)
*/

using System.Globalization;
using System.Text;

string? expressao, reversa;

Console.WriteLine("Insira uma palavra ou frase: ");
expressao = Console.ReadLine() ?? "";

expressao = RemoverAcentos(expressao)
    .ToLower()
    .Replace(" ", "");


reversa = new([..
    expressao
        .Normalize()
        .Reverse()
]);


if (reversa.Equals(expressao))
{
    Console.WriteLine("É palíndromo!");
}
else
{
    Console.WriteLine("Não é palíndromo.");
}


static string? RemoverAcentos(string? expressao)
{
    if (string.IsNullOrWhiteSpace(expressao)) throw new Exception("A expressão digitada é vazia!");

    expressao = expressao.Normalize(NormalizationForm.FormD);
    StringBuilder resultado = new();

    foreach (char c in expressao)
    {
        var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);

        if (unicodeCategory != UnicodeCategory.NonSpacingMark)
            resultado.Append(c);
    }

    return resultado.ToString();
}