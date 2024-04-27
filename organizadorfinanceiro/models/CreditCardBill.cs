using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

class CreditCardBill
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]    
    public Guid Id { get; set; }
    public required CreditCard CreditCard { get; set; }
    public decimal Total { get; set; }
    public decimal PayedValue { get; set; }
    public DateOnly PaymentDate { get; set; }
    public DateOnly ReferenceDate { get; set; }
    public CreditCardBillStatus Status { get; set; }


    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]    
    public DateTime CreatedOn { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]    
    public DateTime UpdatedOn { get; set; }
}