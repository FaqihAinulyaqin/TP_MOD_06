using System;

class SayaTubeVideo
{
    private int id; private string title; private int playCount;

    public SayaTubeVideo(string title)
    {
        if(title == null || title.Length > 100)
        {
            throw new ArgumentException("Judul video harus memiliki panjang maksimal 100 karakter dan tidak boleh null.");
        }

        Random random = new Random();
        this.id = random.Next(10000, 99999);

        this.title = title;
        this.playCount = 0;
    }

    public void IncrasePlayCount(int count)
    {
        try
        {
            checked
            {
                playCount += count;
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
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

        try
        {
            SayaTubeVideo video = new SayaTubeVideo(null);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        try
        {
            string judul = new string('s', 101);
            SayaTubeVideo video = new SayaTubeVideo(judul);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        SayaTubeVideo sayaTubeVideo = new SayaTubeVideo($"Tutorial Design By Contract - {nama}");
        for(int i = 0; i < 2; i++)
        {
            try
            {
                sayaTubeVideo.IncrasePlayCount(2000000000);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        sayaTubeVideo.PrintVideoDetails();
    }
}