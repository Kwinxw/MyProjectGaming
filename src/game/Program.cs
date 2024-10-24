using System;

class GamePro228
{
    static void Main()
    {
        string Name;
        bool key = false;
        bool escape = false;
        bool foundArt1 = false;
        bool foundArt2 = false;
        bool foundArt3 = false;
     
        Console.WriteLine("Введите ваше имя:");
        Name = Console.ReadLine();

        while (true)
        {
            Console.WriteLine($"{Name}, вы находитесь в комнате. Что вы хотите сделать?");
            Console.WriteLine("a. Открыть дверь");
            Console.WriteLine("b. Заглянуть под кровать");
            Console.WriteLine("c. Открыть ящик в углу комнаты");
            Console.WriteLine("d. Открыть вентиляцию");
            Console.WriteLine("e. Взглянуть на тумбочку");
            Console.WriteLine("f. Взглянуть на статую рядом с дверью");
            Console.WriteLine("g. Спать дальше)))");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "a":
                    if (escape)
                    {
                        Console.WriteLine($"{Name}, вы успешно сбежали!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"{Name}, Нужна отмычка чтобы открыть дверь.");
                    }
                    break;

                case "b":
                    if (!foundArt1)
                    {
                        foundArt1 = true;
                        Console.WriteLine($"{Name}, вы нашли первый артефакт под кроватью!");
                    }
                    else
                    {
                        Console.WriteLine($"{Name}, под кроватью больше ничего нет.");
                    }
                    break;

                case "c":
                    if (key)
                    {
                        escape = true;
                        Console.WriteLine($"{Name}, вы нашли отмычку в ящике!");
                    }
                    else
                    {
                        Console.WriteLine($"{Name}, ящик заперт. Вам нужен ключ.");
                    }
                    break;

                case "d":
                    if (!foundArt2)
                    {
                        Console.WriteLine($"{Name}, вы пытаетесь открыть вентиляцию...");
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine("Иии " + (i + 1));
                        }
                        foundArt2 = true;
                        Console.WriteLine($"{Name}, вы нашли второй артефакт в вентиляции!");
                    }
                    else
                    {
                        Console.WriteLine($"{Name}, в вентиляции бегают крысы...");
                    }
                    break;

                case "e":
                    if (!foundArt3)
                    {
                        foundArt3 = true;
                        Console.WriteLine($"{Name}, вы нашли третий артефакт на тумбочке!");
                    }
                    else
                    {
                        Console.WriteLine($"{Name}, на тумбочке виднеется пыль...");
                    }
                    break;

                case "f":
                    if (foundArt1 && foundArt2 && foundArt3)
                    {
                        key = true;
                        Console.WriteLine($"{Name}, статуя активирована! Вы получили ключ от ящика.");
                    }
                    else
                    {
                        Console.WriteLine($"{Name}, вам нужно найти все артефакты для активации статуи.");
                    }
                    break;

                case "g":
                    return;

                default:
                    Console.WriteLine("Неверный выбор!");
                    break;
            }           
        }
    }
}
