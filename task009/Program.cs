// Показать последнюю цифру трёхзначного числа
Console.WriteLine("Ведите трехзначное число ");
int number;
number= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Последняя цифра");
Console.WriteLine(number%10);
