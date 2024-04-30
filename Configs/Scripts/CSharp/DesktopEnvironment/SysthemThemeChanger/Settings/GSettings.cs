using System.Diagnostics;

namespace SysthemThemeChanger.Settings;

public static class GSettings
{
	public static void ChangeTheme(string input)
	{
		ProcessStartInfo gtheme = new()
		{
			FileName       = "gsettings",
			Arguments      = $"set org.gnome.desktop.interface gtk-theme '{input}'",
			CreateNoWindow = true,
		};

		Process.Start(gtheme);
	}
}
