using System;

enum STARTSELECT
{
    SELECTTOWN,SELECTBATTLE,NONESELCET
}

class Player
{
    int AT = 10;
    int HP = 50;
    int MAXHP = 100;

    public void StatusRender()
    {
        Console.WriteLine("--------------------------------------");
        Console.Write("공격력 : ");
        Console.WriteLine(AT);
        Console.Write("체력 : ");
        Console.Write(HP);
        Console.Write("/");
        Console.WriteLine(MAXHP);
        Console.WriteLine("--------------------------------------");
    }

    public void RestoreHealth()
    {
        HP = MAXHP;
    }

    public void Enhance()
    {
        AT++;
    }
}

namespace CSharpStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Player newPlayer = new Player();
            while(true)
            {
                STARTSELECT selectCheck = StartSelect();

                switch(selectCheck)
                {
                    case STARTSELECT.SELECTTOWN:
                        Town(newPlayer);
                        break;
                    case STARTSELECT.SELECTBATTLE:
                        Battle(newPlayer);
                        break;
                    default:
                        break;
                }
            }

        }

        static STARTSELECT StartSelect()
        {
            Console.Clear();
            Console.WriteLine("1. 마을\n2. 배틀\n어디로 가시겠습니까?\n");
            ConsoleKeyInfo CKI = Console.ReadKey();
            switch(CKI.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("\n마을로 이동합니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTTOWN;
                case ConsoleKey.D2:
                    Console.WriteLine("\n배틀을 시작합니다.");
                    Console.ReadKey();
                    return STARTSELECT.SELECTBATTLE;
                default:
                    Console.WriteLine("\n잘못된 선택입니다.");
                    Console.ReadKey();
                    return STARTSELECT.NONESELCET;
            }
        }

        static void Town(Player player)
        {
            while(true)
            {
                Console.Clear();
                player.StatusRender();
                Console.WriteLine("\n마을에서 무슨일을 하시겠습니까?");
                Console.WriteLine("\n1. 체력을 회복한다.\n2. 무기를 강화한다.\n3. 마을을 나간다.");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        player.RestoreHealth();
                        break;
                    case ConsoleKey.D2:
                        player.Enhance();
                        break;
                    default:
                        return;
                }
            }
        }

        static void Battle(Player player)
        {
            Console.WriteLine("\n아직 개장하지 않았습니다.");
            Console.ReadKey();
        }
    }
}
