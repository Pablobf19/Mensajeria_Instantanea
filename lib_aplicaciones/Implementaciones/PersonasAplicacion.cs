

using lib_aplicaciones.Interfaces;
using lib_entidades.Modelos;

namespace lib_aplicaciones.Implementaciones
{
    public class PersonasAplicacion : IPersonasAplicacion
    {
        private IPersonasAplicacion? iRepositorio = null;

        public PersonasAplicacion(IPersonasAplicacion iRepositorio)
        {
            this.iRepositorio = iRepositorio;
        }

        public Personas Borrar(Personas entidad)  //y preguntar si aca se debe remplazar
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad.Id == 0)
                throw new Exception("lbNoSeGuardo");

            entidad = iRepositorio!.Borrar(entidad);
            return entidad;
        }

        public Personas Borrar(Personas entidad)  //preguntar de donde sale esto y si modifica la tabla personas o por que se llama personas
        {
            throw new NotImplementedException();
        }

        public Personas Guardar(Personas entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad.Id != 0)
                throw new Exception("lbYaSeGuardo");

            entidad = Calcular(entidad);
            entidad = iRepositorio!.Guardar(entidad);
            return entidad;
        }

        public Personas Guardar(Personas entidad)
        {
            throw new NotImplementedException();
        }

        public List<Personas> Listar()
        {
            return iRepositorio!.Listar();
        }

        public Personas Modificar(Personas entidad)
        {
            if (entidad == null)
                throw new Exception("lbFaltaInformacion");

            if (entidad.Id == 0)
                throw new Exception("lbNoSeGuardo");

            entidad = Calcular(entidad);
            entidad = iRepositorio!.Modificar(entidad);
            return entidad;
        }

        public Personas Modificar(Personas entidad)
        {
            throw new NotImplementedException();
        }

       // private Personas Calcular(Personas entidad)  //preguntar si aca se hacen todos los metodos
      //  {
        //    entidad.Final = (entidad.Nota1 +
        //        entidad.Nota2 +
        //        entidad.Nota3 +
        //        entidad.Nota4 +
        //        entidad.Nota5) / 5;
       //     entidad.Fecha = DateTime.Now;
        //    return entidad;
      //  }

        List<Personas> IPersonasAplicacion.Listar()
        {
            throw new NotImplementedException();
        }
    }
}
