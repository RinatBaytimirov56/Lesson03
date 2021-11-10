// 27. Определить кол-во цифр в числе
//4567 - 4

int CountDigit(int n)
{
    int k=0;
    while(n!=0)
    {
        k++;
        n=n/10;
    }
    return k;
}

Console.WriteLine(CountDigit(1234969));