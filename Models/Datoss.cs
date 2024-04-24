using System.ComponentModel.DataAnnotations;

namespace AndradeLeonardo_ExamenProgreso1.Models
{
    public class Datoss
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Es obligacion llenar el nombre")]
        public String Nombre { get; set; }

        [Required(ErrorMessage = "Es obligacion llenar el espacio")]
        public float sueldo { get; set; }


        [Required(ErrorMessage = "Es obligacion llenar el espacio")]
        public bool Pregunta { get; set; }


        public DateTime Fecha { get; set; }

    }
}

