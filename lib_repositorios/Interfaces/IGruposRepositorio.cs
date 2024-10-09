using lib_entidades.Modelos;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface IGruposRepositorio
    {
        List<Grupos> Listar();
        List<Grupos> Buscar(Expression<Func<Grupos, bool>> condiciones);
        Grupos Guardar(Grupos entidad);
        Grupos Modificar(Grupos entidad);
        Grupos Borrar(Grupos entidad);
    }
}