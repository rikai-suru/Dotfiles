namespace SysthemThemeChanger.Settings;

public static class AlacrittySettings
{
	public static void ChangeTheme(string theme)
	{
		// this assumes that you've manually changed first the file location and stuff
		// in the alacritty toml file.
		string pattern = @"/colors/.*\.toml";
		string replacement = $"/colors/{theme}.toml";
		// source=$colorscheme/skylight.conf

		Helpers.ReplacePatternInFile(Paths.Alacritty, pattern, replacement);
	}
}
