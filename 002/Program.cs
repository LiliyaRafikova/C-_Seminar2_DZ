Console.Write("Введите день недели от 1 до 7: ");
int dayWeeK = Convert.ToInt32(Console.ReadLine());
if (dayWeeK<1 || dayWeeK>7) 
{
    Console.WriteLine("Введенные данные некорректны, попробуйте ещё раз.");
}
else 
if (dayWeeK ==6 || dayWeeK==7) 
    {
        Console.WriteLine("Является ли этот день выходным днем? Ответ: ДА!");
    }
    else 
    {
        Console.WriteLine("Является ли этот день выходным днем? Ответ: НЕТ!");
    }
