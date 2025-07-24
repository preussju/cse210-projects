using System;
using System.Net;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video> {

        new Video {
            _title = "How to Draw a Cat",
            _author = "Jururu",
            _length = 120,
            _comments = new List<Comment>
            {
                new Comment { _person = "Carlos", _text = "Just What I needed!" },
                new Comment { _person = "Ana", _text = "Looks like a bear.." },
                new Comment { _person = "Carla", _text = "Short and clear" },
                new Comment { _person = "John", _text = "I cannot do this? " }
            }
        },

                new Video {
            _title = "Top 10 places in Brazil",
            _author = "Exploring the WRLD",
            _length = 932,
            _comments = new List<Comment>
            {
                new Comment { _person = "Mark", _text = "Beautiful place!" },
                new Comment { _person = "Elisandro", _text = "Brazil mentioned!!!!" },
                new Comment { _person = "Alice", _text = "I would be afraid.. " },
            }
        },
                new Video {
            _title = "The Game - Teaser",
            _author = "games community",
            _length = 50,
            _comments = new List<Comment>
            {
                new Comment { _person = "Elias", _text = "Did I lose?" },
                new Comment { _person = "Maria", _text = "Cannot wait to play!" },
                new Comment { _person = "Andrey", _text = "Seems like a copy of the other game.." },
                new Comment { _person = "James", _text = "Look at the graphics!!!" }
            }
        }
    };

        foreach (var vid in videoList)
        {
            vid.DisplayVideo();
            Console.WriteLine();
        }
    }
}