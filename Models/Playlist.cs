using System.Text.Json;

namespace Models;

internal class Playlist
{
    // Propriedade para armazenar o nome do usuário
    public string? NomeUsuario { get; set; }
    // Propriedade para armazenar a lista de músicas na playlist
    public List<Music>? Musicas { get; }

    // Construtor que recebe o nome do usuário e inicializa a lista de músicas
    public Playlist(string nomeUsuario)
    {
        NomeUsuario = nomeUsuario;
        Musicas = new List<Music>();
    }

    // Método para adicionar uma música à playlist
    public void AdicionarMusicas(Music musica)
    {
        Musicas?.Add(musica);
    }

    // Método para exibir as músicas da playlist no console
    public void ExibirPlaylist()
    {
        Console.WriteLine($"\nEssas são as músicas favoritas do {NomeUsuario}:");
        foreach (var musica in Musicas!)
        {
            Console.WriteLine($"{musica.Artista} - {musica.Nome}");
        }
    }

    // Método para gerar um arquivo JSON com as informações da playlist
    public void GerarJson()
    {
        // Serializa as informações em formato JSON
        string json = JsonSerializer.Serialize(new 
        {
            nome = NomeUsuario,
            musicas = Musicas
        });

        // Nome do arquivo com base no nome do usuário
        string nomeArquivo = $"playlist-{NomeUsuario}.json";

        // Escreve o JSON em um arquivo
        File.WriteAllText(nomeArquivo, json);

        // Exibe mensagem indicando o sucesso na criação do arquivo
        Console.WriteLine($"Arquivo Json criado com sucesso!\n{Path.GetFullPath(nomeArquivo)}");
    }

    // Sobrescreve o método ToString para fornecer uma representação textual da playlist
    public override string ToString()
    {
        return $"Playlist de {NomeUsuario} contém {Musicas!.Count} músicas.";
    }
}
