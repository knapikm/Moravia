using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Storages
{
	public enum StorageType { FS, HTTP }; // TODO: another storages....

	public class Storage
	{
		public static string ReadSource(string sourceLocation, StorageType storageType)
		{
			switch(storageType)
			{
				case StorageType.FS:
					return StorageFs.Read(sourceLocation);

				// TODO: another storages....

				default:
					return null;
			}
		}

		public static void WriteTarget(string output, string targetLocation, StorageType storageType)
		{
			switch(storageType)
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
