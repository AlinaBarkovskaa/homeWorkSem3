Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

void cubeTable(int[] n)
{
  for(int i = 1; i < n.Length; i ++)
  {
    n[i] = Convert.ToInt32(Math.Pow(i, 3));
     Console.Write(n[i]+ " ");
  }
}
int[] array = new int[n+1];
cubeTable(array);



