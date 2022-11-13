
string [] arrayCharsAndDigits = new string [new Random().Next(2,7)]; 

string [] FillArray (string [] array) 
{
    for (int i = 0; i < array.Length; i ++)
    {
        char [] CharsArray = new char [new Random().Next(1,9)];
        for (int k = 0; k < CharsArray.Length; k++)
        {
            CharsArray[k] = Convert.ToChar(new Random().Next(33, 123));
        }
        string someString = new string (CharsArray);
        array[i] = someString;
    }
    return array;
}
FillArray(arrayCharsAndDigits);

Console.WriteLine("Изначльный массив:");
void PrintArray(string[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}
PrintArray(arrayCharsAndDigits);

Console.WriteLine("Измененный массив:");
void PrintOnly3Str(string[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) {Console.WriteLine(array[i]);}
    }
}
PrintOnly3Str(arrayCharsAndDigits);