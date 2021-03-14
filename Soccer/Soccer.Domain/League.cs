using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Soccer.Domain
{
    public class League
    {
        [Key]
        public int LeagueId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(50, ErrorMessage = "La longitud máxima del campo {0} es de {1} carácteres")]
        [Index("League_Name_Index", IsUnique = true)]
        [Display(Name = "Liga")]
        public string Name { get; set; }

        [DataType(DataType.ImageUrl)]
        public string Logo { get; set; }
    }
}
