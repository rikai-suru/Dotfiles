namespace SysthemThemeChanger.Settings;

public static class HyprlandSettings
{
	public static void ChangeColors(string theme)
	{
		string pattern = @"colorscheme/.*\.conf";
		string replacement = @$"colorscheme/{theme}.conf";

		if (ThemeExistCheck())
		{
			// Console.WriteLine(Paths.HyprlandConfig);
			Helpers.ReplacePatternInFile(Paths.HyprlandConfig, pattern, replacement);
		}
	}

	public static void ChangeFocusMode(bool isFocusMode)
	{
		string pattern = @"source=\$focused/[A-Za-z]+\.conf";
		string replacement;

		if (isFocusMode)
		{
			replacement = @"source=$focused/enabled.conf";
			Helpers.ReplacePatternInFile(Paths.HyprlandConfig, pattern, replacement);
		}
		else
		{
			replacement = @"source=$focused/disabled.conf";
			Helpers.ReplacePatternInFile(Paths.HyprlandConfig, pattern, replacement);
		}
	}

	private static bool ThemeExistCheck()
	{
		return true;
	}
}
