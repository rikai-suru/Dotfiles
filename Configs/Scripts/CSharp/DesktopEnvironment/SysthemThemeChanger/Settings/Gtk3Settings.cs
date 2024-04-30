namespace SysthemThemeChanger.Settings;

public static class Gtk3Settings
{
	public static void ChangeMode(string input)
	{
		string filePath = Paths.Gtk3SettingsFile;
		string pattern;
		string replacement;
		switch (input.ToLower())
		{
			case "light":
				pattern     = "gtk-theme-name=Adwaita-dark";
				replacement = @"gtk-theme-name=Adwaita";
				Helpers.ReplacePatternInFile(filePath, pattern, replacement);
				break;
			case "dark":
				pattern     = "gtk-theme-name=Adwaita";
				replacement = @"gtk-theme-name=Adwaita-dark";
				Helpers.ReplacePatternInFile(filePath, pattern, replacement);
				break;
			default:
				Messages.DiscordThemeModeIncorrectInput();
				break;
		}
	}
}
