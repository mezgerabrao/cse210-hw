using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How AI Is Changing Product Marketing", "Growth Lab", 420);
        video1.AddComment(new Comment("Carlos", "This was very helpful and easy to understand."));
        video1.AddComment(new Comment("Julia", "I liked the examples about customer behavior."));
        video1.AddComment(new Comment("Marcos", "Great explanation about AI tools."));

        Video video2 = new Video("Beginner C# Classes Tutorial", "Code Basics", 615);
        video2.AddComment(new Comment("Ana", "This helped me understand classes better."));
        video2.AddComment(new Comment("Pedro", "The examples were simple and clear."));
        video2.AddComment(new Comment("Bianca", "I finally understand objects and methods."));

        Video video3 = new Video("Building Better Customer Experiences", "CX Academy", 540);
        video3.AddComment(new Comment("Rafael", "Good points about listening to customers."));
        video3.AddComment(new Comment("Fernanda", "I liked the part about reducing friction."));
        video3.AddComment(new Comment("Lucas", "Very practical and useful video."));

        Video video4 = new Video("Software Design with Abstraction", "Dev Mentor", 480);
        video4.AddComment(new Comment("Amanda", "The abstraction example made sense."));
        video4.AddComment(new Comment("Bruno", "This helped me prepare for my class."));
        video4.AddComment(new Comment("Clara", "Good explanation of responsibilities."));
        video4.AddComment(new Comment("Diego", "Nice video. The code examples were clear."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}