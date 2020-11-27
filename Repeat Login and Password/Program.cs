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
            int CountLogin = 2;

            Console.WriteLine("Здравствуйте!, Пожалуйста введите Логин и Пароль, для входа в систему");
            //повторяющий цикл до того момента пока ваш цикл не будет <True>
            while (true)
            {
                //Начале мы проверяем сколько попыток было у пользователя
                if (CountLogin >= 0)
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
                    //Созадем цикл проверяет если счетчик = 0, то программа выполняет цикл выводит сообщение, что <Что у вас закончились попытки>
                    //C помощью Break мы завершаем программу While
                    {
                        if (CountLogin > 0 )
                        {
                            String RepeatNumber = CountLogin.ToString();
                            Console.WriteLine($"У вас еще есть:  { RepeatNumber}  Попытки");
                            Console.WriteLine("Вы ввели не верно Имя пользователя или Пароль! Пожалуйста, повторите попытку.");
                            CountLogin--;
                        }
                        else
                            if (CountLogin == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("У вас закончились попытки");
                            Console.WriteLine();
                            break;
                        }
                    }

                }
                //Если закончились попытки выводит следующие сообщение
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Превышен лимит попыток входа, ваш ip временно был заблокирован, повторите попытку позже");
                    break;

                }

            }
            Console.ReadKey();

        }
    }
}
