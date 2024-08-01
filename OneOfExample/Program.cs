using OneOfExample;
using OneOfExample.Extensions;
using OneOfExample.Keyhandler;

var oneOfErrorResult = Divider
    .Create(5, 0)
    .PrintNumbers()
    .Divide();

// 1. Example for:  OneOf.Match
oneOfErrorResult
    .Match(
        value => value.ToString(),
        error => error.Value)
    .Print("OneOf.Match");

// 2. Example for:  OneOf.Switch
oneOfErrorResult
    .Switch(
        value => value.Print("OneOf.Switch"),
        error => error.Value.Print("OneOf.Switch"));

// 3. Example for:  OneOf.TryPickTx
(oneOfErrorResult
    .TryPickT0(out var value, out var error)
        ? value.ToString()
        : error.Value)
    .Print("OneOf.TryPickTx");

// 4. Example for:  OneOf.IsTx and AsTx
(oneOfErrorResult
    .IsT0
        ? oneOfErrorResult.AsT0.ToString()
        : oneOfErrorResult.AsT1.Value)
    .Print("OneOf.IsTx and OneOf.AsTx");


KeyHandler.WaitForKey();
