System.Console.Clear();
int SetNumber(string text = "")
{
     Console.Write($"Введите размер массива {text}:");
     int num = Convert.ToInt32(Console.ReadLine());
     return num;
}

void MetodArray(string[] array)
{
    int length = array.Length;
    Random rnd = new Random();
    for(int i=0; i<length; ++i)
    {
       Console.Write($"введите {i} элемент массива: ");
       array[i] = Console.ReadLine();
    }
}
void Print(string[] array)
{
    for(int i=0; i<array.Length; ++i )
    {
        Console.Write($" {array[i]}");
    }
}



int length = SetNumber();
string[] array = new string[length];
MetodArray(array);
Print(array);