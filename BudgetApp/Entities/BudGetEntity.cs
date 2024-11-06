namespace BudgetApp.Entities;

public class BudGetEntity
{
    public string? Id { get; set; }
    public string? Description { get; set; }
    public DateTime SpendingDate { get; set; }
    public decimal Amount { get; set; }
    public string? IdCategory { get; set; }
}
