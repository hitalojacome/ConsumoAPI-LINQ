using System.Text.Json.Serialization;

namespace Models;

internal class Music
{
    // Anotação que informa o campo do arquivo json que referencia a propriedade
    [JsonPropertyName("song")]
    public string? Nome { get; set; }
    // Sem a anotação
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    public void FixaTecnica()
    {
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração em segundos: {Duracao / 1000}");
        Console.WriteLine($"Gênero musical: {Genero}");
    }
}
