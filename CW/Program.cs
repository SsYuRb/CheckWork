
string [] arrayCharsAndDigits = new string [new Random().Next(2,7)]; 

string [] FillArray (string [] array) 
{
    for (int i = 0; i < array.Length; i ++)
    {
        char [] CharsArray = new char [new Random().Next(1,5)];
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