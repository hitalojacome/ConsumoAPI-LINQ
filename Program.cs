using System.Text.Json;
using Models;
using Filtros;

// Usando HttpClient crie um cliente
using (HttpClient client = new())
{
    try
    {
        // Armazena a resposta capturada como string do endpoint
        var response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Music>>(response)!;

        //LinqFilter.FiltrarTodosGeneros(musicas);
        //LinqOrder.ArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGenero(musicas, "rock");
        //LinqFilter.FiltrarArtistasPorGenero(musicas, "hip hop");
        //LinqFilter.FiltrarMusicasPorArtista(musicas, "2Pac");
        // LinqFilter.FiltrarMusicasPorAno(musicas, "2003");
    }
    catch (Exception e)
    {
        Console.WriteLine($"Ocorreu um erro na sua requisição : {e.Message}");
    }
}