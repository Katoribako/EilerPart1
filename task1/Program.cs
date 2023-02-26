//Если выписать все натуральные числа меньше 10, кратные 3 или 5,
// то получим 3, 5, 6 и 9. Сумма этих чисел равна 23.
//Найдите сумму всех чисел меньше 1000, кратных 3 или 5.

Console.WriteLine("Please input your range ");
int range = Convert.ToInt32(Console.ReadLine());
if(range != 0 && range > 0)
{
    Console.WriteLine("Please input your number ");
    int number = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    if (number != 0)
    {
        for(int i = 0; i < number; i++)
        {
            if(i % 3 == 0 || i % 5 == 0)
            {
                sum = sum + i;
            }
        }
    }
    else{Console.WriteLine("Please input not null number");}
    Console.WriteLine($"sum of number is {sum} ");
}
else{Console.WriteLine("Please input a correct range");}