/*
Solicite ao usuário um número e imprima a tabuada completa dele (de 1 a 10),
utilizando um for.
*/

Console.WriteLine("Insira um número:");
int num = int.Parse(Console.ReadLine());

for(int i = 1; i <= 10; i++) {
    Console.WriteLine($"{num} x {i} = {num * i}");   
}
