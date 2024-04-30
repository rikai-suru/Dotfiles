using Spectre.Console;

namespace SysthemThemeChanger;

public class Messages
{
	public static void HelpMessage()
	{
		AnsiConsole.MarkupLine("[red]Usage: Please provide a theme.[/]");
	}

	public static void ThemeNotFoundMessage()
	{
		AnsiConsole.MarkupLine("[red]Given theme is not found.[/]");
	}

	public static void WallpaperNotFound()
	{
		AnsiConsole.MarkupLine("[red]The given file path to the wallpaper is not found.[/]");
	}

	public static void DiscordThemeModeIncorrectInput()
	{
		AnsiConsole.MarkupLine(@"[red]Discord theme should only be ""light"" or ""dark"", case insensitive.");
	}
}
