using System.Diagnostics;

namespace StartUpAppsLauncher;

static class Program
{
	static void Main(string[] args)
	{
		if (DateTime.Now.Hour >= 8)
		{
			ProcessStartInfo psi = new() {
				FileName       = "/home/rikai/scripts/csharp/SysthemThemeChanger",
				Arguments      = "skylight true",
				CreateNoWindow = true,
			};

			Process.Start(psi);
		}
		else
		{
			ProcessStartInfo psi = new() {
				FileName       = "/home/rikai/scripts/csharp/SysthemThemeChanger",
				Arguments      = "migdnight true",
				CreateNoWindow = true,
			};

			Process.Start(psi);
		}
		Process.Start(StartUpApps.Ags);
		Thread.Sleep(60000);
		Process.Start(StartUpApps.NmApplet);
		Process.Start(StartUpApps.Copyq);
	}
}
