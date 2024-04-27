using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

class TransactionCategory
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]    
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public long Icon { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]    
    public DateTime CreatedOn { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]    
    public DateTime UpdatedOn { get; set; }
}