using System.Diagnostics;

namespace StartUpAppsLauncher;

public static class StartUpApps
{
	public static ProcessStartInfo NmApplet = new() {
		FileName       = "nm-applet",
		CreateNoWindow = true,
	};

	public static ProcessStartInfo Ags = new() {
		FileName       = "ags",
		CreateNoWindow = true,
	};

	public static ProcessStartInfo Copyq = new() {
		FileName       = "copyq",
		Arguments      = "--start-server",
		CreateNoWindow = true,
	};
}
