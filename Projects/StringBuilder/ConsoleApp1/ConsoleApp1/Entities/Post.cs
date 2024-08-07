using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    class Post
    {
        public DateTime Momento { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public int Likes { get; set; }
        public List<Comentario> comentarios { get; set; } = new List<Comentario>();

        public Post()
        {
        }

        public Post(DateTime momento, string titulo, string conteudo, int likes)
        {
            Momento = momento;
            Titulo = titulo;
            Conteudo = conteudo;
            Likes = likes;
        }

        public void AddComentario(Comentario comentario)
        {
            comentarios.Add(comentario);
        }

        public void RemoverComentario(Comentario comentario)
        {
            comentarios.Remove(comentario);
        }

        public override string ToString()
        {
            // Rever aula!!!
            StringBuilder sb = new StringBuilder();
            sb.Append(Titulo);
            sb.Append(Likes);
            sb.Append(" LIkes - ");
            sb.AppendLine(Momento.ToString("dd/MM/yyyy HH:mm"));
            sb.Append(Conteudo);
            sb.AppendLine("Comentarios: "); 
            foreach (var comentario in comentarios)
            {
                sb.AppendLine(comentario.Texto);
            }
            return sb.ToString();
        }

    }
}
