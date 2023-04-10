using System.ComponentModel.DataAnnotations;

namespace Libreria.Models;

public class LibroViewModel 
{
    public string Codigo { get; set; }

    [Required]
    public string Titulo { get; set; }
    public string Autor { get; set; }
    [Range(1,int.MaxValue)]
    public int Precio { get; set; }
}