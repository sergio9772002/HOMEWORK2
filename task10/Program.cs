/* Напишите программу, которая принимает на вход трехзначное число и на выходе показывает
вторую цифру этого числа.
Например:
4 5 6 - 5
7 8 2 - 8
9 1 8 - 1
*/

int GetRandomNumberInRange(int start, int end)
{
    int result = 0;
    result = new Random().Next(start, end + 1);
    return result;
}
int GetSecondNumber(int number)
{
    int firstDigit = number / 10;
    int secondDigit = firstDigit % 10;
    return secondDigit;
}
int randomNumber = GetRandomNumberInRange(100, 999);
Console.WriteLine(randomNumber);
int newNumber = GetSecondNumber(randomNumber);
Console.WriteLine($" {newNumber} ");