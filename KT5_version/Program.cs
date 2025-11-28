namespace KT5_version;

class Program
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Пользователь: {Name}, Возраст: {Age}");
        }

        public bool IsAdult()
        {
            return Age >= 18;
        }
    }

    static void Main(string[] args)
    {
        string version = "unknown";
        if (File.Exists("version.txt"))
        {
            string[] lines = File.ReadAllLines("version.txt");
            foreach (string line in lines)
            {
                if (line.StartsWith("Current="))
                {
                    version = line.Split('=')[1].Trim();
                    break;
                }
            }
        }
        User user1 = new User("Иван", 25);
        User user2 = new User("Анна", 16);

        user1.DisplayInfo();
        Console.WriteLine($"Совершеннолетний: {user1.IsAdult()}");

        user2.DisplayInfo();
        Console.WriteLine($"Совершеннолетняя: {user2.IsAdult()}");

    }
}

