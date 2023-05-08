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

void RemoveIndex(ref string[] array, int index)
{
string[]newArray = new string[array.Length - 1];
for (int i=0; i< index; i++) 
newArray[i]= array[i];

for (int i=index+1; i<array.Length; i++)
newArray [i-1]=array[i];

array=newArray;
}


int length = SetNumber();
string[] array = new string[length];
MetodArray(array);
Print(array);
for(int i=0; i<array.Length; i++)
{
if (array[i].Length > 3) 
      RemoveIndex(ref array, i);


}
System.Console.WriteLine();





Print(array);