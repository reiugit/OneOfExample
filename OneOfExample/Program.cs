using OneOfExample;
using OneOfExample.Extensions;

var oneOfErrorResult = Divider
    .Create(5, 0)
    .PrintNumbers()
    .Divide();

// 1. Example for  OneOf.Match
oneOfErrorResult
    .Match(
        value => value.ToString(),
        error => error.Value)
    .Print("Using 'OneOf.Match'");

// 2. Example for  OneOf.Switch
oneOfErrorResult
    .Switch(
        value => value.Print("Using 'OneOf.Switch'"),
        error => error.Value.Print("Using 'OneOf.Switch'"));

// 3. Example for  OneOf.TryPickT0
(oneOfErrorResult
    .TryPickT0(out var value, out var error)
        ? value.ToString()
        : error.Value)
    .Print("Using 'OneOf.TryPickT0'");

// 4. Example for  OneOf.IsT0 and AsTo, AsT1
(oneOfErrorResult
    .IsT0
        ? oneOfErrorResult.AsT0.ToString()
        : oneOfErrorResult.AsT1.Value)
    .Print("Using 'OneOf.IsT0 and AsTo, AsT1'");


Console.WriteLine("\n\nPress any key to exit...");
Console.ReadKey();
