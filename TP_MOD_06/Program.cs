class SayaTubeVideo
{
    private int id; private string title; private int playCount;

    public SayaTubeVideo(string title)
    {
        this.title = title;
        this.playCount = 0;

        Random random = new Random();
        this.id = random.Next(10000, 99999);
    }

    public void IncrasePlayCount(int count)
    {
        playCount += count;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"Video ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        string nama = "Muhammad Faqih Ainulyaqin";

        SayaTubeVideo sayaTubeVideo = new SayaTubeVideo($"Tutorial Design By Contract - {nama}");

        sayaTubeVideo.IncrasePlayCount(120);
        sayaTubeVideo.PrintVideoDetails();
    }
}