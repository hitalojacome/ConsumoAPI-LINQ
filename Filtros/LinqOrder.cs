using System.Linq;
using Models;

namespace Filtros;

internal class LinqOrder
{
    public static void ArtistasOrdenados(List<Music> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musicas => musicas.Artista).Select(musicas => musicas.Artista).Distinct().ToList();

        Console.WriteLine("Lista de artistas ordenados:");
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}