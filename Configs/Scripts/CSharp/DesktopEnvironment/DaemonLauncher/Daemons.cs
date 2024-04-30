using System.Diagnostics;
using Rikai.DesktopEnvironment;

namespace Rikai.DaemonLauncher;

public class Daemons
{
	public static ProcessStartInfo SwwwDaemon = new()
	{
		FileName = "swww-daemon",
		CreateNoWindow = true,
	};

	public static ProcessStartInfo Polkit = new()
	{
		FileName       = $"/usr/lib/polkit-kde-authentication-agent-1",
		CreateNoWindow = true,
	};

	public static ProcessStartInfo Dunst = new()
	{
		FileName       = "dunst",
		CreateNoWindow = true,
	};

	public static ProcessStartInfo Pipewire = new()
	{
		FileName       = "pipewire",
		CreateNoWindow = true,
	};

	public static ProcessStartInfo SwayosdServer = new()
	{
		FileName       = "swayosd-server",
		CreateNoWindow = true,
	};
	
	public static ProcessStartInfo SwayosdLibInputBackend = new()
	{
		FileName         = $"/bin/{Preferences.Shell}",
		CreateNoWindow   = true,
		 UseShellExecute = false,
		 Arguments       = string.Format("-c \"echo {0} | sudo -S {1}\"", Preferences.Password, "swayosd-libinput-backend"),
	};
}