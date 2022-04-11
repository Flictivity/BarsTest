using System;
class Program
{
    static DummyRequestHandler requestHandler = new DummyRequestHandler();
    static void Main()
    {
        string message;

        Console.WriteLine("Приложение зарущено");
        Console.WriteLine("Введите текст запроса для отправки."
                + "Для выхода /exit");
        while ((message = Console.ReadLine()) != "/exit")
        {
            string argument;
            var arguments = new List<string>();

            Console.WriteLine($"Будет послано сообщение \'{message}\'");
            Console.WriteLine("Введите аргументы сообщения. " +
                "Если аргументы не нужны - введите /end");

            while ((argument = Console.ReadLine()) != "/end")
            {
                arguments.Add(argument);
                Console.WriteLine("Введите следующий аргумент сообщения. " +
                    "Для окончания добавления аргументов введите /end");
            }

            var id = Guid.NewGuid().ToString("D");
            Console.WriteLine($"Было отправлено сообщение \'{message}\'. " +
                $"Присвоен идентификатор {id}");

            ThreadPool.QueueUserWorkItem(callBack =>
                RequestHandler(message, arguments.ToArray(), id));

            Console.WriteLine("Введите текст запроса для отправки."
            + "Для выхода /exit");
        }
        Console.WriteLine("Конец работы");
    }
    private static void RequestHandler(string message, string[] arguments,
                                                                    string id)
    {
        try
        {
            var res = requestHandler.HandleRequest(message,
                                                    arguments.ToArray());
            Console.WriteLine($"Сообщение с идентификатором{id} " +
                $"получило ответ - {res}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Сообщение имеющее ID{id} упало с ошибкой" +
                $" {ex.Message}");
        }

    }
}

