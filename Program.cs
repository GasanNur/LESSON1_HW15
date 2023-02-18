// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

string[]week = new string [7] {"Понедельник", "Вторник", "Стреда", "Четверг", "Пятница", "Суббота", "Всокресенье" };
while (true)
{
  Console.WriteLine("Введите число от 1 до 7");
  int userNumber = Convert.ToInt32(Console.ReadLine());
  if (userNumber < 7 || userNumber > 7 )
  {
    Console.WriteLine("этот день не выходной");
    userNumber = Convert.ToInt32(Console.ReadLine ());
  }  
else
{
    int weekIndex = userNumber -1;
    Console.WriteLine($"Этот день {userNumber} выходной");
    break;
}

}