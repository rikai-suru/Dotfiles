using System.Diagnostics;

namespace SysthemThemeChanger.Settings;

public static class SwwwSettings
{
	public static void ChangeWallpaper(string filePath)
	{
		// using swww,
		ProcessStartInfo swww = new()
		{
			FileName       = "swww",
			Arguments      = $"img {filePath} --transition-step 5 --transition-fps 200", // --transition-step 20 --transition-fps 60 ", //"--transition-type any",
			CreateNoWindow = true,
		};

		Process.Start(swww);
	}

	enum TransitionType
	{
		Center,
		Any,
		Random,
		Wipe,
		Left,
		Right,
		Top,
		Bottom
	}

	private static string ParseFilePath(string filePath)
	{
		if (File.Exists(filePath))
		{
			return filePath;
		}
		else
		{
			Messages.WallpaperNotFound();
			throw new Exception();
		}
	}
}
