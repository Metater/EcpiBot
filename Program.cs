// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string token = File.ReadAllText(Directory.GetCurrentDirectory() + @"\token.secret");

var discord = new DiscordClient(new DiscordConfiguration()
{
    Token = token,
    TokenType = TokenType.Bot,
    Intents = DiscordIntents.AllUnprivileged,
    MinimumLogLevel = LogLevel.Information
});

discord.UseInteractivity();

var commands = discord.UseCommandsNext(new CommandsNextConfiguration()
{
    StringPrefixes = new[] { "!" },
    EnableDms = false
});

commands.RegisterCommands<GeneralModule>();

await discord.ConnectAsync();

await Task.Delay(5000);

while (true)
{
    if (!Console.KeyAvailable)
    {
        await Task.Delay(100);
    }

    ConsoleKey key = Console.ReadKey().Key;

    if (key == ConsoleKey.X)
    {
        break;
    }
}