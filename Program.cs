using System.Collections.Generic;

namespace ListaObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //criar lista
            List<Cartao> Cartoes = new List<Cartao>();

            //Novos Produtos
            Cartoes.Add(new Cartao("Gabriel",12345678,"Brasil",2021,971));
            Cartoes.Add(new Cartao("Gabriel2",83748763,"Canadá",2022,860));
            Cartoes.Add(new Cartao("Gabriel3",97243781,"EUA",2023,481));
            Cartoes.Add(new Cartao("Gabriel4",92690171,"Itália",2024,991));
            Cartoes.Add(new Cartao("Gabriel5",98765432,"China",2025,389));

            //Mostrar Cartões
               foreach(Cartao p in Cartoes){
                System.Console.WriteLine($"{p.Titular} - {p.Numero} - {p.Bandeira} - {p.Vencimento} - {p.CVV}");
            
            }
        }
    }
}
