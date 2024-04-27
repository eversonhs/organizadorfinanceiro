using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

class CreditCard
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]    
    public Guid Id { get; set; }
    public int Name { get; set; }
    public Account? Account { get; set; }
    public decimal Limit { get; set; }
    public DateOnly DueDate { get; set; }
    public DateOnly ClosingDate { get; set; }
    public CreditCardBrand Brand { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]    
    public DateTime CreatedOn { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]    
    public DateTime UpdatedOn { get; set; }
}