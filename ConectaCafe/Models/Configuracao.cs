using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConectaCafe.Models;

[Table("Configuracao")]

public class Configuracao
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [StringLength(200)]
    public string Horario{ get; set; }

    [StringLength(20)]
    public string Teleforne { get; set; }
}  