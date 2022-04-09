using Task3;
class Program
{
    public static void Main()
    {
        DummyRequestHandler requestHandler = new();
        Console.WriteLine("приложение запущено");
        while (true)
        {
            Console.WriteLine("Введите текст запроса для отправки.Для выхода введите /exit");
            string message = Console.ReadLine();
            if (message != "/exit")
            {
                Console.WriteLine($"будет послано сообщение '{message}' ");
                SendRequest(message, requestHandler);
            }
            else
            {
                break;
            }
        }
    }
    static void SendRequest(string message, DummyRequestHandler handler)
    {
        LinkedList<string> arguments = new LinkedList<string>();
        while (true)
        {
            Console.WriteLine("Введите аргумент сообщения.Если аргументы не нужны введите /end");
            string argument = Console.ReadLine();
            if (argument != "/end")
            {
                arguments.AddFirst(argument);
            }
            else
            {
                Task.Run(() => HandleRequest(handler, message, arguments.ToArray()));
                break;
            }
        }
    }
    static void HandleRequest(DummyRequestHandler handler, string message, string[] arguments)
    {
        string number = Guid.NewGuid().ToString();
        Console.WriteLine($"было отправлено сообщение {message}.Присвоен номер {number}");
        try
        {
            var guid = handler.HandleRequest(message, arguments);
            Console.WriteLine($"Сообщение с  номером {number} получило ответ {guid}");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Сообщение с  номером {number} упало с ошибкой {ex.Message}");
        }
    }
}
