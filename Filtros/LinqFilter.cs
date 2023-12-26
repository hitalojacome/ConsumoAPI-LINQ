using Models;

namespace Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosGeneros(List<Music> musicas)
    {
        var todosGeneros = musicas.Select(genero => genero.Genero) // seleciona apenas o genero das músicas
        .Distinct() // remove as duplicidades
        .ToList(); // converte o resultado em uma lista

        foreach (var genero in todosGeneros)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGenero(List<Music> musicas, string genero)
    {
        var artistaPorGenero = musicas.Where(musica => musica.Genero!.Contains(genero)) // encontra as musicas onde o genero corresponde ao genero passado
        .Select(musica => musica.Artista) // seleciona apenas o artista das músicas
        .Distinct() // remove as duplicidades
        .ToList(); // converte o resultado em uma lista

        Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}");
        foreach (var artista in artistaPorGenero)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasPorArtista(List<Music> musicas, string nomeArtista)
    {
        var musicaArtista = musicas.Where(musica => musica.Artista!.Equals(nomeArtista))
        .ToList(); // converte o resultado em uma lista

        Console.WriteLine(nomeArtista);
        foreach (var musica in musicaArtista)
        {
            Console.WriteLine($"{musica.Artista} - {musica.Nome}");
        }
    }

    public static void FiltrarMusicasPorAno(List<Music> musicas, string ano)
    {
        var musicaAno = musicas.Where(musica => musica.Ano!.Equals(ano)) // encontra as musicas onde o ano corresponde ao ano passado
        .OrderBy(musicas => musicas.Nome) // ordena as músicas pelo nome
        .Select(musicas => musicas.Nome) // seleciona apenas o nome das músicas
        .Distinct() // remove as duplicidades
        .ToList(); // converte o resultado em uma lista

        Console.WriteLine($"Músicas de {ano}");
        foreach (var musica in musicaAno)
        {
            Console.WriteLine($"{musica} - {ano}");
        }
    }
}
