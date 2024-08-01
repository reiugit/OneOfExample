using OneOf;
using OneOf.Types;

namespace OneOfExample;

internal class Divider
{
    private Divider(double dividend, double divisor)
    {
        Dividend = dividend;
        Divisor = divisor;
    }

    public double Dividend { get; }
    public double Divisor { get; }

    public static Divider Create(double dividend, double divisor)
        => new(dividend, divisor);

    public OneOf<double, Error<string>> Divide() =>
        Divisor != 0
        ? Dividend / Divisor
        : new Error<string>("Infinite");
}
