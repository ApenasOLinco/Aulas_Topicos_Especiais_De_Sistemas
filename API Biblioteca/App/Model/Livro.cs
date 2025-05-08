namespace API_Biblioteca.App.Model;

public class Livro(int Id, string Titulo, string Autor, int AnoPublicacao)
{
    public int Id { get; set; } = Id;

    public string Titulo { get; set; } = Titulo;

    public string Autor { get; set; } = Autor;

    public int AnoPublicacao { get; set; } = AnoPublicacao;

}
