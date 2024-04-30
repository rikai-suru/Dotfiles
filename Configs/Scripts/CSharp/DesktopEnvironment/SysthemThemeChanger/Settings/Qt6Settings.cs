namespace SysthemThemeChanger.Settings;

public static class Qt6Settings
{
	private static string _qt6CtFile = Paths.Qt6File;

	public static void ChangeIconTheme(string input)
	{
		Helpers.ReplacePropertyValueInFile(_qt6CtFile, "icon_theme=", input);
	}
}
