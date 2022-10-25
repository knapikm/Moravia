using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Storages
{
	public enum StorageType { FS, HTTP }; // ...

	public class Storage
	{
		public static string ReadSource(string sourceLocation, StorageType inputType)
		{
			switch(inputType)
			{
				case StorageType.FS:
					return StorageFs.Read(sourceLocation);

				// TODO: another storages....

				default:
					return null;
			}
		}

		public static void WriteTarget(string output, string targetLocation, StorageType outputType)
		{
			switch(outputType)
			{
				case StorageType.FS:
					StorageFs.Write(output, targetLocation);
					break;

				// TODO: another storages....

				default:
					return;
			}
		}
	}
}
