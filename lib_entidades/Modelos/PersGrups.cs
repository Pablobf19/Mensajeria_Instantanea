using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades.Modelos
{

    public class PersGrups
    {
        [Key] public int Id { get; set; }
        public int Grupo { get; set; }
        public int Persona { get; set; }

        [NotMapped] public Personas? _Persona { get; set; }
        [NotMapped] public Grupos? _Grupo { get; set; }
        //O
        //public virtual Personas Persona { get; set; }
        //public virtual Grupos Grupo { get; set; }
    }
}