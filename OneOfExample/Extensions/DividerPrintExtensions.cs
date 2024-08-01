namespace OneOfExample.Extensions;

internal static class DividerPrintExtensions
{
    public static Divider PrintNumbers(this Divider divider)
    {
        Console.WriteLine($"\nDivision: {divider.Dividend} / {divider.Divisor}\n");

        return divider;
    }
}
