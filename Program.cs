using System;
using System.Reflection.Metadata.Ecma335;

class MainClass
{
    public static void Main(string[] args)
    {
        var anketa = AddUser();
        ShowAnketa(anketa);
        
    }


    static (string name, string lastName, int Age, string petOwner, int petSum, string[] NicknamesPet, int colorSum, string[] favorColor) AddUser()
    {
        (string name, string lastName, int Age, string petOwner, int petSum, string[] NicknamesPet, int colorSum, string[] favorColor) anketa = new();
        Console.WriteLine("Ответьте на вопросы ниже, для заполнения анкеты:");
        do
        {
            Console.WriteLine("Введите Ваше имя: ");
            anketa.name = Console.ReadLine();
        } while (CheckStr(anketa.name, out int corrstr));

        do
        {
            Console.WriteLine("Введите Вашу фамилию: ");
            anketa.lastName = Console.ReadLine();
        } while (CheckStr(anketa.lastName, out int corrstr));

        string age;
        int intage;

            bool validInput3 = false;

            while (!validInput3)
            {
                Console.WriteLine("Введите Ваш возраст ");
                string? input = Console.ReadLine();

                if (int.TryParse(input, out var number))
                {
                    anketa.Age = number;
                    validInput3 = true; // Выход из цикла, если ввод корректен
                }
                else
                {
                    Console.WriteLine("Ошибка. Введите корректное число.");
                }
            }
            

        do
        {
            Console.WriteLine("Есть ли у Вас питомец? да/нет");
            anketa.petOwner = Console.ReadLine();
        } while (CheckStr(anketa.petOwner, out int corrstr));
       
        if (anketa.petOwner == "да")
        {
                bool validInput = false;

                while (!validInput)
                {
                    Console.WriteLine("Сколько у Вас питомцев?");
                    string? input = Console.ReadLine();

                    if (int.TryParse(input, out var number))
                    {
                        anketa.petSum = number;
                        validInput = true; // Выход из цикла, если ввод корректен
                        anketa.NicknamesPet = petsNickname(anketa.petSum);
                }
                    else
                    {
                        Console.WriteLine("Ошибка. Введите корректное число.");
                    }
                }
            
            }

        bool validInput2 = false;

        while (!validInput2)
        {
            Console.WriteLine("Сколько у Вас любимых цветов?");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out var number))
            {
                anketa.colorSum = number;
                validInput2 = true; // Выход из цикла, если ввод корректен
                anketa.favorColor = favColor(anketa.colorSum);
            }
            else
            {
                Console.WriteLine("Ошибка. Введите корректное число.");
            }
        }

        Console.ReadKey();

        return anketa;
    }


    static bool CheckNum(string number, out int corrnumber)
    {
        if (int.TryParse(number, out int intnum) && intnum > 0)
        {
            if (intnum > 0)
            {
                corrnumber = intnum;
                return false;
            }
        }
        {

            Console.WriteLine("Ошибка. Введите данные повторно");
            corrnumber = 0;
            return true;
        }
    }
    static bool CheckStr(string str, out int corrstr)
    {
        if (int.TryParse(str, out int strstr) || string.IsNullOrEmpty(str) || str.Length > 20)
        {
            Console.WriteLine("Ошибка. Введите данные повторно");
            corrstr = 0;
            return true;
        }
            corrstr = 0;
            return false;
    }

    static string[] petsNickname(int petSum)
    {
        
        string[] petNicks = new string[petSum];

        for (int i = 0; i < petSum; i++)
        {
            do
            {
                Console.WriteLine("Имя Вашего питомца #{0}: ", i + 1);
                petNicks[i] = Console.ReadLine();

            } while (CheckStr(petNicks[i], out int corrstr));
        }

        return petNicks;
    }

    static string[] favColor (int colorCount)
    {
        string[] favColor = new string[colorCount];
        for (int i = 0; i < colorCount; i++)
        {
            do
            {
                Console.WriteLine("Ваш любимый цвет #{0}", i + 1);
                favColor[i] = Console.ReadLine();
                
            } while (CheckStr(favColor[i], out int corrstr));
        }
        return favColor;
    }

    static void ShowAnketa((string name, string lastName, int Age, string petOwner, int petSum, string[] NicknamesPet, int colorSum, string[] favorColor) anketa)
    {
        Console.WriteLine("Ваши данные: ");
        Console.WriteLine("Имя и Фамилия: {0} {1}.", anketa.name, anketa.lastName);
        Console.WriteLine("Возраст: {0}", anketa.Age);
        Console.WriteLine("Количество питомцев: {0}", anketa.petSum);
        if (anketa.petOwner == "да" && anketa.petSum > 0)
        {
            Console.WriteLine("Клички питомцев:");
            foreach (var nick in anketa.NicknamesPet)
            {
                Console.WriteLine(nick);
            }
        }

        Console.WriteLine("Любимые цвета:");
        foreach (var color in anketa.favorColor)
        {
            Console.WriteLine(color);
        }
    }
}