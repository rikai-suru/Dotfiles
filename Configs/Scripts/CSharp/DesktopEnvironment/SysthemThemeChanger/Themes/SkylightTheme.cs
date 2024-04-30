namespace SysthemThemeChanger.Themes;

public class SkylightTheme : ITheme
{
	public string Qt5IconTheme   { get; set; } = "Papirus-Light";
	public string Qt6IconTheme   { get; set; } = "Papirus-Light";
	public string KvantumTheme   { get; set; } = "Skylight";
	public string AlacrittyTheme { get; set; } = "skylight";
	public string GSettingsTheme { get; set; } = "rose-pine-dawn-gtk";
	public string Wallpaper      { get; set; } = @"/mnt/LS/Files/Wallpaper/landscape/todd-diemer-67t2GJcD5PI-unsplash.jpg";
	public string HyprlandColors { get; set; } = "skylight";
	public string AgsColors      { get; set; } = "skylight";
	public string Gtk3ThemeMode  { get; set; } = "light";

	public bool IsFocusMode { get; set; } = false;
}
