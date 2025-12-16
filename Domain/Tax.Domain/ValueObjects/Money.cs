
namespace Tax.Domain.ValueObjects;

public sealed record Money
{
    public decimal Amount { get; private set; }

    public Money(decimal? amount)
    {
        Amount = amount ?? throw new ArgumentNullException(nameof(amount));
    }
    private Money()
    {
        
    }

    public override string ToString()
    {
        return Amount.ToString();
    }
}
