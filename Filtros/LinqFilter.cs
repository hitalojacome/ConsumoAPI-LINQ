using Models;

namespace Filtros;

internal class LinqFilter
{
    // Método estático que filtra e exibe todos os gêneros de músicas
    public static void FiltrarTodosGeneros(List<Music> musicas)
    {
        var todosGeneros = musicas.Select(genero => genero.Genero) // Seleciona todos os gêneros
        .Distinct() // Remove as duplicidades
        .ToList(); // Converte o resultado em uma lista

        // Imprime os generos no console
        foreach (var genero in todosGeneros)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    // Método estático que filtra e exibe artistas de um gênero específico
    public static void FiltrarArtistasPorGenero(List<Music> musicas, string genero)
    {
        var artistaPorGenero = musicas.Where(musica => musica.Genero!.Contains(genero)) // Filtra músicas pelo gênero especificado
        .Select(musica => musica.Artista) // seleciona artistas
        .Distinct() // Remove as duplicidades
        .ToList(); // Converte o resultado em uma lista

        // Imprime no console
        Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}");
        foreach (var artista in artistaPorGenero)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    // Método estático que filtra e exibe músicas de um artista específico
    public static void FiltrarMusicasPorArtista(List<Music> musicas, string nomeArtista)
    {
        // Filtra músicas pelo artista especificado
        var musicaArtista = musicas.Where(musica => musica.Artista!.Equals(nomeArtista))
        .ToList(); // converte o resultado em uma lista

        // Imprime no console
        Console.WriteLine(nomeArtista);
        foreach (var musica in musicaArtista)
        {
            Console.WriteLine($"{musica.Artista} - {musica.Nome}");
        }
    }

    // Método estático que filtra e exibe músicas de um ano específico
    public static void FiltrarMusicasPorAno(List<Music> musicas, string ano)
    {
        var musicaAno = musicas.Where(musica => musica.Ano!.Equals(ano)) // Filtra músicas pelo ano especificado
        .OrderBy(musicas => musicas.Nome) // Ordena as músicas pelo nome
        .Select(musicas => musicas.Nome) // Seleciona apenas o nome das músicas
        .Distinct() // Remove as duplicidades
        .ToList(); // Converte o resultado em uma lista

        // Imprime no console
        Console.WriteLine($"Músicas de {ano}");
        foreach (var musica in musicaAno)
        {
            Console.WriteLine($"{musica} - {ano}");
        }
    }

    // Método estático que filtra e exibe músicas de uma tonalidade específica
    public static void FiltrarMusicasTonalidade(List<Music> musicas, string tonalidade)
    {
        var musicaTonalidade = musicas.Where(musica => musica.Tonalidade!.Equals(tonalidade))
        .OrderBy(musicas => musicas.Nome) // Ordena as músicas pelo nome
        .Select(musicas => musicas.Nome)
        .ToList(); // Converte o resultado em uma lista

        // Imprime no console
        Console.WriteLine($"Músicas em {tonalidade}\n");
        foreach (var musica in musicaTonalidade)
        {
            Console.WriteLine($"{musica} - {tonalidade}");
        }
    }
}
