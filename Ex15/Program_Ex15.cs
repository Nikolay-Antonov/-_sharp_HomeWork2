// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
int dayNumber = 2;

if (dayNumber == 6 | dayNumber == 7)
{
    Console.WriteLine("это выходной день");
}
else if (dayNumber < 1 || dayNumber > 7)
{
    Console.WriteLine("это не день недели");
}
else Console.WriteLine("это рабочий день");

