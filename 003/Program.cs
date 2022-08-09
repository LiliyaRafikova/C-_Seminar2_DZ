Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); // int до 2147483647 (десятизначное число)
if (number<0) number=(number)*(-1); // если пользователь введёт отрицательное число
int result = 0; //третья цифра в числе
if (number/100 ==0)//число двухзначное
{
    Console.WriteLine("Третьей цифры нет");
}
else {
   if  (number/1000 ==0)//число трехзначное
    {
      result = number%10;
    }
    else
    {
        if (number/10000==0)//число четырехзначное
        {
            result = (number/10)%10;
        }
       else 
       {
         if (number/100000==0)//число пятизначное
         {
             result = (number/100)%10;
         }
         else 
         {
            if (number/1000000==0)//число шестизначное
            {
            result = (number/1000)%10;
            }
            else 
            {
                if (number/10000000==0)//число семизначное
                {
                    result = (number/10000)%10;
                }
                else 
                {
                   if  (number/100000000==0)//число восьмизначное
                   {
                    result = (number/100000)%10;
                   }
                   else 
                   {
                    if  (number/1000000000==0)//число девятизначное
                    {
                        result = (number/1000000)%10;
                    }
                    else 
                    {
                        if (number/10000000000==0)//число десятизначное
                        {
                            result = (number/10000000)%10;
                        }
                    }
                   }
                }
                
            }
            
         }
       }

    }

}

Console.WriteLine(result);