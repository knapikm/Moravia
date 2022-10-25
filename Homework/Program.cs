using Homework;
using Homework.Documents;
using Homework.Storages;
using System;
using System.IO;

namespace Moravia.Homework
{
	class Program
	{
		static void Main(string[] args)
		{
			// TODO: read from args (CommandLineParser or maybe some config file)
			var sourceFileName = Path.Combine(Environment.CurrentDirectory, "..\\..\\..\\SourceFiles\\Document2.json");
			var targetFileName = Path.Combine(Environment.CurrentDirectory, "..\\..\\..\\TargetFiles\\Document2.xml");

			var sourceStorageType = StorageType.FS; // TODO: only for this demo, read from args
			var input = Storage.ReadSource(sourceFileName, sourceStorageType);

			var inputType = Utils.GetDocumentType(sourceFileName); // TODO: this also could be done other way (args)
			var document = Document.FromInput(input, inputType);

			var outputType = Utils.GetDocumentType(targetFileName); // TODO: this also could be done other way (args)
			var output = Document.ToOutput(document, outputType);

			var targetStorageType = StorageType.FS; // TODO: only for this demo, read from args
			Storage.WriteTarget(output, targetFileName, targetStorageType);
		}
	}
}