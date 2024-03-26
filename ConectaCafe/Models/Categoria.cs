using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConectaCafe.Models;

[Table("Categoria")]

public class Categoria
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Required(ErrorMessage ="Por Favor, Informe o Nome")]
    [StringLength(30,ErrorMessage ="O nome deve possuir no maximo 30 caracteres")]
    public string Nome{ get; set; }
}  