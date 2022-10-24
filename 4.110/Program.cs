 Console.WriteLine("Введите номер масти карты (1-Пики, 2-Крести, 3-Бубни, 4-Черви) ");
int cardNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Укажите карту");
int cardDignity = Convert.ToInt32(Console.ReadLine());

switch (cardDignity)
{
    case 6:
        Console.Write("Шестерка");
        break;
    case 7:
        Console.Write("Семерка");
        break;
    case 8:
        Console.Write("Восьмерка");
        break;
    case 9:
        Console.Write("Девятка");
        break;
    case 10:
        Console.Write("Десятка");
        break;
    case 11:
        Console.Write("Валет");
        break;
    case 12:
        Console.Write("Дама");
        break;
    case 13:
        Console.Write("Король");
        break;
    case 14:
        Console.Write("Туз");
        break;
}
switch (cardNumber)
{
    case 1:
        Console.Write("\n Пики");
        break;
    case 2:
        Console.Write("\n Крести");
        break;
    case 3:
        Console.Write("\n Бубни");
        break;
    case 4:
        Console.Write("\n Черви");
        break;
}
