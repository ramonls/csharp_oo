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

        /*
         * Como temos muitas informações a ser mostradas, e se for acrescentado mais comentarios teremos
         * que acrescentar mais informações, e ficar concatenando string, irá degradar a performece da aplicação,
         * para facilitar, vamos usar o StringBuilder.
         * 
         * StringBuilder --> Ele é responsável por fazer uma montagem de uma string, conforme o programador mandar
         * de uma forma muito eficiente, e depois quando tiver pronto, pegamos o resultado em forma de string.
         * Para usar ele, temos que instancia-lo, ele pertence ao namespace System.text;
         * Append (acrescentar)
         * 
         * 
         * 
         */

        public override string ToString()
        {
            //instanciar um objeto StringBuilder
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");

            foreach(Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }

            return sb.ToString(); //Converter todo o conteúdo do sb que é um StringBuilder em string
        }
    }
}
