using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostTravel.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public String Content { get; set; }
        public int Likes { get; set; }
        //propriedade de associação para a classe comment, instanciar para garantir que ele não fique nulo
        public List<Comment> Comments { get; set; } = new List<Comment>();

        //Construtores
        public Post()
        {
        }

        public Post (DateTime moment, string title, string content, int likes)
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
    }
}
