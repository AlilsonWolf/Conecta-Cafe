using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConectaCafe.Models
{
   [Table("Produto")]

public class Produto
{
    [Key]
   [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage ="Por Favor, Informe o Nome")]
    [StringLength(60,ErrorMessage ="O nome deve possuir no maximo 60 caracteres")]
    public string Nome{ get; set; }

   [Display(Name ="Descrição")]
   [StringLength(200,ErrorMessage ="A descrição deve possuir no minimo 200 caracteres")]
    public string Descricao{ get; set; }

    [Display(Name ="Preço")]
    [Column(TypeName ="decimal (8,2)")]
    [Required(ErrorMessage ="Por Favor, informe o preço")]
    public decimal Preco{ get; set; }

    
   [Display(Name ="Foto")]
   [StringLength(200)]
    public string Foto{ get; set; }
    
    [Display(Name ="Categoria")]
    [Required(ErrorMessage ="Por Favor informe a categoria")]
    public int CategoriaId { get; set; }
    [ForeignKey("CategoriaId")]
    public Categoria Categoria { get; set; }
}  
}