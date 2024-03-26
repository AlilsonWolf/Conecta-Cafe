using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConectaCafe.Models;

[Table("Avaliacao")]

public class Avaliacao
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Required(ErrorMessage ="Por Favor, Informe o Nome")]
    [StringLength(60,ErrorMessage ="O nome deve possuir no maximo 60 caracteres")]
    public string Pessoa{ get; set; }

    [Required(ErrorMessage ="Por Favor, Insira o Titulo")]
    [StringLength(100,ErrorMessage ="O tamanho maximo do titulo e de 100 caracteres")]
    public string Titulo { get; set; }

    [Required(ErrorMessage ="Por Favor, Insira o Texto")]
    [StringLength(500,ErrorMessage ="O tamanho maximo do texto e de 500 caracteres")]
    public string Texto { get; set; }
    [Required(ErrorMessage ="Informe sua nota")]
    [Column(TypeName ="decimal (1,0)")]
    public decimal Nota { get; set; }


    [Display(Name ="Data da Avaliação")]
    [DataType(DataType.Date)]
    public DateTime  DataAvaliacao { get; set; }
} 