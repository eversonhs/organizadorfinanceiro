using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

class Transaction
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]    
    public Guid Id { get; set; }
    public TransactionType Type { get; set; }
    public required TransactionCategory Category { get; set; }
    public required string Description { get; set; }
    public decimal Value { get; set; }
    public DateOnly Date { get; set; }
    public required Account Account { get; set; }
    public CreditCardBill? CreditCardBill { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]    
    public DateTime CreatedOn { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]    
    public DateTime UpdatedOn { get; set; }
}