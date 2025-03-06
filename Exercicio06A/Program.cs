/*
Desenvolver um algoritmo para receber 1000 valores automaticamente dentro de um vetor e ordenar do menor para o maior.

1. Desenvolver o algoritmo de ordenação (Bubble Sort);
*/

const int MAX_VAL = 10;
int[] array = new int[5];

PreencherArray(array);
BubbleSort(array);


static void PreencherArray(int[] array)
{
    Random random = new();

    Console.WriteLine("UNSORTED:");
    Console.Write("{");
    for (int i = 0; i < array.Length; i++)
    {
        int r = random.Next(MAX_VAL);
        array[i] = r;
        Console.Write(array[i] + (i < array.Length - 1 ? "," : ""));
    }
    Console.WriteLine("}");
}


static void BubbleSort(int[] array)
{
    int length = array.Length;

    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < length - 1 - i; j++)
        {
            int currentElement = array[j];
            int nextElement = array[j + 1];

            if (currentElement > nextElement)
            {
                array[j] = nextElement;
                array[j + 1] = currentElement;
            }
        }
    }

    Console.WriteLine("SORTED:");
    Console.Write("{");
    
    for(int i = 0; i < array.Length; i++) {
        Console.Write(array[i] + (i < array.Length - 1 ? "," : ""));
    }
    
    Console.WriteLine("}");
}