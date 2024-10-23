using System;
using System.Reflection.Metadata.Ecma335;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ответьте на вопросы ниже, для заполнения анкеты:");
        AddUser();
    }


    static (string name, int Age, string lastName, string petOwner, int petSum, string[] NicknamesPet, int colorSum, string[] favorColor) AddUser()
    {
        (string name, string lastName, int Age, string petOwner, int petSum, string[] NicknamesPet, int colorSum, string[] favorColor) anketa;

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

        do
        {
            Console.WriteLine("Введите Ваш возраст ");
            age = Console.ReadLine();
        }
        while (CheckNum(age, out intage));

        do
        {
            Console.WriteLine("Есть ли у Вас питомец? да/нет");
            anketa.petOwner = Console.ReadLine();
        } while (CheckStr(anketa.petOwner, out int corrstr));
       
        if (anketa.petOwner == "да")
        {
            
            
                Console.WriteLine("Сколько у Вас питомцев?");
                string? input = Console.ReadLine();

                bool result = int.TryParse(input, out var number);
            
                if (result == true)
                {
                    anketa.petSum = number;
                }
                else if (result == false)
            {
                Console.WriteLine("Ошибка. Введите данные повторно");
            }

             
        }
       
        do
        {
            Console.WriteLine("Сколько у Вас любимых цветов?");
            anketa.colorSum = Convert.ToInt32(Console.ReadLine());
        }
        while (CheckNum(age, out intage));

        anketa.favorColor = favColor(anketa.colorSum);

        Console.ReadKey();

        return AddUser();
     }


    static bool CheckNum(string number, out int corrnumber)
    {
        if (int.TryParse(number, out int intnum))
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
        if (int.TryParse(str, out int strstr))
        {
            Console.WriteLine("Ошибка. Введите данные повторно");
            corrstr = strstr;
            return true;
        }
        else if (string.IsNullOrEmpty(str) || str.Length > 20)
        {
            Console.WriteLine("Ошибка. Введите данные повторно");
            corrstr = strstr;
            return true;
        }
        
        corrstr = 0;
        return false;
    }

    static string[] petsNickname(int petSum)
    {
        
        string[] petNicks = new string[petSum];
        string nick;

        for (int i = 0; i < petSum; i++)
        {
            do
            {
                Console.WriteLine("Имя Вашего питомца #{0}: ", i + 1);
                nick = Console.ReadLine();

            } while (CheckStr(nick, out int corrstr));
            petNicks[i] = nick;
        }

        return petNicks;
    }

    static string[] favColor (int colorCount)
    {
        string[] favColor = new string[colorCount];
        string color;
        for (int i = 0; i < colorCount; i++)
        {
            do
            {
                Console.WriteLine("Ваш любимый цвет #{0}", i + 1);
                color = Console.ReadLine();
                
            } while (CheckStr(color, out int corrstr));
            favColor[i] = color;
        }
        return favColor;
    }

    static void ShowAnketa((string userName, string userSurname, byte userAge, string[] NicknamesPet, string[] favColor) userAnketa)
    {

    }
}