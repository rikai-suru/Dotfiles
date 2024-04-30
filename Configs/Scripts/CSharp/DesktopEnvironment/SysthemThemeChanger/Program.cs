using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Spectre.Console;
using Spectre.Console.Cli;
using SysthemThemeChanger.Commands;

namespace SysthemThemeChanger;

public static class Program
{
	public static int Main(string[] args)
	{
		var app = new CommandApp<ThemeCommand>();
		return app.Run(args);
	}
}
