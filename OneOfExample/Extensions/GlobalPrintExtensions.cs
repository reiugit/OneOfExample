namespace OneOfExample.Extensions;

internal static class GlobalPrintExtensions
{
    public static void Print<T>(this T value, string title)
    {
        Console.WriteLine($"\nUsing '{title}':\nResult: {value}");
    }
}
