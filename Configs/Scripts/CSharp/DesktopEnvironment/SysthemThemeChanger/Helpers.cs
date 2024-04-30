using System.IO;
using Spectre.Console;
using System.Text.RegularExpressions;

namespace SysthemThemeChanger;

public static class Helpers
{
	public static void ReplacePropertyValueInFile(string filePath, string pattern, string replacement)
	{
		// Read all lines from the file
		string[] lines = File.ReadAllLines(filePath);

		// Loop through each line and replace the text
		for (int i = 0; i < lines.Length; i++)
		{
			// Find the index of 'property='
			int index = lines[i].IndexOf(pattern);
			if (index != -1)
			{
				// Extract the substring after 'property='
				string newText = lines[i].Substring(index + pattern.Length);
				// Replace [any arbitrary text] with the input string
				lines[i] = lines[i].Replace(newText, replacement);
			}
		}

		// Write the modified lines back to the file
		File.WriteAllLines(filePath, lines);
	}

	public static void ReplacePatternInFile(string filePath, string pattern, string replacement)
	{
		string fileContent    = File.ReadAllText(filePath);
		string updatedContent = Regex.Replace(fileContent, pattern, replacement);

		File.WriteAllText(filePath, updatedContent);
	}
}
