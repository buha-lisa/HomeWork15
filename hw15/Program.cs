namespace hw15
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Choose number of task(1-3): ");
                int.TryParse(Console.ReadLine(), out int task);
                if (task == 0) break;
                var play = new StagePlay()
                {
                    PlayName = "A doll's house",
                    AuthorFullName = "Henrik Ibsen",
                    Genre = "Stage play",
                    PublishYear = 1879
                };

                var shop = new Shop()
                {
                    Name = "Sportlandia",
                    Address = "Stepan Bandera lane, 2/1a",
                    ShopType = "Clothes"
                };

                switch (task)
                {
                    case 1:
                        play.DisplayInfo();

                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        break;
                    case 2:
                        shop.DisplayInfo();
                        shop.Dispose();
                        Console.WriteLine($"The shop '{shop.Name}' from '{shop.Address}' is being dispose.\n");
                        break;
                    case 3:
                        play.DisplayInfo();
                        play.Dispose();

                        Console.WriteLine($"The play '{play.PlayName}' from '{play.AuthorFullName}' is being dispose.\n");
                        shop.DisplayInfo();

                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        break;
                }
            }

        }
    }
}
