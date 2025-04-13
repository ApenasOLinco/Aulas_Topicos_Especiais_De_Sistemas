/*
Peça ao usuário um número inteiro positivo e calcule o fatorial desse número usando
while.
*/

Console.WriteLine("Insira um número inteiro e positivo:");
int num = int.Parse(Console.ReadLine());
int res = 1;

Console.Write($"{num}! = ");

while (num > 0) {
    res *= num;
    num--;
}

Console.WriteLine($"{res}");

