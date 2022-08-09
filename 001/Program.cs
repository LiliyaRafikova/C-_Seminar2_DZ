Console.Write ("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int firstDigit = number /100;
int secondDigit= (number/10)%10;

Console.WriteLine($"Вторая цифра трехзначного числа {number} - это цифра {secondDigit} !");

