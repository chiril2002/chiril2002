string[] array1 = new string[4] {"hello", "2", "world", ":-)", }; 
string[] array2 = new string[array1.Length] ;
void SecondArreyWithIF(string[] array1, string[]arrey2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            arrey2[count] = array1[i];
            count++;
        }
    }
}

void PrintArrey(string[]array)
{
    for (int i = 0;i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}






SecondArreyWithIF(array1,array2);
PrintArrey(array2);
