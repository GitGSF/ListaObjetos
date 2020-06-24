namespace ListaObjetos
{
    public class VideoGames
    {
        public int Codigo {get; set;}
        public string Nome {get; set;}
        public float Preco {get; set;}

        public VideoGames(){
        }

        public VideoGames(int _codigo, string _nome, float _preco)
        {
            this.Codigo = _codigo;
            this.Nome = _nome;
            this.Preco = _preco;
        
        }
    }
}