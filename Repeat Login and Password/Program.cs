using System;

namespace Repeat_Login_and_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            //База логинов и паролей
            string username = "Marat888";
            string password = "228Marat";

            //Создаем значение счетчика
            int CountLogin = 1;

            Console.WriteLine("Здравствуйте!, Пожалуйста введите Логин и Пароль, для входа в систему");
            //повторяющий цикл до того момента пока ваш цикл не будет <True>
            while (true)
            {
                //Начале мы проверяем сколько попыток было у пользователя
                if (CountLogin != 4)
                {
                   
                    //тут мы пишем сообщение 
                    Console.Write("Введите имя пользователя: ");
                    string currentUsername = Console.ReadLine();
                    Console.Write("Введите пароль: ");
                    string currentPassword = Console.ReadLine();
                    //Провека Имени и Пароля
                    if (currentUsername == username & currentPassword == password)
                    {
                        Console.WriteLine("Поздравляю вас! Вы успешно прошли авторизацию");
                        break;
                    }
                    //Если имя или пароль не совпадают
                    else
                    {
                        String RepeatNumber = CountLogin.ToString();
                        Console.WriteLine($"У вас еще есть:  { RepeatNumber}  Попытки");
                        Console.WriteLine("Вы ввели не верно Имя пользователя или Пароль! Пожалуйста, повторите попытку.");
                        CountLogin++;
                    }

                }
                //Если закончились попытки выводит следующие сообщение
                else
                {

                    Console.WriteLine("Превышен лимит попыток входа, ваш ip временно был заблокирован, повторите попытку позже");
                    break;

                }

            }
            Console.ReadKey();

        }
    }
}
