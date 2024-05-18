
namespace hw15
{
    class StagePlay : IDisposable
    {
        public string PlayName { get; set; }
        public string AuthorFullName { get; set; }
        public string Genre { get; set; }
        public int PublishYear { get; set; }

        public StagePlay() { }

        ~StagePlay()
        {
            Console.WriteLine($"The play '{PlayName}' from '{AuthorFullName}' is being destroyed.");
        }

        public void Dispose() { }


        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {PlayName}");
            Console.WriteLine($"Author: {AuthorFullName}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Year of publishing: {PublishYear}");
        }
    }
}
