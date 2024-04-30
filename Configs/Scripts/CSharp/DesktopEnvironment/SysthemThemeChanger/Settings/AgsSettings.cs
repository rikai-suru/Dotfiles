using System.Diagnostics;

namespace SysthemThemeChanger.Settings;

public static class AgsSettings
{

	public static void ChangeColors(string colors)
	{
		string pattern     = @"colors/.*\.scss";
		string replacement = $"colors/{colors}.scss";

		Helpers.ReplacePatternInFile(Paths.AgsColors, pattern, replacement);
	}

	public static void ChangeFocusMode(bool isFocusMode)
	{
		string filePath = Paths.AgsScss;
		string pattern  = @"@use 'css/[A-Za-z0-9]+_bar';";

		if (isFocusMode)
		{
			Helpers.ReplacePatternInFile(filePath, pattern, @"@use 'css/docked_bar';");
		}
		else
		{
			Helpers.ReplacePatternInFile(filePath, pattern, @"@use 'css/floating_bar';");
		}
	}
}
