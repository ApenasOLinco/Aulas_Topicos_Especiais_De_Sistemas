namespace API_Biblioteca.App.Data;

using API_Biblioteca.App.Model;

public class LivrosDB
{
    private static List<Livro> livros = [
        new(0, "Pumba", "Euzinho da Silva", 2006)
    ];

    internal static List<Livro> Livros { get => livros; set => livros = value; }
}