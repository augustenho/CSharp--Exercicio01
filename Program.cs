
class Jogos
{
    public string Nome { get; }
    public string Genero { get; }
    public int AnoLancamento { get; }

    public Jogos(string nome, string genero, int ano)
    {
        Nome = nome;
        Genero = genero;
        AnoLancamento = ano;

    }

}

class Catalogo
{
    private List<Jogos> jogos {  get; set; }
    public Catalogo()
    {
        jogos = new List<Jogos>();
    }

    public void AdicionarJogos(string nome, string genero, int ano)
    {
        Jogos jogo = new Jogos(nome, genero, ano);
        jogos.Add(jogo);
        Console.WriteLine($"O jogo {jogo.Nome} foi adicionado com sucesso!");
        Thread.Sleep(2000);
    }

    int Contador = 0;

    public void Exibir()
    {

        Console.Clear();
        Console.WriteLine("Lista de Jogos\n");
        foreach (var games in jogos)
        {
            Contador++;
            Console.WriteLine($"{Contador}º - Jogo: {games.Nome} - Gênero: {games.Genero}.");
        }
        if (Contador == 0)
        {
            Console.WriteLine("Não há lista de Jogos");
        
        }
    }
}

