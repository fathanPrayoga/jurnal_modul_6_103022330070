using System;
using jurnalModul6_103022330070;

class Program
{
    static void Main(string[] args)
    {
        SayaTubeUser user = new SayaTubeUser("Fathan Prayoga Wicaksono");

        string[] judulFilm =
        {
            "Review film Suster ngesot oleh Fathan Prayoga Wicaksono",
            "Review film The Batman oleh Fathan Prayoga Wicaksono",
            "Review film Gone Girl oleh Fathan Prayoga Wicaksono",
            "Review film Aftersun oleh Fathan Prayoga Wicaksono",
            "Review film Se7en oleh Fathan Prayoga Wicaksono",
            "Review film Dune oleh Fathan Prayoga Wicaksono",
            "Review film Star Wars oleh Fathan Prayoga Wicaksono",
            "Review film pocong oleh Fathan Prayoga Wicaksono",
            "Review film Pulp Fiction oleh Fathan Prayoga Wicaksono",
            "Review film Suster ngesot reborn oleh Fathan Prayoga Wicaksono",
        };

        for (int i = 0;  i < judulFilm.Length; i++)
        {
            SayaTubeVideo video = new SayaTubeVideo(judulFilm[i]);
            user.AddVideo(video);
            video.IncreasePlayCount(new Random().Next(10, 100));
        }

        user.PrintAllVideo();
        Console.WriteLine($"total play count: {user.GetTotalVideoPlayCount()}");

    }
}