using System.Text.Json.Serialization;

namespace Models;

internal class Music
{
    // Array de strings representando as tonalidades musicais
    private string?[] _tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };

    // Anotação para mapeamento do JSON (JsonPropertyName)
    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    [JsonPropertyName("year")]
    public string? Ano { get; set; }

    // Atributo 'Key' representa a tonalidade da música
    [JsonPropertyName("key")]
    public int Key { get; set; }

    // Propriedade 'Tonalidade' que retorna a tonalidade da música com base na chave
    public string? Tonalidade 
    { 
        get 
        {
            return _tonalidades[Key];
        }
    }

    // Método que imprime informações sobre a música
    public void FixaTecnica()
    {
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração em segundos: {Duracao / 1000}");
        Console.WriteLine($"Gênero musical: {Genero}");
        Console.WriteLine($"Tonalidade: {Tonalidade}");
    }
}
