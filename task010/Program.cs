// Показать вторую цифру трёхзначного числа
Console.WriteLine("Ведите трехзначное число ");
int number;
number= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вторая цифра");
Console.WriteLine(number%100/10);
