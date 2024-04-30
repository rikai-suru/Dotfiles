using Rikai.DesktopEnvironment;

namespace SysthemThemeChanger;

public static class Paths
{
	private static char separator = Path.DirectorySeparatorChar;

	// aliases
	public static string Home    = Environment.GetEnvironmentVariable("HOME");
	public static string Config  = $"{Home}{separator}.config{separator}";
	public static string Scripts = $"{Home}{separator}scripts{separator}";
	public static string Settings = $"{Scripts}settings{separator}";

	public static string Qt5File          = $"{Config}qt5ct{separator}qt5ct.conf";
	public static string Qt6File          = $"{Config}qt6ct{separator}qt6ct.conf";
	public static string Kvantum          = $"{Config}Kvantum{separator}kvantum.kvconfig";
	public static string Alacritty        = $"{Config}alacritty{separator}alacritty.toml";
	public static string AlacrittyThemes  = $"{Scripts}alacritty{separator}colors{separator}";
	public static string HyprlandConfig   = $"{Config}hypr/hyprland.conf";
	public static string Gtk3SettingsFile = $"{Config}gtk-3.0/settings.ini";
	public static string AgsColors        = $"{Config}ags/css/_colors.scss";
	public static string AgsScss          = $"{Config}ags/style.scss";

	// public static string HyprlandColors  = $"{Settings}hypr{separator}colors{separator}";
}
