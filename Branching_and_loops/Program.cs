// Вывод меню и выбор задачи

byte exit = 0;
while (exit != 1)
{
    Console.WriteLine($"{"\tМЕНЮ:  \n1 - Определение чётного или нечётного числа \n2 - Подсчёт суммы карт в игре «21» \n3 - Проверка простого числа \n0 - Выход \n\n=="}");
    string input_num = Console.ReadLine();
    byte num = byte.Parse(input_num);

    if (num >= 0 && num <= 3) ;
    {
        switch (num)
        {
            case 0:     // Выход из программы
                
                exit = 1;  
                break;

            case 1:    // Определение чётного или нечётного числа

                Console.Clear();
                Console.WriteLine($"{"\t<<ОПРЕДЕЛЕНИЕ ЧЁТНОГО ИЛИ НЕЧЁТНОГО ЧИСЛА>> \n\n\tВведите число:"}");
                int digit = int.Parse(Console.ReadLine());
                if (digit % 2 == 0)
                {
                    Console.WriteLine("Вы ввели ЧЁТНОЕ число");
                }
                else
                {
                    Console.WriteLine("Вы ввели НЕЧЁТНОЕ число");
                }

                Console.ReadKey();
                break;

            case 2:     // Подсчёт суммы карт в игре «21»

                Console.Clear();
                Console.WriteLine($"{"\t<< ПОДСЧЕТ СУММЫ КАРТ В ИГРЕ «21» >> \n\n\tСколько карт у Вас на руках?:"}");
                int quantity = int.Parse(Console.ReadLine());
                byte nominal = 0;
                Console.WriteLine($"{"Для ввода номинала карт используйте цифры от 6 до 10 для карт с числовым номиналом и \nбуквы для «картинок» (Валет - J ; Дама - Q ; Король - K ; Туз - T): "}");
                for (int i = 1; i <= quantity; i++)
                {
                    Console.WriteLine($"{"\nВведите номинал карты "} {i} {" :"}");
                    string input_nominal = Console.ReadLine();

                    if (input_nominal == "6" || input_nominal == "7" || input_nominal == "8" || input_nominal == "9" || input_nominal == "10" || input_nominal == "J" || input_nominal == "Q" || input_nominal == "K" || input_nominal == "T")
                    {
                        switch (input_nominal)
                        {
                            case "6": nominal += byte.Parse(input_nominal); break;
                            case "7": nominal += byte.Parse(input_nominal); break;
                            case "8": nominal += byte.Parse(input_nominal); break;
                            case "9": nominal += byte.Parse(input_nominal); break;
                            case "10": nominal += byte.Parse(input_nominal); break;
                            case "J": nominal += 2; break;
                            case "Q": nominal += 3; break;
                            case "K": nominal += 4; break;
                            case "T": nominal += 11; break;

                        }
                    }
                    else
                    {
                        Console.WriteLine("Вы ошиблись при вводе номинала, будьте внимательны ))");
                        i--;
                    }

                                     
                }
                if (nominal > 21)
                {
                    Console.WriteLine($"{"Сумма карт: "} {nominal} {" - перебор ))"}");
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine($"{"Сумма карт: "} {nominal}");
                    Console.ReadKey();
                }
                break;

            case 3:     // Проверка простого числа

                Console.Clear();
                Console.WriteLine($"{"\t<< ПРОВЕРКА ПРОСТОГО ЧИСЛА >> \n\n\tВведите целое число:"}");
                int n = int.Parse(Console.ReadLine());
                bool prime = false;
                int remains = 0;
                int j = 2;
                
                while (j < n-1)
                {
                    remains = n % j;
                    
                    if (remains == 0)
                    {
                        prime = true;
                        break;
                    }
                    else
                    {
                        j++;
                    }
                }
                if (prime)
                {
                    Console.WriteLine("Введенное число не может быть простым");
                }
                else
                {
                    Console.WriteLine("Введенное число ПРОСТОЕ");
                }
                Console.ReadKey();
                break;
        }

    }
    Console.Clear();
}