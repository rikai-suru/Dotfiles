namespace SysthemThemeChanger.Themes;

public interface ITheme
{
	public string Qt5IconTheme   { get; set; }
	public string Qt6IconTheme   { get; set; }
	public string KvantumTheme   { get; set; }
	public string AlacrittyTheme { get; set; }
	public string GSettingsTheme { get; set; }
	public string Wallpaper      { get; set; }
	public string HyprlandColors { get; set; }
	public string AgsColors      { get; set; }
	public string Gtk3ThemeMode  { get; set; }

	public bool IsFocusMode { get; set; }
	// public bool   HyprlandIsFocused { get; set; }
	// public bool   AgsIsFocused      { get; set; }
}

public class Test
{
	public string UwU;
}
