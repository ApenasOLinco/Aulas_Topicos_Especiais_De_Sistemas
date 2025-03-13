const int MAX_VAL = 10;
int[] array = new int[10];

PreencherArray(array);
Console.WriteLine("UNSORTED:");
PrintarArray(array);

Array.Sort(array);
Console.WriteLine("SORTED:");
PrintarArray(array);

static void PreencherArray(int[] array)
{
    Random random = new();

    for (int i = 0; i < array.Length; i++)
    {
        int r = random.Next(MAX_VAL);
        array[i] = r;
    }
}

static void PrintarArray(int[] array) {
    Console.Write("{");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + (i < array.Length - 1 ? ", " : ""));
    }

    Console.WriteLine("}");
}