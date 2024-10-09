 
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;



namespace lib_entidades.Modelos
{
    public class Mensajes
    {
        [Key] public int Id { get; set; }
        public string? Contenido { get; set; }
        public DateTime Fecha { get; set; }
        public int Estado { get; set; }
        public bool Borrado { get; set; }
        public int De { get; set; }
        public int? Para { get; set; }
        public int? Grupo { get; set; }

        [NotMapped] public Personas? _De { get; set; }
        [NotMapped] public Personas? _Para { get; set; }
        [NotMapped] public Estados? _Estado { get; set; }
        [NotMapped] public Grupos? _Grupo { get; set; }

        public void InsertarMensaje()
        {
        }

    }
    
}
