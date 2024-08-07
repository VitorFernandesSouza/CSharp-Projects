using ConsoleApp1.Entities;
using System;

namespace ConsoleApp1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comentario comentario1 = new Comentario("Tenha uma boa viagem!");
            Comentario comentario2 = new Comentario("Uau que legal!");

            Post post = new Post(
                DateTime.Parse("23/09/2003 15:30:00"),
                "Viajando para Espanha!",
                "Estou indo visitar esse país maravilhoso!",
                12 );

            post.AddComentario(comentario1);
            post.AddComentario(comentario2);

            Comentario comentario3 = new Comentario("Boa Noite!");
            Comentario comentariio4 = new Comentario("Que a força esteja com vc!");

            Post post2 = new Post(
                DateTime.Parse("16/07/2005 23:58:30"),
                "Boa noite, galera!",
                "Vejo vcs amanhã.",
                5 );

            post2.AddComentario(comentario3);
            post2.AddComentario(comentariio4);



            Console.WriteLine(post);
            Console.WriteLine(post2);
        }
    }
}