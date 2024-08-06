using System;
using System.Xml;

namespace Datas // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("     DATE TIME");
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(new string('-', 20));
            DateTime hoje = DateTime.Now; // Cria um objeto DateTime que representa o momento atual (data e hora) no sistema
            Console.WriteLine(hoje);
            Console.WriteLine(new string('-', 20));

            DateTime dia = new DateTime(2024, 08, 06); // Cria um objeto DateTime com uma data específica 
            Console.WriteLine(dia);
            Console.WriteLine(new string('-', 20));

            DateTime horas = new DateTime(2024, 08, 06, 14, 56, 23); // Cria um objeto DateTime com uma data e hora específicas
            Console.WriteLine(horas);
            Console.WriteLine(new string('-', 20));

            DateTime greenwich = DateTime.UtcNow; // Cria um objeto DateTime que representa o momento atual em Greenwich
            Console.WriteLine(greenwich);
            Console.WriteLine(new string('-', 20));

            DateTime formatadoBD = DateTime.Parse("2003-09-23");// Converte uma string de data em um objeto DateTime no formato padrão do banco de dados (yyyy-MM-dd)
            Console.WriteLine(formatadoBD);
            Console.WriteLine(new string('-', 20));

            DateTime brasil = DateTime.Parse("23/09/2003 15:00:00"); // Converte uma string de data e hora no formato brasileiro em um objeto DateTim
            Console.WriteLine(brasil);


            DateTime data = new DateTime(2003, 09, 23, 15, 49, 27, 250);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(data);
            Console.WriteLine(" 1) Data: " + data.Date);
            Console.WriteLine(" 2) Dia: " + data.Day);
            Console.WriteLine(" 3) Dia da Semana: " + data.DayOfWeek);
            Console.WriteLine(" 4) Dia da Ano: " + data.DayOfYear);
            Console.WriteLine(" 5) Horas: " + data.Hour);
            Console.WriteLine(" 6) Ano: " + data.Year);
            Console.WriteLine(" 7) Mês: " + data.Month);
            Console.WriteLine(" 8) Minutos: " + data.Minute);
            Console.WriteLine(" 9) Escrito: " + data.ToLongDateString());
            Console.WriteLine("10) Hora e Minuto: " + data.ToShortTimeString());
            Console.WriteLine("11) Add Dia: " + data.AddDays(2));
            Console.WriteLine("12) Add Hora: " + data.AddHours(3));


            Console.WriteLine(new string('-', 20));
            Console.WriteLine("     TIME SPAN"); // Duração de tempo    
            Console.WriteLine(new string('-', 20));

            Console.WriteLine(new string('-', 20));
            TimeSpan hora = new TimeSpan(2, 3, 4); // Cria um objeto TimeSpan que representa um intervalo de tempo de 2h, 3min e 4seg
            Console.WriteLine(hora);
            Console.WriteLine(new string('-', 20));


            TimeSpan diaMinSeg = new TimeSpan(9,2, 3, 4);// Cria um objeto TimeSpan que representa um intervalo de tempo de 9d 2h, 3min e 4seg
            Console.WriteLine(diaMinSeg);
            Console.WriteLine(new string('-', 20));

            TimeSpan fromDays = TimeSpan.FromDays(1.5); // Valor de 1 dia e meio
            Console.WriteLine(fromDays);
            Console.WriteLine(new string('-', 20));

            TimeSpan fromHoras = TimeSpan.FromHours(3.8); // Valor de 3.8 Horas
            Console.WriteLine(fromHoras);
            Console.WriteLine(new string('-', 20));


        }
    }
}