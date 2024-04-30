using SysthemThemeChanger.Settings;

namespace SysthemThemeChanger.Themes;

public static class ThemeSetter
{
	public static void SetTheme(ITheme theme, bool isFocusMode)
	{
		Settings.SwwwSettings.ChangeWallpaper(theme.Wallpaper);
		// Thread.Sleep(500);
		Settings.Qt5Settings.ChangeIconTheme(theme.Qt5IconTheme);
		Settings.Qt6Settings.ChangeIconTheme(theme.Qt6IconTheme);
		Settings.KvantumSettings.ChangeTheme(theme.KvantumTheme);
		Settings.AlacrittySettings.ChangeTheme(theme.AlacrittyTheme);
		Settings.GSettings.ChangeTheme(theme.GSettingsTheme);
		Settings.HyprlandSettings.ChangeColors(theme.HyprlandColors);
		Settings.AgsSettings.ChangeColors(theme.AgsColors);
		Settings.Gtk3Settings.ChangeMode(theme.Gtk3ThemeMode);

		SetFocus(isFocusMode);
	}

	public static ITheme ParseTheme(string inputTheme)
	{
		switch (inputTheme.ToLower())
		{
			case "moonlight":
				return new MoonlightTheme();
			case "skylight":
				return new SkylightTheme();
			case "midnight":
				return new MidnightTheme();
			default:
				throw new Exception("Given theme is not found.");
		}
	}

	private static void SetFocus(bool isFocusMode)
	{
		if (isFocusMode)
		{
			HyprlandSettings.ChangeFocusMode(true);
			// Thread.Sleep(500);
			AgsSettings.ChangeFocusMode(true);
		}
		else
		{
			HyprlandSettings.ChangeFocusMode(false);
			// Thread.Sleep(500);
			AgsSettings.ChangeFocusMode(false);
		}
	}
}
