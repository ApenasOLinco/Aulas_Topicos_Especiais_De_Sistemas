using API_Biblioteca.App.Data;
using API_Biblioteca.App.Model;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace API_Biblioteca.App.Controller;

[Route("api/[controller]")]
[ApiController]
public class LivrosController : ControllerBase
{

    [HttpGet]
    public ActionResult<List<Livro>> GetAll()
    {
        return Ok(LivrosDB.Livros);
    }

    [HttpGet("{id}")]
    public ActionResult<Livro> GetSingle([FromRoute] int id)
    {
        Livro? livro = LivrosDB
            .Livros
            .Find(livro => livro.Id == id);

        if (livro == null) return NotFound();

        return Ok(livro);
    }

    [HttpPost]
    public ActionResult<Livro> NovoLivro([FromBody] Livro livro)
    {
        Livro? mesmoId = LivrosDB
            .Livros
            .Find(l => l.Id == livro.Id);

        if (mesmoId != null) {
            return Conflict();
        }

        LivrosDB
            .Livros
            .Add(livro);

        return CreatedAtAction(nameof(GetSingle), new { id = livro.Id }, livro);
    }

    [HttpDelete("{id}")]
    public ActionResult ApagarLivro([FromRoute] int id)
    {
        int index = LivrosDB
            .Livros
            .FindIndex(l => l.Id == id);

        if(index == -1) {
            return NotFound();
        }

        LivrosDB
            .Livros
            .RemoveAt(index);

        return NoContent();
    }

}
