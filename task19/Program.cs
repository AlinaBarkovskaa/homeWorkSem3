Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
string n = Convert.ToString(Console.ReadLine());
if(n.Length == 5)
{
   if(n[0] == n[4] && n[1] == n[3])
   {
       Console.WriteLine($"Число: {n} - палиндром.");
   }else
   {
      Console.WriteLine($"Число: {n} - не палиндром.");
   }
}else
{
   Console.WriteLine("Введите пятизначное число");
}
