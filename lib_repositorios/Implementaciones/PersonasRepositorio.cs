using lib_entidades.Modelos;
using lib_repositorios.Interfaces;
using System.Linq.Expressions;

namespace lib_repositorios.Implementaciones
{
    public class PersonasRepositorio : IPersonasRepositorio
    {
        private Conexion? conexion = null;

        public PersonasRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public List<Personas> Listar()
        {
            return conexion!.Listar<Personas>();
        }

        public List<Personas> Buscar(Expression<Func<Personas,bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Personas Guardar(Personas entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Personas Modificar(Personas entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Personas Borrar(Personas entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}