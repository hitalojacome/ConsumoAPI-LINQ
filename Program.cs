using System.Text.Json;

// Importa os namespaces dos modelos (Models) e filtros (Filtros)
using Models;
using Filtros;

// Usando HttpClient crie um cliente
using (HttpClient client = new())
{
    try
    {
        // Armazena a resposta capturada como string do endpoint
        var response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        // Desserializa a resposta JSON em uma lista de objetos Music
        var musicas = JsonSerializer.Deserialize<List<Music>>(response)!;

        musicas[0].FixaTecnica();

        // Chama métodos estáticos da classe LinqFilter para realizar operações de filtragem        
        LinqFilter.FiltrarTodosGeneros(musicas);
        LinqOrder.ArtistasOrdenados(musicas);
        LinqFilter.FiltrarArtistasPorGenero(musicas, "rock");
        LinqFilter.FiltrarArtistasPorGenero(musicas, "hip hop");
        LinqFilter.FiltrarMusicasPorArtista(musicas, "2Pac");
        LinqFilter.FiltrarMusicasPorAno(musicas, "2003");

        // Cria uma nova playlist chamada "Hitalo" e adiciona algumas músicas a ela
        var playlistHitalo = new Playlist("Hitalo");
        playlistHitalo.AdicionarMusicas(musicas[1]);
        playlistHitalo.AdicionarMusicas(musicas[65]);
        playlistHitalo.AdicionarMusicas(musicas[8]);
        playlistHitalo.AdicionarMusicas(musicas[377]);
        playlistHitalo.AdicionarMusicas(musicas[1467]);
        // Exibe a playlist "Hitalo" no console
        playlistHitalo.ExibirPlaylist();
        // Gera um arquivo JSON com suas informações
        playlistHitalo.GerarJson();

    }
    catch (Exception e)
    {
        // Captura e imprime uma exceção, se ocorrer
        Console.WriteLine($"Ocorreu um erro na sua requisição : {e.Message}");
    }
}