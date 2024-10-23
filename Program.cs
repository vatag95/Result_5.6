using System;

class MainClass
{
    public static void Main(string[] args)
    {
        AddUser();
    }


    static (string name, int Age, string lastName, string petOwner, int petSum, string[] NicknamesPet) AddUser()
    {
        (string name, string lastName, int Age, string petOwner, int petSum, string[] NicknamesPet) anketa;

        Console.WriteLine("Введите Ваше имя: ");
        anketa.name = Console.ReadLine();

        Console.WriteLine("Введите Вашу фамилию: ");
        anketa.lastName = Console.ReadLine();

        string age;
        int intage;
        do
        {
            Console.WriteLine("Введите Ваш возраст ");
            age = Console.ReadLine();
        }
        while (CheckNum(age, out intage));

        Console.WriteLine("Есть ли у Вас питомец? да/нет");
        anketa.petOwner = Console.ReadLine();
        if (anketa.petOwner == "да")
        {
           
            do
            {
                Console.WriteLine("Сколько у Вас питомцев?");
                anketa.petSum = Convert.ToInt32(Console.ReadLine());
            }
            while(CheckNum(age, out intage));

            anketa.NicknamesPet = petsNickname(anketa.petSum);
        }

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
            corrnumber = 0;
            return true;
        }
    }

    static string[] petsNickname(int petSum)
    {
        
        string[] petNicks = new string[petSum];
        string nick;

        for (int i = 0; i < petSum; i++)
        {
                Console.WriteLine("Имя Вашего питомца #{0}: ", i + 1);
                nick = Console.ReadLine();
            petNicks[i] = nick;
        }

        return petNicks;
    }

    static string[] favColor (int colorCount)
    {

        return favColor;
    }
}