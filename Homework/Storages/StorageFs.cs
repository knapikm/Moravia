using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Storages
{
	internal class StorageFs
	{
		internal static string Read(string sourceLocation)
		{
			string input;
			try
			{
				using (var sourceStream = File.Open(sourceLocation, FileMode.Open))
				{
					var reader = new StreamReader(sourceStream);
					input = reader.ReadToEnd();
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

			return input;
		}

		internal static void Write(string output, string targetName)
		{
			try
			{
				using (var targetStream = File.Open(targetName, FileMode.Create, FileAccess.Write))
				{
					var writer = new StreamWriter(targetStream);
					writer.Write(output);
					writer.Close();
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
