/* Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.
*/
int holiday = new int ();
Console.WriteLine("Введите число от 1 до 7 - обозначающие дни недели");
holiday = Convert.ToInt32(Console.ReadLine());
if (holiday < 8)  
{
    if (holiday ==7) Console.WriteLine("да");
    if (holiday ==6) Console.WriteLine("да");
    if (holiday < 0) Console.WriteLine("такого дня недели нет"); 
    if (holiday < 6) Console.WriteLine("нет");
}
else
{
   Console.WriteLine("такого дня недели нет"); 
}