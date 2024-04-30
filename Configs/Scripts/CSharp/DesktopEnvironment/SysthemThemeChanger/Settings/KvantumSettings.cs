namespace SysthemThemeChanger.Settings;

public static class KvantumSettings
{
	private static string _kvantumFile = Paths.Kvantum;

	public static void ChangeTheme(string input)
	{
		Helpers.ReplacePropertyValueInFile(_kvantumFile, "theme=", input);
	}
}
