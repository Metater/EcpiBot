#pragma warning disable IDE0079 // Remove unnecessary suppression
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
#pragma warning disable CA1822 // Mark members as static

public class GeneralModule : BaseCommandModule
{
    [Command("hey"), Description("Hey command")]
    public async Task Hey(CommandContext ctx)
    {
        await ctx.RespondAsync("Hey there!");
    }
}