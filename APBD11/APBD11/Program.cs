// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");// See https://aka.ms/new-console-template for more information

static float average(int[] tab)
{
    float result = 0;
    for (int i = 0; i < tab.Length; i++)
    {
        result += tab[i];
    }

    result /= tab.Length;
    return result;
}