using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_entidades.Modelos
{
    public class Detalles
    {
        [Key] public int Id { get; set; }
        public int Mensaje { get; set; }
        public int Para { get; set; }
        public int Estado { get; set; }

        [NotMapped] public Personas? _Persona { get; set; }
        [NotMapped] public Estados? _Estado { get; set; }
        [NotMapped] public Mensajes? _Mensaje { get; set; }
    }
}
