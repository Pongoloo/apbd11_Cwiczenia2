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

int[] arr = { 1, 2, 3, 4, 5 };
float averaged = average(arr);

Console.WriteLine(averaged + " heheHHAHAHHIHIHHOHOHHOHOHEHEHHE");


static void gamer(String smieszki)
{
    Console.WriteLine(smieszki.ToUpper());
}