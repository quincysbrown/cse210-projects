using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video video1 = new Video();
        video1._author = "Pewtie Pie";
        video1._title = "Super exciting New video";
        video1._length = 1236;

        Comment v1c1 = new Comment();
        v1c1._name = "John Smith";
        v1c1._text = "Love it!";
        video1._comments.Add(v1c1);

        Comment v1c2 = new Comment();
        v1c2._name = "John Doe";
        v1c2._text = "This could have been more exciting...";
        video1._comments.Add(v1c2);

        Comment v1c3 = new Comment();
        v1c3._name = "Jane Doe";
        v1c3._text = "YES YES YES!!!";
        video1._comments.Add(v1c3);

        _videos.Add(video1);

        Video video2 = new Video();
        video2._author = "DudePerfect";
        video2._title = "Some New Stereotypes Video";
        video2._length = 1436;

        Comment v2c1 = new Comment();
        v2c1._name = "Rick Davis";
        v2c1._text = "Hilarious";
        video2._comments.Add(v2c1);

        Comment v2c2 = new Comment();
        v2c2._name = "Shelly Aston";
        v2c2._text = "Sooooo TRUE!!";
        video2._comments.Add(v2c2);

        Comment v2c3 = new Comment();
        v2c3._name = "Dude Perfect Fan";
        v2c3._text = "I love how the Rage Monster is in every single one of these stereotype videos!";
        video2._comments.Add(v2c3);

        _videos.Add(video2);

        Video video3 = new Video();
        video3._author = "Markiplier";
        video3._title = "Try Not to Laugh Video #38";
        video3._length = 947;

        Comment v3c1 = new Comment();
        v3c1._name = "Brody Campbell";
        v3c1._text = "I love how Mark keeps trying to make this work, maybe someday he will actually not laugh.";
        video3._comments.Add(v3c1);

        Comment v3c2 = new Comment();
        v3c2._name = "Ben Bailey";
        v3c2._text = "I made it all the way through without laughing, it wasn't that hard.";
        video3._comments.Add(v3c2);

        Comment v3c3 = new Comment();
        v3c3._name = "Anna Smith";
        v3c3._text = "I busted up laughing when Mark did! He is literally the funniest part of these videos!";
        video3._comments.Add(v3c3);

        _videos.Add(video3);

        Console.Clear();
        foreach (Video video in _videos)
        {
            video.Display();
        }
    }
}