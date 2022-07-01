// выводит третью цифру заданного числа
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

string ShowSecondCount(int num1)
{

string mass = num1.ToString();
int [] array = new int [mass.Length];
if (num1 < 99) 
{
    return "У вашего числа нет третьей цифры";
}
else

for ( int i=0; i < mass.Length; i++)
{
    array [i] = int.Parse(mass[i].ToString());
}
return $"Третья цифра в числе {array[2]}";

}
Console.WriteLine(ShowSecondCount(num));