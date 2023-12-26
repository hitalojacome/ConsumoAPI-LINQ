using Models;

namespace Filtros;

internal class LinqOrder
{
    // Método estático que ordena e exibe a lista de artistas
    public static void ArtistasOrdenados(List<Music> musicas)
    {
        // Ordena a lista de músicas pelo nome do artista
        var artistasOrdenados = musicas.OrderBy(musicas => musicas.Artista)
        .Select(musicas => musicas.Artista) // Seleciona apenas o nome do artista
        .Distinct() // Remove artistas duplicados
        .ToList(); // Converte a lista final para uma lista e armazena em 'artistasOrdenados'

        // Imprime a lista ordenada de artistas
        Console.WriteLine("Lista de artistas ordenados:");
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}