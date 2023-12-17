public sealed class Singleton
{
    private static Singleton instance;
    private static readonly object lockObject = new object();

    private Singleton()
    {
        // Конструктор може бути приватним, щоб завадити створенню нових екземплярів ззовні.
    }

    public static Singleton Instance
    {
        get
        {
            // Перевірка, чи екземпляр вже існує. Якщо ні, то створюємо його.
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }
            return instance;
        }
    }

    // Додайте інші методи чи властивості, які вам потрібні.
}

class Program
{
    static void Main()
    {
        // Виклик Singleton через Instance.
        Singleton singleton1 = Singleton.Instance;
        Singleton singleton2 = Singleton.Instance;

        // Порівняння двох екземплярів.
        if (singleton1 == singleton2)
        {
            Console.WriteLine("Обидва об'єкти є одним і тим же екземпляром Singleton.");
        }

        // Реалізуйте ваші тести та інші операції з Singleton тут.
    }
}
