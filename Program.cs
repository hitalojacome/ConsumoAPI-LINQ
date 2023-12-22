using System.Text.Json;
using Models;

// Usando HttpClient crie um cliente
using (HttpClient client = new())
{
    try
    {
        // Armazena a resposta capturada como string do endpoint
        var response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Music>>(response)!;
        // Método que faz parte da biblioteca de serialização e desserialização (conversão) JSON. Ele converte um formato JSON em objetos do tipo especificado. Isso especifica o tipo de objeto para o qual o JSON deve ser desserializado neste caso, é uma lista de objetos do tipo Music.
        musicas[0].FixaTecnica();

        foreach(Music musica in musicas)
        {
            Console.WriteLine(musica.Genero);
        }
    }
    catch (Exception e)
    {
        Console.WriteLine($"Ocorreu um erro na sua requisição : {e.Message}");
    }
}