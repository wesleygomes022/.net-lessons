using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProj.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public Post()
        {

        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append("Moment: ");
            s.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            s.Append("Title: ");
            s.AppendLine(Title);
            s.Append("Content: ");
            s.AppendLine(Content);
            s.Append("Likes: ");
            s.AppendLine(Likes.ToString());
            foreach(Comment comment in Comments)
            {
                s.Append("Comment: ");
                s.AppendLine(comment.Text);
            }

            return s.ToString();
        }
    }
}
