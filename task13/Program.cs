/* Напишите программу, которая выводит третью цифру заданного числа или сообщает,
что третьей цифры нет.
Например:
6 4 5 -5
7 8 - третьей цифры нет
3 2 6 7 9 - 6
*/
int GetRandomNumberInRange(int start, int end)
{
    int result = 0;
    result = new Random().Next(start, end + 1);
    return result;
}

 

int randomNumber = GetRandomNumberInRange(1, 100000);
Console.WriteLine(randomNumber);
int threetDigit = randomNumber; 
if (randomNumber > 100)
{
    while (threetDigit > 1000)
    {
        threetDigit = threetDigit / 10;
    }
int numberthree = threetDigit % 10;
Console.WriteLine($" {numberthree} ");
}
else
{
    Console.WriteLine($"Третьей цифры нет");
}
