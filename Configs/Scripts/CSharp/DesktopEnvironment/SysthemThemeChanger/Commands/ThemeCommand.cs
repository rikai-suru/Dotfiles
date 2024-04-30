using System.Diagnostics.CodeAnalysis;
using Spectre.Console;
using Spectre.Console.Cli;
using SysthemThemeChanger.Settings;
using SysthemThemeChanger.Themes;

namespace SysthemThemeChanger.Commands;

internal sealed class ThemeCommand : Command<ThemeCommand.Settings>
{
	public sealed class Settings : CommandSettings
	{
		// [Description("Name of the theme to use")]
		[CommandArgument(0, "[THEME]")]
		public string? Theme { get; init; }

		// [Description("Whether focus mode is enabled")]
		[CommandArgument(1, "[FOCUS MODE]")]
		public bool IsFocusMode { get; init; } = false;
	}

	public override int Execute([NotNull] CommandContext context, [NotNull] Settings settings)
	{
		// Check if input theme string argument is null; exists if null
		if (settings.Theme == null)
		{
			Messages.HelpMessage();
			return 1;
		}
		// Debugging stuff
		// else if (settings.Theme == "uwuOwOI'mdebuggingDeSu")
		// {
		// 	var thingy = File.ReadAllLines(Paths.Alacritty);
		// 	foreach (var thing in thingy)
		// 	{
		// 		Console.WriteLine(thing);
		// 	}
		//
		// 	AlacrittySettings.ChangeTheme("rose-pine-dawn");
		//
		// 	thingy = File.ReadAllLines(Paths.Alacritty);
		// 	foreach (var thing in thingy)
		// 	{
		// 		Console.WriteLine(thing);
		// 	}
		// 	return 0;
		// }

		// Parse theme profile from input string
		ITheme theme = ThemeSetter.ParseTheme(settings.Theme);
		// Set settings based on theme profile
		ThemeSetter.SetTheme(theme, settings.IsFocusMode);

		return 0;
	}
}
