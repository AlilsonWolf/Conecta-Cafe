using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConectaCafe.Models;

[Table("Blog")]

public class Blog
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Required(ErrorMessage ="Por Favor, Informe o Titulo")]
    [StringLength(100,ErrorMessage ="O Titulo deve possuir no maximo 100 caracteres")]
    public string Titulo{ get; set; }

    [Required(ErrorMessage ="Por Favor, Insira o Texto")]
    [StringLength(500,ErrorMessage ="O tamanho maximo do texto e de 500 caracteres")]
    public string Texto { get; set; }

    [StringLength(200)]
    public string Foto { get; set; }
    

    public DateTime Datablog { get; set; }

    public ICollection<BlogTag> BlogTags { get; set; }
} 