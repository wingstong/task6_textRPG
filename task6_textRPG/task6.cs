using System;

class task6
{
    static void Main()
    {
        int bossHealth = 444;
        int playerHealth = 222;
        bool bossAlive = true;
        bool playerAlive = true;
        bool isPlayerBlocking = false;


        Console.WriteLine("\t\tOnce in a medieval times...\n");
        Console.ReadKey();
        Console.WriteLine(" В древнем королевстве, окутанном тайнами и магией, вы, молодой \nтеневой маг, отправляетесь в опасное путешествие. Вам предстоит сразиться \nсо злобным Древним Злом, которое угрожает всему человечеству.....\n");
        Console.ReadKey();
        Console.WriteLine(" Ваш арсенал наполнен могущественными заклинаниями, способными \nнанести ужасный урон, но будьте осторожны - ваши силы могут обернуться против \nвас. Готовьтесь к схватке, где победить сможет только один..\n");
        Console.ReadKey();
        Console.WriteLine(" ..");
        Console.ReadKey();
        Console.WriteLine(" ...\n");
        Console.ReadKey();
        Console.WriteLine(" Вы находите небольшую пещерку, длинный коридор которой ведет \nвас в большое и мрачное подземелье..\n");
        Console.ReadKey();
        Console.WriteLine(" Когда вы приблизились к центру, из тьмы начали выползать ужасные \nсущества, слуги зла, готовые защищать своего господина..\n");
        Console.ReadKey();
        Console.WriteLine(" ..\n");
        Console.ReadKey();
        Console.WriteLine(" Наконец на вашем пути появился демон.. Начинается битва, которая \nрешит судьбу человечества на долгие годы..\n");
        Console.ReadKey();
        Console.WriteLine(" ...\n");


        while (bossAlive && playerAlive)
        {
            Console.WriteLine(" Выберите заклинание: \n 1 - Рашамон\t\t4 - Огненный шар\n 2 - Хуганзакура \t5 - Ледяной покров \n 3 - Вихрь теней  \t6 - Межпространственный разлом");
            int spell = Convert.ToInt32(Console.ReadLine());

            switch (spell)
            {
                case 1:
                    Console.WriteLine(" Вы призвали теневого духа для нанесения атаки. Он отнимает 100 хп у вас и наносит 100 урона демону.\n");
                    playerHealth -= 100;
                    bossHealth -= 100;
                    break;
                case 2:
                    if (playerHealth < 100)
                    {
                        Console.WriteLine(" Вы слишком слабы для использования Хуганзакура.\n");
                    }
                    else
                    {
                        Console.WriteLine(" Вы используете Хуганзакура и наносите 100 урона демону.\n");
                        bossHealth -= 100;
                    }
                    break;
                case 3:
                    Console.WriteLine(" Вы вызываете Вихрь теней, наносящий 120 урона демону.\n");
                    bossHealth -= 120;
                    break;
                case 4:
                    Console.WriteLine(" Вы кидаете Огненный шар и наносите 150 урона демону.\n");
                    bossHealth -= 150;
                    break;
                case 5:
                    Console.WriteLine(" Вы создаете Ледяной покров, который блокирует следующую атаку демона.\n");
                    isPlayerBlocking = true;
                    break;
                case 6:
                    Console.WriteLine(" Вы используете Межпространственный разлом и восстанавливаете 250 хп.\n");
                    playerHealth += 250;
                    break;
                default:
                    Console.WriteLine(" Неверное заклинание.\n");
                    break;
            }

            if (bossHealth <= 0)
            {
                bossAlive = false;
                Console.WriteLine(" Босс побежден! Человечеству больше ничего не угрожает!\n");
            }
            else
            {
                if (!isPlayerBlocking)
                {
                    int bossDamage = new Random().Next(20, 50);
                    playerHealth -= bossDamage;
                    Console.WriteLine(" Босс атакует вас и наносит " + bossDamage + " урона.\n");
                    if (playerHealth <= 0)
                    {
                        playerAlive = false;
                        Console.WriteLine(" Вы погибли. У людей не осталось надежды..\n");
                    }
                }
                else
                {
                    Console.WriteLine(" Босс пытается атаковать, но ваш Ледяной покров блокирует его атаку!\n");
                    isPlayerBlocking = false;
                }
            }
        }
    }
}
