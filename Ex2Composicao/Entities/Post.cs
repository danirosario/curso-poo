using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2Composicao.Entities
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post() { }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(); // StringBuilder is a class in the System.Text namespace that provides an efficient way to manipulate strings. It is used to create a mutable string that can be modified without creating a new string object each time.
            sb.AppendLine(Title); // AppendLine adds a new line after the string
            sb.Append(Likes); // Append does not add a new line after the string
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");
            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.Text); 
            }
            return sb.ToString();   // ToString is used to convert an object to a string representation. In this case, it is used to create a string representation of the Post object, including its title, likes, moment, content, and comments.
        }

    }
}
