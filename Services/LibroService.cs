using Libreria.Models;

namespace Libreria.Services;

public static class LibroService{
    static List<LibroViewModel> Libros { get; set;}

    static LibroService(){
        Libros = new List<LibroViewModel>
        {
            new LibroViewModel { Titulo = "El código Da Vinci", Codigo = "CDV", Autor="Dan Brown", Precio=120 },
            new LibroViewModel { Titulo = "Cien años de soledad", Codigo = "CAS", Autor="Gabriel García Márquez", Precio=200 },
            new LibroViewModel { Titulo = "El nombre del viento", Codigo = "ENV", Autor="Patrick Rothfuss", Precio=150 }
        };
    }

    public static List<LibroViewModel> GetAll() => Libros;

    public static void Add(LibroViewModel obj){
        if(obj == null){
            return;
        }

        Libros.Add(obj);
    }

    public static LibroViewModel? Get(string codigo) => Libros.FirstOrDefault(x => x.Codigo.ToLower() == codigo.ToLower());

    public static void Delete(string codigo){
        var libroABorrar = Libros.FirstOrDefault(x => x.Codigo.ToLower() == codigo.ToLower());
        if (libroABorrar != null)
        {
            Libros.Remove(libroABorrar);
        }
    }
}