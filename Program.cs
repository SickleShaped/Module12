namespace Module12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            users.Add(new User("wabewaboo", "Аня", false));
            users.Add(new User("f,loprjmfkp", "Мейбл", true));
            users.Add(new User("SunnySunshine28", "Санни", false));
            users.Add(new User("3123123", "Ганс", true));
            users.Add(new User("grwgwergwbvefrb3rwe", "Труштыдынсилак Зунлинфаадасирах", true));

            foreach (var user in users)
            {
                MeetUser(user);
            }
        }

        static void MeetUser(User user)
        {
            if(user.IsPremium==false)
            {
                ShowAds();
            }
            Console.WriteLine($"Здравствуйте, {user.Name}");
        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}