namespace SysthemThemeChanger.Themes;

public class MidnightTheme : ITheme
{
	public string Qt5IconTheme   { get; set; } = "Papirus-Dark";
	public string Qt6IconTheme   { get; set; } = "Papirus-Dark";
	public string KvantumTheme   { get; set; } = "Moonlight";
	public string AlacrittyTheme { get; set; } = "moonlight";
	public string GSettingsTheme { get; set; } = "rose-pine-moon-gtk";
	public string Wallpaper      { get; set; } = @"/home/rikai/Pictures/Wallpaper/scene/sasha-freemind-nXo2ZsKHTHg-unsplash.jpg";
	public string HyprlandColors { get; set; } = "moonlight";
	public string AgsColors      { get; set; } = "moonlight";
	public string Gtk3ThemeMode  { get; set; } = "dark";

	public bool IsFocusMode { get; set; } = true;
	// public bool   AgsIsFocused      { get; set; } = false;
	// public bool   HyprlandIsFocused { get; set; } = false;
}
