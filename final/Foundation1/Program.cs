using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Marsh - Lailonie (Extended Mix)", "Marsh", 413000);
        video1.AddComment("Jorge Menjivar", "Great Song");
        video1.AddComment("Ronald Garcia", "What a banger!");
        video1.AddComment("Luis Sosa", "Listened to it live, still can't believe it");
        videos.Add(video1);

        Video video2 = new Video("3 new videos that you don't want to watch alone", "Dross Rotzank", 543000);
        video2.AddComment("Alex Seas", "Dross never disappoints");
        video2.AddComment("Ariel Savannah", "Saturday off, a great meal, new video by Dross, could it be better?");
        video2.AddComment("Grace Hernandez", "Not gonna lie, this one scared me");
        video2.AddComment("@anotheruser1990", "The first video seems to be fake");
        videos.Add(video2);

        Video video3 = new Video("Above & Beyond - Tomorrowland 2018 - Mainstage", "Above&Beyond", 3600000);
        video3.AddComment("Sn0xxi", "One of the best sets ever played at Tomorrowland");
        video3.AddComment("Victor Krum", "Ladies and Gentlemen this is a perfect and real Trance set !!!");
        video3.AddComment("alanmartins1985", "This was a really amasing set! No screaming, no talking just awesome music!");
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine(video.GetString());
            Console.WriteLine();
            Console.WriteLine("Comments:");
            Console.WriteLine($"This video has {video.NumberOfComments()} comments.");
            Console.WriteLine();
            Console.WriteLine(video.GetCommentString());
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}