using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Account {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]    
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Instituition { get; set; }
    public AccountType Type { get; set; }
    public decimal Balance { get; set; }
    
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]    
    public DateTime CreatedOn { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]    
    public DateTime UpdatedOn { get; set; }
}