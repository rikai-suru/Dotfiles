namespace SysthemThemeChanger.Settings;

public static class Qt5Settings
{
	private static string _qt5CtFile = Paths.Qt5File;

	public static void ChangeIconTheme(string input)
	{
		Helpers.ReplacePropertyValueInFile(_qt5CtFile, "icon_theme=", input);
	}
}
