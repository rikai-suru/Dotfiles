using System.Diagnostics;

namespace Rikai.DaemonLauncher;

static class Program
{
	static void Main(string[] args)
	{
		Process.Start(Daemons.Polkit);                 // kde polkit
		Process.Start(Daemons.Pipewire);               // pipewire
		Process.Start(Daemons.Dunst);                  // dunst
		Process.Start(Daemons.SwwwDaemon);             // swww --format xrgb
		Process.Start(Daemons.SwayosdLibInputBackend); // swayosd-server
		Process.Start(Daemons.SwayosdServer);          // swayosd-libinput-backend
	}
}
