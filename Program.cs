using System.Collections.Generic;

namespace ListaObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //criar lista
            List<VideoGames> videoGames = new List<VideoGames>();

            //Novos Produtos
            videoGames.Add(new VideoGames(1, "PS5",2680.00f));
            videoGames.Add(new VideoGames(2, "Xbox One X",2250.00f));
            videoGames.Add(new VideoGames(3, "Nintendo Switch",2000.00f));
            videoGames.Add(new VideoGames(4, "PS4",1800.00f));
            videoGames.Add(new VideoGames(5, "Xbox 360",600.00f));

            //Mostrar Produto
            foreach(VideoGames p in videoGames){
                System.Console.WriteLine($" {p.Nome} - R${p.Preco}");
            }
        }
    }
}
