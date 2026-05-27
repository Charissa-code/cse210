using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        List<Video> videosList = new List<Video>();

        Video video1 = new Video("Oatmeal and Honey Soap With Dawna", "Dawna Cott", 763);
        videosList.Add(video1);
        video1.AddComment(new Comment("Minni Dawn", "My skin is so sensitive and this soap was so gentle and kind to my skin. It's soft and nourishing and it did make me break out. Do you sell this stuff?"));
        video1.AddComment(new Comment("Sara Hane", "This soap smells amazing I swear if I didn't know better I would think it was a oatmeal cookie!"));
        video1.AddComment(new Comment("Jane Stance", "That's a lot of ingredients but I can't wait to make this. Oatmeal honey soap is my favorite!"));

        Video video2 = new Video("Cruise Packing Hacks", "Stacey McDonnel", 895);
        videosList.Add(video2);
        video2.AddComment(new Comment("Jack A.", "Oh man this helped me get ready for my first cruise and I felt like I had everything that I needed without over packing Thanks joy"));
        video2.AddComment(new Comment("Gordon Reese", "Helpful, Subscribed Commented done."));
        video2.AddComment(new Comment("June Storm", "Great hacks for a cruise but also for packing in general…will use this from now on"));


        Video video3 = new Video("Concrete Lily Pad Fountain", "Ed Taylor", 538);
        videosList.Add(video3);
        video3.AddComment(new Comment("Stacy Johnson", "Holy cow this is so much easier than I thought! I can't wait to do my next concrete fountain for the other garden."));
        video3.AddComment(new Comment("Tammy Sue", "I have made these before but the way that this was explained was so much easier and the results are to die for. I'll be making more for sure."));
        video3.AddComment(new Comment("Liz Dell", "I wonder if I can do this with flower pedals instead of Lily pads."));
        video3.AddComment(new Comment("Kris", "One of my favorite things to do is work with concrete. More projects are in my future."));

        Video video4 = new Video("5 Profitable App Ideas", "Steve Appster", 498);
        videosList.Add(video4);
        video4.AddComment(new Comment("Andy Johnson", "Yeah everybody says their ideas are profitable. I don't believe it when I see it."));
        video4.AddComment(new Comment("Claude Hidde", "Don't they have an app for everything yet? Just saying."));
        video4.AddComment(new Comment("Bob Roberts", "Nice- subscribed"));


        foreach (Video video in videosList)
        {
            Console.WriteLine("                                           ");
            Console.WriteLine($"Video Title:   '{video.Title}'");
            Console.WriteLine($"Author:   {video.Author}");
            Console.WriteLine($"Length:   {video.LenInSecs} seconds");
            Console.WriteLine($"Comments:   {video.Comments()}");
            Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````````````````````````````````````");
            foreach(Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.CommenterName}:   {comment.CommentText}");
            }
            Console.WriteLine("=====================================================================================================================");
        }
    }
}



