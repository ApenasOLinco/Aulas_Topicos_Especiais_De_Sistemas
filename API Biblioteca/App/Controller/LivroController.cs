namespace API_Biblioteca.App.Controller;

using API_Biblioteca.App.Data;
using API_Biblioteca.App.Model;

class LivrosController
{

    public static List<Livro> GetAllLivros()
    {
        return LivrosDB.Livros;
    }

    public static Livro GetLivro(int id) {
        return LivrosDB.Livros.Find(l => l.Id == id);
    }

}